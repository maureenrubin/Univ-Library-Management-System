using LibraryManagementSystem.Data_Connectivity.Context;
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
    public class AdminRepository
    {
        private readonly LMSDbContext applicationDBContext;

        public AdminRepository(LMSDbContext applicationDBContext)
        {
           this.applicationDBContext = applicationDBContext ?? throw new ArgumentNullException(nameof(applicationDBContext));
        }
        
        public async Task<AdminEntity?> AuthenticateAdminAsync(string email, string password)
        {
            var admin = await applicationDBContext.Admins
                .SingleOrDefaultAsync(a => a.Email == email);
            return admin;
        }

      //  public async Task<AdminEntity> AddNewAdminAsync(string email, string password)
       // {
           // var existingAccount = await applicationDBContext.Admins
               // .SingleOrDefaultAsync(a => a.)
       // }
    }
}
