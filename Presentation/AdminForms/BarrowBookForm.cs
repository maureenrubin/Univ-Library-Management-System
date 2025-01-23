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
    public partial class BarrowBookForm : Form
    {
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices;
        private readonly IBarrowServices barrowServices;
        private readonly IUserServices userServices;

        private readonly UserEntity userEntity;
        private readonly BooksEntity booksEntity;
       

        public BarrowBookForm(IBookServices bookServices,
                              ICategoryServices categoryServices,
                              IBarrowServices barrowServices,
                              IUserServices userServices,
                              BooksEntity booksEntity,
                              UserEntity userEntity)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.barrowServices = barrowServices;
            this.userServices = userServices;

            this.booksEntity = booksEntity;
            this.userEntity = userEntity;
        }


        public async Task LoadBarrowBookDetails(int bookId)
        {
            try
            {

                var bookDetails = await barrowServices.GetBookByIdAsync(bookId);

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
                if(booksEntity == null)
                {

                    MessageBox.Show("No book selected to borrow!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(booksEntity.BookStock < 1)
                {
                    MessageBox.Show("This book is out of stock", "Out of stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int userId = userEntity.UserId;
                int bookId = booksEntity.BookId;
                int quantity = 1;
                
                await barrowServices.AddBarrowBookAsync(userId, bookId, quantity);
                MessageBox.Show("Book successfully barrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                booksEntity.BookStock -= 1;
                StockLBL.Text = $"{booksEntity.BookStock}";
                BarrowBookBTN.Enabled = booksEntity.BookStock > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to barrow book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
