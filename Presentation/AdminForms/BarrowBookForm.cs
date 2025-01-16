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

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class BarrowBookForm : Form
    {
        private readonly BooksEntity booksEntity;
        private readonly IBookServices bookServices;
        private readonly ICategoryServices categoryServices;


        public BarrowBookForm(IBookServices bookServices,
                              ICategoryServices categoryServices,
                              BooksEntity booksEntity)
        {
            InitializeComponent();
            this.bookServices = bookServices;
            this.categoryServices = categoryServices;
            this.booksEntity = booksEntity;


            LoadBarrowBookDetails();
        }

        private void LoadBarrowBookDetails()
        {
            try
            {
                var allBook = bookServices.GetAllBooksAsync();

                if(allBook == null)
                {
                    MessageBox.Show("No book", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
