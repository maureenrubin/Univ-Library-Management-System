using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Data_Connectivity.Interfaces;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class BookRepository : IBooksRepository
    {
        private readonly LMSDbContext applicationDbContext;


        public BookRepository(LMSDbContext applicationDBContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        public async Task AddBookAsync(BookDto bookDto)
        {
            var createBook = new BooksEntity
            {
                Title = bookDto.Title,
                Genre = bookDto.Genre,
                PublishedDate = bookDto.PublishedDate,
                BookStock = bookDto.BookStock, 
                BooksPicture = bookDto.BooksPicture,
                BookPrice = bookDto.BooksPrice,
                Category = bookDto.Category,

            };

            applicationDbContext.Books.Add(createBook);
            await applicationDbContext.SaveChangesAsync();
            
        }
    }
}
