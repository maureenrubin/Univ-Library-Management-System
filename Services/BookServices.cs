using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Migrations;
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
        private readonly DbContextOptions<LMSDbContext> _dbContextOptions;


        public BookServices(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            this._dbContextOptions = dbContextOptions;
        }

        public async Task<IEnumerable<BooksEntity>> GetAllBooksAsync()
        {
            using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Books.ToListAsync();
            }
        }

        public async Task<int> AddBookAsync(BooksEntity book)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
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


                    await dbContextOptions.Books.AddAsync(book);
                    return await dbContextOptions.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"An Error Occured: {ex.Message}", ex);
            }

        }

        public async Task UpdateBookAsync(BookDTO bookDTO)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var existingBook = await dbContextOptions.Books
                        .SingleOrDefaultAsync(b => b.BookId == bookDTO.BookId);

                    if(existingBook == null)
                    {
                        throw new Exception("Book not found");
                    }

                    existingBook.Title = bookDTO.Title;
                    existingBook.BooksPicture = bookDTO.BooksPicture;
                    existingBook.BookPrice = bookDTO.BookPrice;
                    existingBook.Genre = bookDTO.Genre;
                    existingBook.Title = bookDTO.Title;
                    existingBook.BookStock = bookDTO.BookStock;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Updating Book: {ex.Message}", ex);
            }
        }

        public async Task <bool> RemoveBookAsync(int bookId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books
                        .SingleOrDefaultAsync(a => a.BookId == bookId);

                    if (book != null)
                    {
                        dbContextOptions.Books.Remove(book);

                        await dbContextOptions.SaveChangesAsync();
                        return true;
                    }

                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Removing Book: {ex.Message}", ex);
            }
        }

    }
}