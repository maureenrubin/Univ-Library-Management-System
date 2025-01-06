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
        Task<int> AddBookAsync(BooksEntity books);

        Task<IEnumerable<BooksEntity>> GetAllBooksAsync();

        Task UpdateBookAsync(BookDTO bookDTO);

    }
}
