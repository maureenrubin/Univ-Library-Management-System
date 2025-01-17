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
        private readonly BooksEntity booksEntity;
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices;
        private readonly IBarrowServices barrowServices;


        public BarrowBookForm(IBookServices bookServices,
                              ICategoryServices categoryServices,
                              IBarrowServices barrowServices,
                              BooksEntity booksEntity)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.booksEntity = booksEntity;
            this.barrowServices = barrowServices;

            LoadBarrowBookDetails();
        }

        private async void LoadBarrowBookDetails()
        {
            try
            {
                int bookId = booksEntity.BookId;
                int userId = 2017;

                var bookDetails = await barrowServices.GetBookDetailsAsync(booksEntity.BookId, userId);

                BookIdLBL.Text = bookDetails.BookId.ToString();
                BookTitle.Text = bookDetails.Title;
                BarrowDateLBL.Text = bookDetails.BarrowedDate.ToShortDateString();
                BarrowedPriceLBL.Text = bookDetails.BookPrice.ToString("C");
                DueDateLBL.Text = bookDetails.DueDate.ToShortDateString();

                if(bookDetails.BooksPicture != null)
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
            catch (Exception ex)
            {
                throw new Exception($"Failed to load barrowed book details. {ex.Message}", ex);
            }

        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
