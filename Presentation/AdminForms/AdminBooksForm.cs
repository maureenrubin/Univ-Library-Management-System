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

        private System.Windows.Forms.Timer sideBooksTransition;
        private System.Windows.Forms.Timer crudBooksTransition;
        private Animations animations;

        private bool sidebarExpanded = false;
        private byte[] BooksPicture;
        private readonly BooksEntity booksEntity;

        private bool BookUpdateMode = false;
        private int BookIdUpdate;

        public AdminBooksForm(IBookServices bookServices, 
                              BooksEntity booksEntity, Animations animations)
        {


            InitializeComponent();
            this.crudBooksTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.sideBooksTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.animations = animations;
            this.animations.CrudBooksTransition(crudBooksTransition, BooksPanel, sidebarExpanded);
            this.animations.SideBooksTransition(sideBooksTransition, BooksPanel, sidebarExpanded);

            this.booksEntity = booksEntity;
            
            this.bookServices = bookServices;
            LoadBookDetails();

        }

        private void ManageBooksBTN_Click(object sender, EventArgs e)
        {
            sideBooksTransition.Start();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            crudBooksTransition.Start();
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

            BookUC bookDisplay = new BookUC(book, bookServices);
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
                var bookDisplay = new BookUC(book, bookServices);
                bookDisplay.BookUCClicked += BookDetailsUC_Clicked;
                DisplayBooksToUI(book);
            }
        }

        private void BookDetailsUC_Clicked(object? sender, BooksEntity booksEntity)
        {
            MessageBox.Show($"Book clicked: {booksEntity?.Title}", "Debug");
            crudBooksTransition.Start();
            LoadBookToUpdate(booksEntity);
        }

        private void LoadBookToUpdate(BooksEntity booksEntity)
        {
            BookUpdateMode = true;
            BookIdUpdate = booksEntity.BookId;

            BooksTitleTXT.Text = booksEntity.Title;
            BooksGenreTXT.Text = booksEntity.Genre;
            BooksPriceTXT.Text = booksEntity.BookPrice.ToString();
            BooksStocksTXT.Text = booksEntity.BookStock.ToString();
            BooksCategoryTXT.Text = booksEntity.Category;

            if (booksEntity.BooksPicture != null)
            {
                using (MemoryStream ms = new MemoryStream(booksEntity.BooksPicture))
                {
                    BooksPB.Image = Image.FromStream(ms);
                }
            }

        }

        private void DisplayBooksToUI(BooksEntity addedBooks)
        {
            BookUC bookDisplay = new BookUC(addedBooks, bookServices);
            BooksFLP.Controls.Add(bookDisplay);
        }
    }



}
