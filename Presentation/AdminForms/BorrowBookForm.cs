using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
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

        private readonly UserEntity userEntity;
        private readonly BooksEntity booksEntity;
       

        public BorrowBookForm(IBookServices bookServices,
                              ICategoryServices categoryServices,
                              IBorrowBookServices borrowServices,
                              IUserServices userServices,
                              BooksEntity booksEntity,
                              UserEntity userEntity)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.borrowServices = borrowServices;
            this.userServices = userServices;

            this.booksEntity = booksEntity;
            this.userEntity = userEntity;
        }


        public async Task LoadBarrowBookDetails(int bookId)
        {
            try
            {
                if (bookId <= 0)
                {
                    MessageBox.Show("Invalid Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var bookDetails = await bookServices.GetBookByIdAsync(bookId);

                if (bookId == 0)
                {
                    MessageBox.Show("Invalid book data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BookIdLBL.Text = bookDetails.BookId.ToString();
                BookTitle.Text = bookDetails.Title;
                BarrowedPriceLBL.Text = bookDetails.BookPrice.ToString("C");


                if (bookDetails.BooksPicture != null)
                    {
                        using (var ms = new MemoryStream(bookDetails.BooksPicture))
                        {
                            BookPB.Image = Image.FromStream(ms);

                        }
                    }
                    else
                    {
                        BookPB.Image = null;
                    }
                

                BarrowBookBTN.Enabled = bookDetails.BookStock > 0;
                BarrowDateLBL.Text = DateTime.UtcNow.ToShortDateString();
                DueDateLBL.Text = DateTime.Now.AddDays(7).ToShortDateString();
                StockLBL.Text = $"{bookDetails.BookStock}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load book details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BarrowBookBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (booksEntity == null || booksEntity.BookId == 0)
                {
                    MessageBox.Show("Invalid book data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(userEntity.UserId == 0)
                {
                    MessageBox.Show("User ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (userEntity == null || userEntity.UserId == 0)
                {
                    throw new Exception("Invalid userEntity or UserId.");
                }


                if (string.IsNullOrEmpty(StockLBL.Text) || !int.TryParse(StockLBL.Text, out int stock) || stock <= 0)
                {
                    MessageBox.Show("The selected book is out of stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var borrowBook = new BorrowBookEntity
                {
                    BookId = booksEntity.BookId,
                    UserId = userEntity.UserId,
                    Quantity = 1,
                    BarrowedDate = DateTime.UtcNow,
                    DueDate = DateTime.UtcNow.AddDays(7),
                    BarrowedPrice = booksEntity.BookPrice

                };

                bool result = await borrowServices.AddBorrowBookAsync(borrowBook);

                if (result)
                {
                    MessageBox.Show("Book successfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadBarrowBookDetails(booksEntity.BookId);
                }
                else
                {
                    MessageBox.Show("Failed to borrow the book. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"An error accured while : {ex.Message}", ex.InnerException ?? ex);
            }
        }
    }
}
