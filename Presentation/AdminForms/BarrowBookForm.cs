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

        private readonly BooksEntity booksEntity;
        private int currentUser;

        public BarrowBookForm(IBookServices bookServices,
                              ICategoryServices categoryServices,
                              IBarrowServices barrowServices,
                              BooksEntity booksEntity)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.barrowServices = barrowServices;
            this.booksEntity = booksEntity;
        }


        public async Task LoadBarrowBookDetails(int bookId)
        {
            try
            {

                var bookDetails = await barrowServices.GetBookByIdAsync(bookId);

                if (bookDetails is not null)
                {
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
                }

                BarrowDateLBL.Text = DateTime.UtcNow.ToShortDateString();
                DueDateLBL.Text = DateTime.Now.AddDays(7).ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load barrowed books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                var addBarrowBook = new BarrowBookEntity
                {
                    BookId = booksEntity.BookId,
                    UserId = currentUser,
                    Quantity = 1,
                    BarrowedDate = DateTime.UtcNow,
                    DueDate = DateTime.UtcNow.AddDays(7),
                    BarrowedPrice = booksEntity.BookPrice
                };
                await barrowServices.AddBarrowBookAsync(addBarrowBook);
                MessageBox.Show("Book successfully barrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Barrow Books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
