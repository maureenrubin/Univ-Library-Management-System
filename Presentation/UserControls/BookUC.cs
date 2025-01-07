using LibraryManagementSystem.Domain.Entities;
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

namespace LibraryManagementSystem.Presentation
{
    public partial class BookUC : UserControl
    {
        private readonly BooksEntity bookEntity;
        private readonly IBookServices bookServices;

        public event EventHandler<BooksEntity> BookUCClicked;
        public bool selectedBook { get; private set; }

        public BookUC(BooksEntity bookEntity,
                      IBookServices bookServices)
        {
            InitializeComponent();
            this.bookEntity = bookEntity;
            this.bookServices = bookServices;
            this.Click += BookDetailsUC_Click;

            LoadBooksDetails();
        }

        private void BookDetailsUC_Click(object? sender, EventArgs e)
        {
            selectedBook = true;
            BookUCClicked?.Invoke(this, bookEntity);
        }

        private void LoadBooksDetails()
        {
            BooksTitleLbl.Text = bookEntity.Title;
            BooksStockLbl.Text = bookEntity.BookStock.ToString();
            BooksGenreLbl.Text = bookEntity.Genre;
            BooksPriceLbl.Text = bookEntity.BookPrice.ToString();
            BooksIdLbl.Text = bookEntity.BookId.ToString();
            PublishedDate.Text = bookEntity.PublishedDate.ToShortDateString();


            if (bookEntity.BooksPicture != null)
            {
                using (MemoryStream ms = new MemoryStream(bookEntity.BooksPicture))
                {
                    BooksPB.Image = Image.FromStream(ms);
                }
            }

        }

    }
}
