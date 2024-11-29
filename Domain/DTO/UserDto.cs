using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.DTO
{
    public class UserDto
    {
        public int Userid { get; set; }
    
        public string? Email{ get; set; }

        public string? Password { get; set; }

        public string? ConfirmPassword { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? Role { get; set; } = "User";

        public int? CourseId { get; set; }

        public byte []? UserPicture { get; set; }

        

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
  
    
      public virtual ICollection<CourseEntity> Courses { get; set; }
    }
}
