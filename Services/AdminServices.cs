using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
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
        private readonly LMSDbContext dbContext;


        public AdminServices(LMSDbContext dbContext)
        {
            this.dbContext = dbContext;

        }

        public async Task<AdminEntity?> GetAdminByIdAsync(int adminId)
        {
            try
            {
                return await dbContext.Admins
               .SingleOrDefaultAsync(a => a.AdminID == adminId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Getting Admin Id: {ex.Message}", ex);
            }
        }

        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            try
            {
                return await dbContext.Admins
                    .SingleOrDefaultAsync(a => a.Email == email);
                   
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Getiing Admin Email:  {ex.Message}", ex);
            }
        }
        
        public async Task<IEnumerable<AdminEntity>> GetAllAdminAsync()
        {
            return await dbContext.Admins.ToListAsync();
        }

        public async Task UpdateAdminAsync(AdminEntity updatedAdmin)
        {
            try
            {
                var existingAdmin = await dbContext.Admins.FindAsync(updatedAdmin.AdminID);

                if(existingAdmin == null)
                {
                    throw new Exception("Admin not found");
                }

                existingAdmin.FirstName = updatedAdmin.FirstName;
                existingAdmin.LastName = updatedAdmin.LastName;
                existingAdmin.Email = updatedAdmin.Email;
                existingAdmin.Gender = updatedAdmin.Gender;

                if (updatedAdmin.AdminPicture != null)
                {
                    existingAdmin.AdminPicture = updatedAdmin.AdminPicture;
                }

                await dbContext.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                throw new Exception($"Error Updating Admin: {ex.Message} ", ex);
            }
        }

    }
}
