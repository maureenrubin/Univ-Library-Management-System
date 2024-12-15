using LibraryManagementSystem.Domain.DTO;
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

        Task UpdateAdminAsync(AdminDTO adminDTO);

        Task<AdminEntity> GetAdminByIdAsync(int adminId);

        Task <bool>RemoveAdminAsync(int adminId);
    }
}
