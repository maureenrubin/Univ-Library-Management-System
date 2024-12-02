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
        private readonly LMSDbContext applicationDbContext;


        public AdminServices(LMSDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;

        }

        public async Task<AdminEntity?> GetAdminByEmailAsync(string email)
        {
            try
            {
                return await applicationDbContext.Admins
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
                throw new Exception($"An Error Occured:  {ex.Message}", ex);
            }
        }



    }
}
