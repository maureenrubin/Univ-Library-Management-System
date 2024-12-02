using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class BookServices : IBookServices
    {
        private readonly LMSDbContext applicationDbContext;


        public BookServices(LMSDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task<int> AddBookAsync(BooksEntity book)
        {
            try
            {

                var addBook = new BooksEntity
                {
                    Title = book.Title,
                    Genre = book.Genre,
                    PublishedDate = book.PublishedDate,
                    BookStock = book.BookStock,
                    BookPrice = book.BookPrice,
                    BooksPicture = book.BooksPicture,
                    Category = book.Category,


                };


                await applicationDbContext.Books.AddAsync(book);
                return await applicationDbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"An Error Occured: {ex.Message}", ex);
            }

        }

        public async Task<IEnumerable<BooksEntity>> GetAllBooksAsync()
        {

            return await applicationDbContext.Books.ToListAsync();

        }
    }
}