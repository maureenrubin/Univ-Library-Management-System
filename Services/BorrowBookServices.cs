﻿using Krypton.Toolkit;
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
        private readonly LMSDbContext appDBContext;

        public BorrowBookServices(LMSDbContext dbContext)
        {
            this.appDBContext = dbContext;
        }

        public async Task <BorrowTransaction> GetBorrowBookByIdAsync(int borrowBookId)
        {
            try
            {
                var book = await appDBContext.BorrowBooks.FirstOrDefaultAsync(b => b.BorrowedBookId == borrowBookId);

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


        public async Task<bool> AddBorrowBookAsync(int userId, int bookId)
        {
            try
            {
                var borrowBook = await appDBContext.BorrowBooks
                     .FirstOrDefaultAsync(b => b.UserId == userId && b.BookId == bookId);

                if (borrowBook != null)
                {
                    MessageBox.Show("Book already borrowed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }

                var addBorrow = new BorrowTransaction
                {
                    UserId = userId,
                    BookId = bookId,
                    BorrowedDate = DateTime.UtcNow,
                    DueDate =   DateTime.UtcNow.AddDays(7),
                    Quantity = 1
                };

                await appDBContext.BorrowBooks.AddAsync(addBorrow);
                return await appDBContext.SaveChangesAsync() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding Borrowed Book: {ex.Message}", ex.InnerException ?? ex);
               
            }
        }
    }
}
