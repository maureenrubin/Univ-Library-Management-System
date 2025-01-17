using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.UserForms
{
    public partial class UserBookForm : Form
    {
        private readonly IBookServices bookServices;
        private readonly BooksEntity booksEntity;
        private readonly ICategoryServices categoryServices;
        private readonly IBarrowServices barrowServices;

        public UserBookForm(IBookServices bookServices,
                            BooksEntity booksEntity,
                            ICategoryServices  categoryServices,
                            IBarrowServices barrowServices)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.booksEntity = booksEntity;
            this.categoryServices = categoryServices;
            this.barrowServices = barrowServices;

            LoadBookDetails();
        }


        private async void LoadBookDetails()
        {
            var bookList = await bookServices.GetAllBooksAsync();
            UserBooksFLP.Controls.Clear();

            foreach (var book in bookList)
            {
                DisplayBooksToUI(book);
            }
        }

        private void DisplayBooksToUI(BooksEntity booksEntity)
        {
            BookUC bookDisplay = new BookUC(booksEntity, bookServices, categoryServices, barrowServices);
            UserBooksFLP.Controls.Add(bookDisplay);
        }
    }
}
