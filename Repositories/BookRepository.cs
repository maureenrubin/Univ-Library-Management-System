using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Data_Connectivity.Interfaces;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository : IBooksRepository
    {
        private readonly DbContextOptions<LMSDbContext> _applicationDbContext;


        public BookRepository(DbContextOptions<LMSDbContext> dbContextOption)
        {
            _applicationDbContext = dbContextOption;
        }

        public async Task<int> AddBookAsync(BooksEntity book)
        {
            using (var dbContextOption = new LMSDbContext(_applicationDbContext))
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

                await dbContextOption.Books.AddAsync(book);
                await dbContextOption.SaveChangesAsync();

                return book.BookId;
            }
        }

        public async Task<IEnumerable<BooksEntity>> GetAllBooksAsync()
        {
            using (var dbContextOption = new LMSDbContext(_applicationDbContext))
            {
                return await dbContextOption.Books.ToListAsync();
            }
         }
    }
}