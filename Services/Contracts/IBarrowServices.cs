using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Contracts
{
    public interface IBarrowServices
    {
        // Task<BarrowBookDTO> GetBookDetailsAsync();
        Task<BooksEntity> GetBookByIdAsync(int bookId);

        Task AddBarrowBookAsync(BarrowedItemEntity barrowBook);
    }
}
