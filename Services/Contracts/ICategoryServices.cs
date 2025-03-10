﻿using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Contracts
{
    public interface ICategoryServices
    {
        Task<IEnumerable<BookCategoryEntity>> GetAllBookCategoriesAsync();

        Task<BookCategoryEntity> GetCategoryByIdAsync(int categoryId);


    }
}
