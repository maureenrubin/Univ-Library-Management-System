using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Data_Connectivity.Interfaces;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
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

        public async Task CreateAccountAsync(AdminDto adminDto)
        {
            var errorMessages = new List<string>();

            if(adminDto.Password != adminDto.ConfirmPass)
            {
                errorMessages.Add("Password doesn't match.");
            }

            var existingAdmin = await applicationDBContext.Admins
                .AsNoTracking()
                .SingleOrDefaultAsync(a => a.Email == adminDto.Email);

            if(existingAdmin != null)
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

    }
}
