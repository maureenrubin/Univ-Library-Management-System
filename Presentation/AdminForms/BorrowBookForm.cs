using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Presentation.UserForms;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class BorrowBookForm : Form
    {
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices;
        private readonly IBorrowBookServices borrowServices;
        private readonly IUserServices userServices;
        private readonly BooksEntity booksEntity;
        private readonly UserBookForm bookForm;

        public BorrowBookForm(IBookServices bookServices,
                              ICategoryServices categoryServices,
                              IBorrowBookServices borrowServices,
                              IUserServices userServices,
                              BooksEntity booksEntity,
                              UserBookForm bookForm)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.borrowServices = borrowServices;
            this.userServices = userServices;
            this.booksEntity = booksEntity;
            this.bookForm = bookForm;
        }

        public async Task LoadBorrowBookDetails(int bookId)
        {
            try
            {
                if (bookId <= 0)
                {
                    MessageBox.Show("Invalid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var bookDetails = await bookServices.GetBookByIdAsync(bookId);
                if (bookDetails == null)
                {
                    MessageBox.Show("Invalid book data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BookIdLBL.Text = bookDetails.BookId.ToString();
                BookTitle.Text = bookDetails.Title;
                BarrowedPriceLBL.Text = bookDetails.BookPrice.ToString("C");
                BookPB.Image = bookDetails.BooksPicture != null
                    ? Image.FromStream(new MemoryStream(bookDetails.BooksPicture))
                    : null;

                BarrowBookBTN.Enabled = bookDetails.BookStock > 0;
                BarrowDateLBL.Text = DateTime.UtcNow.ToShortDateString();
                DueDateLBL.Text = DateTime.Now.AddDays(7).ToShortDateString();
                StockLBL.Text = bookDetails.BookStock.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load book details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BarrowBookBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(QuantityTXT.Text, out int borrowQuantity) || borrowQuantity <= 0)
                {
                    MessageBox.Show("Enter a valid borrow quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var loggedInUser = await userServices.GetLoggedInUserAsync("User");
                if (loggedInUser == null)
                {
                    MessageBox.Show("Please log in as a user to borrow a book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (booksEntity.BookStock < borrowQuantity)
                {
                    MessageBox.Show("The selected book is out of stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bool bookBorrowed = await borrowServices.AddBorrowBookAsync(loggedInUser.UserId, booksEntity.BookId, borrowQuantity);
                if (bookBorrowed)
                {
                    booksEntity.BookStock -= borrowQuantity;
                    UpdateBookStockUI(booksEntity.BookId, booksEntity.BookStock);
                    MessageBox.Show("Book successfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadBorrowBookDetails(booksEntity.BookId);
                    FormsControlHelper.ClearControls(BorrowPanel);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to borrow the book. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateBookStockUI(int bookId, int newStock)
        {
            bookForm.UpdateBookStock(bookId, newStock);
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelBarrowBTN_Click(object sender, EventArgs e)
        {
            FormsControlHelper.ClearControls(BorrowPanel);
            this.Close();
        }
    }
}
