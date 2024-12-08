using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories.Interfaces
{
    public interface IAdminServices
    {
        Task<AdminEntity> GetAdminByEmailAsync(string email);
        
        Task<IEnumerable<AdminEntity>> GetAllAdminAsync();
       
        Task UpdateAdminAsync(AdminEntity updatedAdmin);

        Task<AdminEntity> GetAdminByIdAsync(int adminId);
    }
}
