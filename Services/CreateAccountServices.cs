using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class CreateAccountServices : ICreateAccountServices
    {
       
        private readonly LMSDbContext applicationDBContext;


        public CreateAccountServices(LMSDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task CreateAdminAccountAsync(AdminDTO adminDTO)
        {
            try
            {

                var errorMessages = new List<string>();

                if (adminDTO.Password != adminDTO.ConfirmPass)
                {
                    errorMessages.Add("Password doesn't match.");
                }

                var existingAdmin = await applicationDBContext.Admins
                                    .SingleOrDefaultAsync(a => a.Email == adminDTO.Email);

                if (existingAdmin != null)
                {
                    MessageBox.Show($"An admin with this email: '{adminDTO.Email}' already exists. Please use a different email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                PasswordHelper.CreatePasswordHash(adminDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);

                var createAdmin = new AdminEntity
                {
                    LastName = adminDTO.LastName,
                    FirstName = adminDTO.FirstName,
                    Email = adminDTO.Email,
                    AdminPicture = adminDTO.AdminPicture,
                    Gender = adminDTO.Gender,
                    CreatedAt = adminDTO.CreatedAt,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                };

                applicationDBContext.Admins.Add(createAdmin);
                await applicationDBContext.SaveChangesAsync();

                var role = await applicationDBContext.Roles.SingleOrDefaultAsync(r => r.RoleName == adminDTO.Role);

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding Admin. {ex.Message}", ex);
            }

        }



        
        public async Task CreateUserAccountAsync(UserDTO userDTO)
        {
            try
            {

                if (userDTO.Password != userDTO.ConfirmPassword)
                {
                    throw new Exception("Password doesn't match. Try again.");
                }

                var existingUser = await applicationDBContext.Users
                                          .SingleOrDefaultAsync(u => u.Email.ToLower() == userDTO.Email.ToLower());

                if (existingUser != null)
                {
                    throw new InvalidOperationException($"A user with the email '{userDTO.Email}' already exists.");
                }

                PasswordHelper.CreatePasswordHash(userDTO.Password, out byte[] passwordHash, out byte[] passwordSalt);


                var createUser = new UserEntity
                {
                    Email = userDTO.Email,
                    FirstName = userDTO.FirstName,
                    LastName = userDTO.LastName,
                    CourseId = userDTO.CourseId,
                    UserPicture = userDTO.UserPicture,
                    CreatedAt = userDTO.CreatedAt,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,

                };

                applicationDBContext.Users.Add(createUser);
                await applicationDBContext.SaveChangesAsync();

                var role = await applicationDBContext.Roles
                    .SingleOrDefaultAsync(r => r.RoleName == userDTO.Role);

                if (role != null)
                {
                    var userRole = new UserRoleEntity
                    {
                        UserId = createUser.UserId,
                        RoleId = role.RoleId
                    };

                    applicationDBContext.UserRoles.Add(userRole);
                    await applicationDBContext.SaveChangesAsync();
                }
                else
                {
                    throw new Exception($"Role '{userDTO.Role}' not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding User:  {ex.Message}", ex);
            }

        }
    }
}
