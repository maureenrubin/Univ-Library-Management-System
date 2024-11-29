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
    public class CreateAccountRepository : ICreateAccountRepository
    {
        private readonly LMSDbContext applicationDBContext;


        public CreateAccountRepository(LMSDbContext applicationDBContext)
        {
            this.applicationDBContext = applicationDBContext;
        }

        public async Task CreateAdminAccountAsync(AdminDto adminDto)
        {
            var errorMessages = new List<string>();

            if (adminDto.Password != adminDto.ConfirmPass)
            {
                errorMessages.Add("Password doesn't match.");
            }

            var existingAdmin = await applicationDBContext.Admins
                .AsNoTracking()
                .SingleOrDefaultAsync(a => a.Email == adminDto.Email);

            if (existingAdmin != null)
            {
                MessageBox.Show($"An admin with this email: '{adminDto.Email}' already exists. Please use a different email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            var createAdmin = new AdminEntity
            {
                LastName = adminDto.LastName,
                FirstName = adminDto.FirstName,
                Email = adminDto.Email,
                Password = adminDto.Password,
                ConfirmPassword = adminDto.ConfirmPass,
                AdminPicture = adminDto.AdminPicture,
                Gender = adminDto.Gender,
                Role = "Admin"
            };

            applicationDBContext.Admins.Add(createAdmin);
            await applicationDBContext.SaveChangesAsync();
        }




        public async Task CreateUserAccountAsync(UserDto userDto)
        {
           
            if (userDto.Password != userDto.ConfirmPassword)
            {
                MessageBox.Show("Passwords don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingUser = await applicationDBContext.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Email.ToLower() == userDto.Email.ToLower());

            if(existingUser != null)
            {
                MessageBox.Show($"A User with this email: '{userDto.Email}' already exists. Please use a different email", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PasswordHelper.CreatePasswordHash(userDto.Password, out byte[] passwordHash, out byte[] passwordSalt);

            
            var user = new UserEntity
            {
                Email = userDto.Email,
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                CourseId = userDto.CourseId,
                UserPicture = userDto.UserPicture,
                CreatedAt = userDto.CreatedAt,
                Role = userDto.Role,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,

            };

            applicationDBContext.Users.Add(user);
            await applicationDBContext.SaveChangesAsync();

          

        }
    }
}
