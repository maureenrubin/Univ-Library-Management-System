using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
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

        public UserBookForm(IBookServices bookServices,
                            BooksEntity booksEntity)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.booksEntity = booksEntity;

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
            AdminBooksUserControl bookDisplay = new AdminBooksUserControl(booksEntity);
            UserBooksFLP.Controls.Add(bookDisplay);
        }
    }
}
