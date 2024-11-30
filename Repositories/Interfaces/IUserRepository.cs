using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity>GetUserByEmailAsync(string email);
        
        Task<IEnumerable<UserEntity>> GetAllUsersAsync();
       
        Task<IEnumerable<UserEntity>> GetUserByCourseAsync(int courseId);
    }
}
