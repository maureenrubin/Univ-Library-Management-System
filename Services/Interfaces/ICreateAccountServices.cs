using LibraryManagementSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Repositories.Interfaces
{
    public interface ICreateAccountServices
    {

        Task CreateAdminAccountAsync(AdminDTO adminDTO);
        Task CreateUserAccountAsync(UserDTO userDTO);
   
    }
    

}
