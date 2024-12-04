using LibraryManagementSystem.Data_Connectivity.Context;
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
                    Role = adminDTO.Role,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,
                };

                applicationDBContext.Admins.Add(createAdmin);
                await applicationDBContext.SaveChangesAsync();
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
                    MessageBox.Show("Passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var existingUser = await applicationDBContext.Users
                                          .SingleOrDefaultAsync(u => u.Email.ToLower() == userDTO.Email.ToLower());

                if (existingUser != null)
                {
                    MessageBox.Show($"A User with this email: '{userDTO.Email}' already exists. Please use a different email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
                    Role = userDTO.Role,
                    PasswordHash = passwordHash,
                    PasswordSalt = passwordSalt,

                };

                applicationDBContext.Users.Add(createUser);
                await applicationDBContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Adding User:  {ex.Message}", ex);
            }

        }
    }
}
