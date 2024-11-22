using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Connectivity.Interfaces
{
    public interface IAdminRepository
    {
        Task<AdminEntity> GetAdminByEmailAsync(string email);
       
    }
}
