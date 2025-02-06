using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;
using System;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.UserForms
{
    public partial class UserBookForm : Form
    {
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices;
        private readonly IBorrowBookServices borrowServices;
        private readonly IUserServices userServices;

        public UserBookForm(IBookServices bookServices,
                            ICategoryServices categoryServices,
                            IUserServices userServices,
                            IBorrowBookServices borrowServices)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.userServices = userServices;
            this.categoryServices = categoryServices;
            this.borrowServices = borrowServices;

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
            BookUC bookDisplay = new BookUC(booksEntity, bookServices, categoryServices, borrowServices, userServices, this);
            UserBooksFLP.Controls.Add(bookDisplay);
        }

        public void UpdateBookStock(int bookId, int newStock)
        {
            foreach (Control control in UserBooksFLP.Controls)
            {
                if (control is BookUC bookUc && bookUc.bookEntity.BookId == bookId)
                {
                    bookUc.UpdateBookStock(bookId, newStock);
                    break;
                }
            }
        }
    }
}
