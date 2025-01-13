using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories.Interfaces
{
    public interface IBookServices
    {
        Task<IEnumerable<BooksEntity>> GetAllBooksAsync();

        Task <BooksEntity> GetBookByIdAsync(int bookId);

        Task<int> AddBookAsync(BooksEntity book);

        Task UpdateBookAsync(BookDTO bookDTO);

        Task<bool> RemoveBookAsync(int bookId);

    }
}
