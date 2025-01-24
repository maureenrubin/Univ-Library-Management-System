using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Contracts
{
    public interface IBorrowBookServices
    {
        Task<BorrowBookEntity> GetBorrowBookByIdAsync(int barrowBookId);

        Task<bool> AddBorrowBookAsync(BorrowBookEntity barrowBook);
    }
}
