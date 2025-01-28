using LibraryManagementSystem.Data_Connectivity.Context;
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
    public class CategoryServices : ICategoryServices
    {
        private readonly DbContextOptions<LMSDbContext> _dbContextOptions;

        public CategoryServices(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            this._dbContextOptions = dbContextOptions;
        }

        public async Task <IEnumerable<BookCategoryEntity>> GetAllBookCategoriesAsync()
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var categoriess = await dbContextOptions.BookCategory
                        .Where(c => c.CategoryName != null && c.BCategoryId != null)
                        .ToListAsync();

                    return categoriess;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving all Categories. {ex.Message}", ex);
            }
           
        }

        public async Task <BookCategoryEntity> GetCategoryByIdAsync(int categoryId)
        {
            using( var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.BookCategory
                    .FirstOrDefaultAsync(c => c.BCategoryId == categoryId);
            }
        }
    }
}
