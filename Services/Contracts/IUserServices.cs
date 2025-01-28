using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories.Interfaces
{
    public interface IUserServices
    {
        Task<UserEntity>GetUserByEmailAsync(string email);
        
        Task<IEnumerable<UserEntity>> GetAllUsersAsync();
        
        Task<UserEntity> GetUserByIdAsync(int userId);

        Task UpdateUserAsync(UserDTO userDTO);

        Task <bool> RemoveUserAsync(int userId);

        Task<List<RoleEntity>> GetRolesByUserIdAsync(int userId);
    }
}
