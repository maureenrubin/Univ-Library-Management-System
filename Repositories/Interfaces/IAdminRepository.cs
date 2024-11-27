using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        Task<AdminEntity> GetAdminByEmailAsync(string email);

    }
}
