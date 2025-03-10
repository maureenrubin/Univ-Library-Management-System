﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Presentation.UserForms;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class AdminBooksForm : Form
    {
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices;
        private readonly IBorrowBookServices borrowServices;
        private readonly IUserServices userServices;

        private System.Windows.Forms.Timer sidePanelTransition;
        private System.Windows.Forms.Timer crudBooksTransition;
        private Animations animations;

        private bool sidebarExpanded = false;
        private byte[] BooksPicture;
        private readonly BooksEntity booksEntity;
        private readonly UserBookForm bookForm;

        private bool BookUpdateMode = false;
        private int BookIdUpdate;
        private byte[] booksPicture;


        public AdminBooksForm(IBookServices bookServices,
                              BooksEntity booksEntity, Animations animations,
                              UserBookForm bookForm,
                              ICategoryServices categoryServices,
                              IUserServices userServices,
                              IBorrowBookServices borrowServices)
        {

            InitializeComponent();
            this.booksEntity = booksEntity;
            this.bookForm = bookForm;

            this.userServices = userServices;
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.borrowServices = borrowServices;

            this.crudBooksTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.sidePanelTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.animations = animations;
            this.animations.CrudBooksTransition(crudBooksTransition, BooksPanel, sidebarExpanded);
            this.animations.SideBooksTransition(sidePanelTransition, BooksPanel, sidebarExpanded);

            LoadBooksDetails();
            LoadBookCategories();

        }

        private void ManageBooksBTN_Click(object sender, EventArgs e)
        {
            crudBooksTransition.Start();
            sidePanelTransition.Start();
        }


        private async Task LoadBooksDetails()
        {
            try
            {
                var bookList = await bookServices.GetAllBooksAsync();
                FormsControlHelper.ClearControls(this);

                foreach (var book in bookList)
                {
                    var bookDisplay = new BookUC(book, bookServices, categoryServices, borrowServices, userServices, bookForm);
                    bookDisplay.BookUCClicked += BookDetailsUC_Clicked;
                    BooksFLP.Controls.Add(bookDisplay);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void LoadBookCategories()
        {
            try
            {
                var bookCategories = await categoryServices.GetAllBookCategoriesAsync();

                if (bookCategories == null || !bookCategories.Any())
                {
                    MessageBox.Show("No categories available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var validCategories = bookCategories
                    .Where(c => !string.IsNullOrEmpty(c.CategoryName) && c.BCategoryId != null)
                    .ToList();

                if (!validCategories.Any())
                {
                    MessageBox.Show("No valid categories available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BookCategoryCB.DataSource = validCategories;
                BookCategoryCB.DisplayMember = "CategoryName"; // Display text
                BookCategoryCB.ValueMember = "BCategoryId";   // Underlying value
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Book Categories: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void AddBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int bookId = 0;
                string title = BooksTitleTXT.Text;
                string genre = BooksGenreTXT.Text;
                int selectedCategoryId;
                DateTime publishedDate = PublisedDateTime.Value;



                if (BooksPB.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        BooksPB.Image.Save(ms, BooksPB.Image.RawFormat);
                        booksPicture = ms.ToArray();
                    }
                }

                if (BookCategoryCB.SelectedValue == null || !int.TryParse(BookCategoryCB.SelectedValue.ToString(), out selectedCategoryId))
                {
                    MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(BooksStocksTXT.Text, out int bookStock) || bookStock < 0)
                {
                    MessageBox.Show("Invalid Book Stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(BooksPriceTXT.Text, out int bookPrice) || bookPrice < 0)
                {
                    MessageBox.Show("Invalid Book Price. Please enter a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(genre))
                {
                    MessageBox.Show("All fields are required. Please fill in Title, and Genre.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (publishedDate > DateTime.Now)
                {
                    MessageBox.Show("Published Date cannot be in the future.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newBook = new BooksEntity
                {
                    BookId = bookId,
                    Title = title,
                    Genre = genre,
                    PublishedDate = publishedDate,
                    BookStock = bookStock,
                    BooksPicture = booksPicture,
                    BookPrice = bookPrice,
                    CategoryId = selectedCategoryId
                    
                };

                await bookServices.AddBookAsync(newBook);
                MessageBox.Show("Book Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FormsControlHelper.ClearControls(this);
                LoadBooksDetails();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Adding new Books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

     

        private async void UpdateBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(BooksTitleTXT.Text) ||
                    string.IsNullOrWhiteSpace(BooksGenreTXT.Text) ||
                    !int.TryParse(BooksPriceTXT.Text, out int bookPrice) || bookPrice <= 0 ||
                    !int.TryParse(BooksStocksTXT.Text, out int bookStock) || bookStock < 0 ||
                    PublisedDateTime.Value > DateTime.Now)
                {
                    MessageBox.Show("Please ensure all fields are filled correctly:",
                                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BookCategoryCB.SelectedValue == null || !int.TryParse(BookCategoryCB.SelectedValue.ToString(), out int selectedCategoryId))
                {
                    MessageBox.Show("Please select a valid category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (BooksPB.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        BooksPB.Image.Save(ms, BooksPB.Image.RawFormat);
                        booksPicture = ms.ToArray();
                    }
                }



                var updateBook = new BookDTO
                {
                    BookId = BookIdUpdate,
                    Title = BooksTitleTXT.Text.Trim(),
                    Genre = BooksGenreTXT.Text.Trim(),
                    CategoryId = selectedCategoryId,
                    PublishedDate = PublisedDateTime.Value,
                    BookStock = bookStock,
                    BooksPicture = booksPicture,
                    BookPrice = bookPrice,

                };


                await bookServices.UpdateBookAsync(updateBook);
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormsControlHelper.ClearControls(BooksPanel);
                LoadBooksDetails();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Updating Books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // click book to update
        private void BookDetailsUC_Clicked(object? sender, BooksEntity booksEntity)
        {
            crudBooksTransition.Start();
            sidePanelTransition.Start();
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

            if (booksEntity.CategoryId != 0)
            {
                BookCategoryCB.SelectedValue = booksEntity.CategoryId;
            }

            if (booksEntity.BooksPicture != null)
            {
                using (MemoryStream ms = new MemoryStream(booksEntity.BooksPicture))
                {
                    BooksPB.Image = Image.FromStream(ms);
                }
            }

        }

        private void DisplayBooksToUI(BooksEntity books)
        {
            BooksFLP.Controls.Clear();
            BookUC bookDisplay = new BookUC(books, bookServices, categoryServices, borrowServices, userServices, bookForm);
            BooksFLP.Controls.Add(bookDisplay);
        }

        private async void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            if (!BookUpdateMode || BookIdUpdate == 0)
            {
                MessageBox.Show("Please select a book to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmRemove = MessageBox.Show("Are you sure you want to remove this book?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmRemove == DialogResult.Yes)
            {
                try
                {
                    var removeBook = await bookServices.RemoveBookAsync(BookIdUpdate);

                    if (removeBook)
                    {
                        MessageBox.Show("Book removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsControlHelper.ClearControls(BooksPanel);
                        LoadBooksDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Deleting Books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void SearchBookTXT_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchBook = SearchBookTXT.Text.Trim();

                if (string.IsNullOrEmpty(searchBook))
                {
                   await LoadBooksDetails();
                    return;
                }

                var allBooks = await bookServices.GetAllBooksAsync();

                var  filteredBooks = allBooks
                    .Where(b => (!string.IsNullOrEmpty(b.Title) && b.Title.Contains(searchBook, StringComparison.OrdinalIgnoreCase)) 
                    || (!string.IsNullOrEmpty(b.Category?.CategoryName) && b.Category.CategoryName.Contains(searchBook, StringComparison.OrdinalIgnoreCase)))
                     .ToList();
             
                BooksFLP.Controls.Clear();
                foreach (var book in filteredBooks)
                {
                    var bookDisplay = new BookUC(book, bookServices, categoryServices, borrowServices, userServices, bookForm);
                    bookDisplay.BookUCClicked += BookDetailsUC_Clicked;
                    BooksFLP.Controls.Add(bookDisplay);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error during searching books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }



}
