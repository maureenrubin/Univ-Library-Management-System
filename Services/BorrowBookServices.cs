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

        public async Task <BorrowTransaction> GetBorrowBookByIdAsync(int borrowBookId)
        {
            try
            {
                var book = await appDbContext.BorrowBooks.FirstOrDefaultAsync(b => b.BorrowedItemId == borrowBookId);

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


        public async Task<bool> AddBorrowBookAsync(BorrowTransaction borrowBook)
        {
            try
            {
              

                await appDbContext.BorrowBooks.AddAsync(borrowBook);
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
