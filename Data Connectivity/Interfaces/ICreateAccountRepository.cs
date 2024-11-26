using LibraryManagementSystem.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Connectivity.Interfaces
{
    public interface ICreateAccountRepository
    {

        Task CreateAdminAccountAsync(AdminDto adminDto);

        Task CreateUserAccountAsync(UserDto userDto);
    }
}
