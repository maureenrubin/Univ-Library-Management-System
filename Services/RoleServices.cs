using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services
{
    public class RoleServices : IRoleServices
    {
        private readonly LMSDbContext _dbContext;

        public RoleServices(LMSDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<List<RoleEntity>> GetRolesByUserIdAsync(int userId)
        {
            try
            {
                return await _dbContext.UserRoles
                        .Where(ur => ur.UserId == userId)
                        .Select(ur => ur.Role)
                        .ToListAsync();
                
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving user roles: {ex.Message}", ex);
            }
        }


    }
}
