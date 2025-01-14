using LibraryManagementSystem.Domain.Entities;
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

namespace LibraryManagementSystem.Presentation
{
    public partial class BookUC : UserControl
    {
        public BooksEntity bookEntity;
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices; 


        public event EventHandler<BooksEntity> BookUCClicked;
        public bool selectedBook { get; private set; }

        public BookUC(BooksEntity bookEntity,
                      IBookServices bookServices,
                      ICategoryServices categoryServices)
        {
            InitializeComponent();
            this.bookEntity = bookEntity;
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.Click += BookDetailsUC_Click;
            
            foreach (Control control in Controls)
            {
                control.Click += BookDetailsUC_Click;
            }
            LoadBooksDetails();
        }

        private void BookDetailsUC_Click(object? sender, EventArgs e)
        {
            selectedBook = !selectedBook;
            this.BackColor = selectedBook ? Color.DimGray : Color.White;
            BookUCClicked?.Invoke(this, bookEntity);
        }

        private async void LoadBooksDetails()
        {
            try
            {
                
                if (bookEntity == null) throw new Exception("Book entity is null. Cannot load book details.");

                string categoryName = "No Category";
               
                if (bookEntity.CategoryId > 0)
                {
                    var category = await categoryServices.GetCategoryByIdAsync(bookEntity.CategoryId);
                    categoryName = category?.CategoryName ?? "No Category";
                }

                BooksTitleLbl.Text = bookEntity.Title;
                BooksStockLbl.Text = bookEntity.BookStock.ToString();
                BooksGenreLbl.Text = bookEntity.Genre;
                BooksPriceLbl.Text = bookEntity.BookPrice.ToString();
                BooksIdLbl.Text = bookEntity.BookId.ToString();
                BookCategoryLbl.Text = categoryName;
                PublishedDate.Text = bookEntity.PublishedDate.ToShortDateString();


                if (bookEntity.BooksPicture != null)
                {
                    using (MemoryStream ms = new MemoryStream(bookEntity.BooksPicture))
                    {
                        BooksPB.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    BooksPB.Image = null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load book details. {ex.Message}", ex);
            }

            

        }

    }
}
