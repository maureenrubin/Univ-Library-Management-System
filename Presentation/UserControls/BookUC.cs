using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Presentation.UserForms;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation
{
    public partial class BookUC : UserControl
    {
        public BooksEntity bookEntity;
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices;
        private readonly IBorrowBookServices borrowServices;
        private readonly IUserServices userServices;
        private readonly UserBookForm bookForm;

        public event EventHandler<BooksEntity> BookUCClicked;
        public bool selectedBook { get; private set; }

        public static int LoggedInUserId { get; set; } = 0;

        public BookUC(BooksEntity bookEntity, IBookServices bookServices, ICategoryServices categoryServices,
                      IBorrowBookServices borrowServices, IUserServices userServices, UserBookForm bookForm)
        {
            InitializeComponent();
            this.bookEntity = bookEntity ?? throw new ArgumentNullException(nameof(bookEntity));
            this.bookForm = bookForm ?? throw new ArgumentNullException(nameof(bookForm));
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.borrowServices = borrowServices;
            this.userServices = userServices;

            this.Click += BookDetailsUC_Click;
            foreach (Control control in Controls)
            {
                control.Click += BookDetailsUC_Click;
            }
            LoadBooksDetails();
        }

        private void BookDetailsUC_Click(object sender, EventArgs e)
        {
            selectedBook = !selectedBook;
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
                MessageBox.Show($"Failed to load book details. {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BorrowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bookEntity == null || bookEntity.BookId <= 0)
                {
                    MessageBox.Show("Invalid book data or no book selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var borrowForm = new BorrowBookForm(bookServices, categoryServices, borrowServices, userServices, bookEntity, bookForm);
                await borrowForm.LoadBorrowBookDetails(bookEntity.BookId);
                borrowForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateBookStock(int bookId, int newStock)
        {
            if (bookEntity.BookId == bookId)
            {
                bookEntity.BookStock = newStock;
                BooksStockLbl.Text = newStock.ToString();
            }
        }
    }
}
