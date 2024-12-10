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

        public async Task UpdateAdminAsync(AdminDTO adminDTO)
        {
            try
            {
                var existingAdmin = await dbContext.Admins.SingleOrDefaultAsync(a => a.AdminID == adminDTO.AdminID);

                if(existingAdmin == null)
                {
                    throw new Exception("Admin not found");
                }

                existingAdmin.FirstName = adminDTO.FirstName;
                existingAdmin.LastName = adminDTO.LastName;
                existingAdmin.Email = adminDTO.Email;
                existingAdmin.Gender = adminDTO.Gender;
                existingAdmin.AdminPicture = adminDTO.AdminPicture;

                await dbContext.SaveChangesAsync();


            }
            catch (Exception ex)
            {
                throw new Exception($"Error Updating Admin: {ex.Message} ", ex);
            }
        }

    }
}
