using Krypton.Toolkit;
using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Migrations;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class BorrowBookServices : IBorrowBookServices
    {
        private readonly DbContextOptions<LMSDbContext> _dbContextOptions;

        public BorrowBookServices(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            this._dbContextOptions = dbContextOptions;
        }

        public async Task <BorrowBookEntity> GetBorrowBookByIdAsync(int barrowBookId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.BarrowBook
                        .FirstOrDefaultAsync(b => b.BarrowedItemId == barrowBookId);

                    if(book == null)
                    {
                        throw new Exception("Book not found. ");        
                    }

                    return book;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching Book Id:{ex.Message} ", ex);
            }
        }


        public async Task<bool> AddBorrowBookAsync(BorrowBookEntity barrowBook)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books.FirstOrDefaultAsync(b => b.BookId == barrowBook.BookId);
                    
                    if (book == null)throw new Exception("Book not found.");
                    

                    if(book.BookAvailable < 0) throw new Exception($"Not enough stock available. Only {book.BookStock} left.");
                    
                    var user = await dbContextOptions.Users.FirstOrDefaultAsync(u => u.UserId == barrowBook.UserId);
                    if (user == null)  throw new Exception("User not found.");
                   
                    await dbContextOptions.BarrowBook.AddAsync(barrowBook);
                    await dbContextOptions.SaveChangesAsync();

                    book.BookStock -= barrowBook.Quantity;

                    await dbContextOptions.SaveChangesAsync();
                    return true;               
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding Barrowed Book: {ex.Message}", ex);
            }
        }
    }
}
