using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class AdminEntity
    {
        public int AdminID { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; }
        public string? LastName { get; set; }
        public string? Password { get; set; }

    }
}
