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
        private readonly LMSDbContext dbContext;

        public CategoryServices(LMSDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task <IEnumerable<BookCategoryEntity>> GetAllBookCategoriesAsync()
        {
            return await dbContext.Categories.ToListAsync();
        }
    }
}
