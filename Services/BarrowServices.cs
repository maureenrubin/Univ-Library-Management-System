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

        public async Task<BarrowBookDTO> GetBookDetailsAsync(int bookId, int userId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                   
                    var book = await dbContextOptions.Books.FindAsync(bookId);
                    if (book == null) throw new Exception($"Book with ID {bookId} not found.");

                    var user = await dbContextOptions.Users.FindAsync(userId);
                    if (user == null) throw new Exception($"User with ID {userId} not found.");

                    var admin = await dbContextOptions.Admins.FirstOrDefaultAsync();
                    if (admin == null) throw new Exception("Admin not found.");

                    var barrowBookDTO = new BarrowBookDTO
                    {
                        BookId = book.BookId,
                        UserId = user.UserId,
                        BarrowedDate = DateTime.Now,
                        Title = book.Title,
                        DueDate = DateTime.Now.AddDays(7), 
                        Quantity = 1, 
                        BarrowedPrice = book.BookPrice,
                        BooksPicture = book.BooksPicture
                       
                    };
                    return barrowBookDTO;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Fetching Barrowed Book: {ex.Message}", ex);
            }
        }

        public async Task AddBarrowBookAsync(BarrowBookDTO barrowBookDTO)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var book = await dbContextOptions.Books.FindAsync(barrowBookDTO.BookId);

                    if (book == null) throw new Exception("Book not found");
                    if (book.BookStock < barrowBookDTO.Quantity) throw new Exception("Not enough stock available");

                    book.BookStock -= barrowBookDTO.Quantity;

                    var barrowedBook = new BarrowedItemEntity
                    {
                        BookId = barrowBookDTO.BookId,
                        UserId = barrowBookDTO.UserId,
                        BarrowedDate = barrowBookDTO.BarrowedDate,
                        DueDate = barrowBookDTO.DueDate,
                        Quantity = barrowBookDTO.Quantity,
                        BarrowedPrice = barrowBookDTO.BarrowedPrice
                    };

                    await dbContextOptions.BarrowedItems.AddAsync(barrowedBook);
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
