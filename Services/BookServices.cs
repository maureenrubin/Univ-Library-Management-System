﻿using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Migrations;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
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
                return await dbContextOptions.Books
                    .Include(b => b.Category)
                    .ToListAsync();
            }
        }

        public async Task<BooksEntity> GetBookByIdAsync(int bookId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books
                        .Where(b => b.BookId == bookId)
                        .Select(b => new BooksEntity
                        {
                            BookId = b.BookId,
                            Title = b.Title,
                            Genre = b.Genre,
                            PublishedDate = b.PublishedDate,
                            BookStock = b.BookStock,
                            BookPrice = b.BookPrice, 
                            CategoryId = b.CategoryId,
                            BooksPicture = b.BooksPicture
                        })
                        .FirstOrDefaultAsync();


                    if (book == null)
                    {
                        throw new Exception("Book not found. ");
                    }
                    return book;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetcing Book Id: {ex.Message}", ex);
            }
            
        }

        public async Task<int> AddBookAsync(BooksEntity book)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    await dbContextOptions.Books.AddAsync(book);
                    return await dbContextOptions.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding Book: {ex.Message}", ex);
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

                    if(existingBook == null) throw new Exception("Book not found");
                    

                    existingBook.Title = bookDTO.Title;
                    existingBook.BooksPicture = bookDTO.BooksPicture;
                    existingBook.BookPrice = bookDTO.BookPrice;
                    existingBook.Genre = bookDTO.Genre;
                    existingBook.BookStock = bookDTO.BookStock;
                    existingBook.CategoryId = bookDTO.CategoryId;

                    

                    await dbContextOptions.SaveChangesAsync();
                }
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Updating Book: {ex.Message}", ex);
            }
        }

     
        public async Task <bool> RemoveBookAsync (int bookId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books.SingleOrDefaultAsync(u => u.BookId == bookId);
                    if (book == null) return false;

                    dbContextOptions.Books.Remove(book);
                    await dbContextOptions.SaveChangesAsync();
                    return true;
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Removing Book: {ex.Message}", ex);
            }
        }
        

        public async Task<int> GetBookAvailableStock(int bookId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books
                        .Include(b => b.BorrowBooks)
                        .FirstOrDefaultAsync(b => b.BookId == bookId);

                    if (book == null) throw new Exception("Book not found.");

                    return book.BookStock - (book.BorrowBooks?.Sum(b => b.Quantity) ?? 0);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching book stock: {ex.Message}", ex);
            }
        }
       
        public async Task<bool> UpdateBookStockAsync(int bookId, int newStock)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books.FirstOrDefaultAsync(b => b.BookId == bookId);

                    if (book == null) throw new Exception("Book not found. ");

                    book.BookStock = newStock;
                    await dbContextOptions.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating book stock: {ex.Message}", ex);
            }
        }
    }
}