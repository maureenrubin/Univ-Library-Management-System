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

        public async Task<int> AddAdminAsync(AdminEntity admin)
        {
            using (var dbContextOptions = new LMSDbContext(_applicationDbContext))
            {
                await dbContextOptions.Admins.AddAsync(admin);
                await dbContextOptions.SaveChangesAsync();

                return admin.AdminID;
            }
        }
        
        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            using (var dbContextOptions = new LMSDbContext(_applicationDbContext))
            {
                return await dbContextOptions.Admins
                    .FirstOrDefaultAsync(a => a.Email == email);
            }
        }

        

      //  public async Task<AdminEntity> AddNewAdminAsync(string email, string password)
       // {
           // var existingAccount = await applicationDBContext.Admins
               // .SingleOrDefaultAsync(a => a.)
       // }
    }
}
