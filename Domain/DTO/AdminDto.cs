using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.DTO
{
    public class AdminDto
    {
        public int AdminID { get; set; }

        public string? Email { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Password { get; set; }

        public string? ConfirmPass { get; set; }

        public byte[]? AdminPicture { get; set; }

        public string? Role { get; set; } = "Admin";

        public string? Gender { get; set; }
    }
}
