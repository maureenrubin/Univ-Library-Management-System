using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
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

       public async Task UpdateUserAsync(UserDTO userDTO)
        {
            try
            {
                using (var dbContextoptions = new LMSDbContext(_dbContextOptions))
                {
                    var existingUser = await dbContextoptions.Users.SingleOrDefaultAsync(u => u.UserId == userDTO.UserId);

                    if(existingUser == null)
                    {
                        throw new Exception("User not found");
                    }

                    existingUser.FirstName = userDTO.FirstName;
                    existingUser.LastName = userDTO.LastName;
                    existingUser.Email = userDTO.Email;
                    existingUser.UserPicture = userDTO.UserPicture;
                    existingUser.CourseId = userDTO.CourseId;

                    if (!string.IsNullOrEmpty(userDTO.Password))
                    {
                        (existingUser.PasswordHash, existingUser.PasswordSalt) = PasswordHelper.GeneratePasswordHashAndSalt(userDTO.Password);
                    }

                    await dbContextoptions.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Updating User: {ex.Message}", ex);
            }
       }

        public async Task RemoveUserAsync (int userId)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var user = await dbContextOptions.Users
                        .SingleOrDefaultAsync(u => u.UserId == userId);

                    if(user != null)
                    {
                        dbContextOptions.Users.Remove(user);

                        await dbContextOptions.SaveChangesAsync();
                        
                    }
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Removing User: {ex.Message}", ex);
            }
        }

    }
}
