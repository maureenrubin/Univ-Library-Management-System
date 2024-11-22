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
    public class AdminRepository : IAdminRepository
    {
        private readonly DbContextOptions<LMSDbContext> _applicationDbContext;

        public AdminRepository(DbContextOptions<LMSDbContext> dbContextOptions)
        {
            _applicationDbContext = dbContextOptions;

        }
        
        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            using (var dbContextOptions = new LMSDbContext(_applicationDbContext))
            {
                return await dbContextOptions.Admins
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
        }

        

    
    }
}
