using Krypton.Toolkit;
using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Migrations;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class BorrowBookServices : IBorrowBookServices
    {
        private readonly LMSDbContext appDbContext;

        public BorrowBookServices(LMSDbContext dbContext)
        {
            this.appDbContext = dbContext;
        }

        public async Task <BorrowBookEntity> GetBorrowBookByIdAsync(int borrowBookId)
        {
            try
            {
                var book = await appDbContext.BorrowBook.FirstOrDefaultAsync(b => b.BarrowedItemId == borrowBookId);

                    if(book == null)
                    {
                        throw new Exception("Book not found. ");        
                    }

                    return book;
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching Book Id:{ex.Message} ", ex);
            }
        }


        public async Task<bool> AddBorrowBookAsync(BorrowBookEntity borrowBook)
        {
            try
            {
                var user = await appDbContext.Users.FindAsync(borrowBook.UserId);
                if (user == null) throw new Exception("User not found.");

                var book = await appDbContext.Books.FindAsync(borrowBook.BookId);
                if (book == null) throw new Exception("Book not found.");

                
                if (book.BookStock < borrowBook.Quantity)
                    throw new Exception($"Not enough stock available. Only {book.BookStock} left.");

                book.BookStock -= borrowBook.Quantity;

                await appDbContext.BorrowBook.AddAsync(borrowBook);
                await appDbContext.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding Borrowed Book: {ex.Message}", ex.InnerException ?? ex);
            }
        }
    }
}
