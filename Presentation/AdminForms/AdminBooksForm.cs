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
using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class AdminBooksForm : Form
    {
        private readonly IBookServices bookServices;

        private System.Windows.Forms.Timer _sideBooksTransition;
        private System.Windows.Forms.Timer _crudBooksTransition;
        private Animations _animations;
        private bool _sidebarExpanded;
        private byte[] BooksPicture;
        private readonly BooksEntity booksEntity;


        public AdminBooksForm(IBookServices bookServices, BooksEntity booksEntity)
        {


            InitializeComponent();
            _crudBooksTransition = new System.Windows.Forms.Timer { Interval = 10 };
            _sideBooksTransition = new System.Windows.Forms.Timer { Interval = 10 };
            _animations = new Animations();
            _animations.CrudBooksTransition(_crudBooksTransition, BooksPanel, _sidebarExpanded);
            _animations.SideBooksTransition(_sideBooksTransition, BooksPanel, _sidebarExpanded);

            this.booksEntity = booksEntity;
            
            this.bookServices = bookServices;
            LoadBookDetails();

        }

        private void ManageBooksBTN_Click(object sender, EventArgs e)
        {
            _sideBooksTransition.Start();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            _crudBooksTransition.Start();
        }

        private async void SaveBooksBtn_Click(object sender, EventArgs e)
        {
            int bookId = 0;
            string title = BooksTitleTXT.Text;
            string genre = BooksGenreTXT.Text;

            string category = BooksCategoryTXT.Text;
            DateTime publishedDate = PublisedDateTime.Value;
            byte[] booksPicture = null;


            if (BooksPB.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    BooksPB.Image.Save(ms, BooksPB.Image.RawFormat);
                    booksPicture = ms.ToArray();
                }

            }

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(category) || !int.TryParse(BooksPriceTXT.Text, out int bookPrice) ||
                !int.TryParse(BooksStocksTXT.Text, out int bookStock))

            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (publishedDate > DateTime.Now)
            {
                MessageBox.Show("Published Date cannot be in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var book = new BooksEntity
            {
                BookId = bookId,
                Title = title,
                Genre = genre,
                PublishedDate = publishedDate,
                BookStock = bookStock,
                BooksPicture = booksPicture,
                BookPrice = bookPrice,

            };

            await bookServices.AddBookAsync(book);
            MessageBox.Show("Book Added Successfully!");

            FormsControlHelper.ClearControls(this);

            AdminBooksUserControl bookDisplay = new AdminBooksUserControl(book);
            BooksFLP.Controls.Add(bookDisplay);

        }



        private void BrowseImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images Files | *.jp;*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    BooksPicture = File.ReadAllBytes(openFileDialog.FileName);
                    BooksPB.Image = Image.FromStream(new MemoryStream(BooksPicture));
                }
            }
        }

        private async void LoadBookDetails()
        {
            var bookList = await bookServices.GetAllBooksAsync();
            BooksFLP.Controls.Clear();

            foreach (var book in bookList)
            {
                DisplayBooksToUI(book);
            }
        }

        private void DisplayBooksToUI(BooksEntity addedBooks)
        {
            AdminBooksUserControl bookDisplay = new AdminBooksUserControl(addedBooks);


            BooksFLP.Controls.Add(bookDisplay);
        }
    }



}
