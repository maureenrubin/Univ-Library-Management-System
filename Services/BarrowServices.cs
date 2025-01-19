using Krypton.Toolkit;
using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class BarrowServices : IBarrowServices
    {
        private readonly DbContextOptions<LMSDbContext> _dbContextOptions;

        public BarrowServices(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            this._dbContextOptions = dbContextOptions;
        }

        public async Task <BooksEntity> GetBookByIdAsync(int bookId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    return await dbContextOptions.Books.FirstOrDefaultAsync(b => b.BookId == bookId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Fetching Book Id:{ex.Message} ", ex);
            }
        }

        public async Task AddBarrowBookAsync(BarrowedItemEntity barrowBook)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books.FirstOrDefaultAsync();

                    if (book == null) throw new Exception("Book not found");
                    if (book.BookStock < barrowBook.Quantity) throw new Exception("Not enough stock available");

                    book.BookStock -= barrowBook.Quantity;

                    var barrowedBook = new BarrowedItemEntity
                    {
                        BookId = barrowBook.BookId,
                        UserId = barrowBook.UserId,
                        BarrowedDate = barrowBook.BarrowedDate,
                        DueDate = barrowBook.DueDate,
                        Quantity = barrowBook.Quantity,
                        BarrowedPrice = barrowBook.BarrowedPrice
                    };

                    await dbContextOptions.BarrowBook.AddAsync(barrowedBook);
                    await dbContextOptions.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding Barrowed Book: {ex.Message}", ex);
            }
        }
    }
}
