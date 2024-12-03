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

        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            try
            {
                return await dbContext.Admins
                    .Where(a => a.Email == email)

                    .Select(a => new AdminEntity
                    {
                        FirstName = a.FirstName,
                        LastName = a.LastName,
                        AdminPicture = a.AdminPicture,
                        Password = a.Password


                    })
                    .FirstOrDefaultAsync();
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


    }
}
