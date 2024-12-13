using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories
{
    public class AdminServices : IAdminServices
    {
        private readonly DbContextOptions<LMSDbContext> _dbContextOptions;


        public AdminServices(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            this._dbContextOptions = dbContextOptions;

        }

        public async Task<AdminEntity?> GetAdminByIdAsync(int adminId)
        {
            using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Admins
               .SingleOrDefaultAsync(a => a.AdminID == adminId);
            }
        }

        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    return await dbContextOptions.Admins
                    .SingleOrDefaultAsync(a => a.Email == email);
              
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Getiing Admin Email:  {ex.Message}", ex);
            }
        }

        public async Task<IEnumerable<AdminEntity>> GetAllAdminAsync()
        {
            using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
            {
                return await dbContextOptions.Admins.ToListAsync();

            }
        }

        public async Task UpdateAdminAsync(AdminDTO adminDTO)
        {
            try
            {
                using (var dbContextOptions = new LMSDbContext(_dbContextOptions))
                {
                    var existingAdmin = await dbContextOptions.Admins.SingleOrDefaultAsync(a => a.AdminID == adminDTO.AdminID);

                    if (existingAdmin == null)
                    {
                        throw new Exception("Admin not found");
                    }

                    existingAdmin.FirstName = adminDTO.FirstName;
                    existingAdmin.LastName = adminDTO.LastName;
                    existingAdmin.Email = adminDTO.Email;
                    existingAdmin.Gender = adminDTO.Gender;
                    existingAdmin.AdminPicture = adminDTO.AdminPicture;

                    if (!string.IsNullOrEmpty(adminDTO.Password))
                    {
                        (existingAdmin.PasswordHash, existingAdmin.PasswordSalt) = PasswordHelper.GeneratePasswordHashAndSalt(adminDTO.Password);

                    }
                    await dbContextOptions.SaveChangesAsync();

                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Updating Admin: {ex.Message} ", ex);
            }
        }

    }
}
