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
    public class UserServices : IUserServices
    {
        private readonly DbContextOptions<LMSDbContext> _dbContextOptions;

        public UserServices(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }

        public async Task<UserEntity?> GetUserByEmailAsync(string email)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    return await dbContextOptions.Users
                           .Include(u => u.Course)
                           .SingleOrDefaultAsync(u => u.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving users email.{ex.Message} ", ex);
            }
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    return await dbContextOptions.Users
                        .Include(u => u.Course)
                        .ToListAsync();

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving all Users. {ex.Message}", ex);
            }

        }
        

        public async Task<UserEntity> GetUserByIdAsync (int userId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    return await dbContextOptions.Users
                        .Include(u => u.Course)
                        .SingleOrDefaultAsync(u => u.UserId == userId);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving user by Id {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<UserEntity>> GetUserByCourseAsync(int courseId)
        {
            using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {

                return await dbContextOptions.Users
                        .Include(u => u.Course)
                        .Where(u => u.CourseId == courseId)
                        .ToListAsync();
            }
        }

    }
}
