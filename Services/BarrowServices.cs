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

        public async Task AddBarrowBookAsync(BarrowBookEntity barrowBook)
        {
            try
            {
                if (barrowBook == null)
                {
                    MessageBox.Show("Invalid Barrow Book. ");
                    return;
                }
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var userExist = await dbContextOptions.Users
                        .FirstOrDefaultAsync(u => u.UserId == barrowBook.UserId);
                    
                    if (userExist == null)
                    {
                        MessageBox.Show("User not found");
                        return;
                    }

                    var book = await dbContextOptions.Books
                        .Include(b => b.Category)
                        .FirstOrDefaultAsync(b => b.BookId == barrowBook.BookId);
                    
                    if(book == null)
                    {
                        MessageBox.Show("Book not found");
                        return;
                    }

                    if (book.BookStock < barrowBook.Quantity)
                    {
                        MessageBox.Show("Not enough stock available");
                        return;
                    }

                    book.BookStock -= barrowBook.Quantity;

                    var addBarrow = new BarrowBookDTO
                    {
                        BookId = barrowBook.BookId,
                        UserId = barrowBook.UserId,
                        BarrowedDate = barrowBook.BarrowedDate,
                        DueDate = barrowBook.DueDate,
                        Quantity = barrowBook.Quantity,
                        BarrowedPrice = barrowBook.BarrowedPrice
                    };

                    await dbContextOptions.BarrowBook.AddAsync(barrowBook);
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
