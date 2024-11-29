using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.UserControls;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContextOptions<LMSDbContext> _applicationDbContext;

        public UserRepository(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            _applicationDbContext = dbContextOptions;
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {
            using (var dbContextOptions = new LMSDbContext(_applicationDbContext))
            {
                return await dbContextOptions.Users
                   .SingleOrDefaultAsync(u => u.Email == email);
            }
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            using (var dbContextOption = new LMSDbContext(_applicationDbContext))
            {
                return await dbContextOption.Users.ToListAsync();
            }
        }

    }
}
