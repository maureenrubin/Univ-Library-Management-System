using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Connectivity.Interfaces
{
    public interface IBooksRepository
    {
        Task<int> AddBookAsync(BooksEntity books);
        Task<IEnumerable<BooksEntity>> GetAllBooksAsync();
  
    }
}
