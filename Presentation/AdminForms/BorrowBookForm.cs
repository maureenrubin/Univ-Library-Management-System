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

                var bookDetails = await bookServices.GetBookByIdAsync(bookId);

                if (bookDetails == null)
                {
                    MessageBox.Show("Book details could not be retrieved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int bookId = booksEntity.BookId;

                var availableStock = await bookServices.GetBookAvailableStock(booksEntity.BookId);

                if(availableStock > 0)
                {
                    int newStock = availableStock - 1;

                    var addBorrowBook = new BorrowBookEntity
                    {
                        BookId = booksEntity.BookId,
                        UserId = userEntity.UserId,
                        Quantity = 1,
                        BarrowedDate = DateTime.UtcNow,
                        DueDate = DateTime.UtcNow.AddDays(7),
                        BarrowedPrice = booksEntity.BookPrice 
                    };

                    await borrowServices.AddBorrowBookAsync(addBorrowBook);
                    await bookServices.UpdateBookStockAsync(bookId, newStock);

                    MessageBox.Show("Book successfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                
                }
                else
                {
                    MessageBox.Show("Sorry, the book is out of stock", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to barrow book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
