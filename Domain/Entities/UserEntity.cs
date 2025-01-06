using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class UserEntity
    {
        [Key]
        public int UserId { get; set; }
     
        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = string.Empty;

        [Column(TypeName = "varbinary(max)")]
        public byte[]? PasswordHash { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[]? PasswordSalt { get; set; }

        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; } = string.Empty;

        [Column(TypeName = "varbinary(max)")]
        public byte[]? UserPicture { get; set; }

        [Required]
        public string Role { get; set; } = "User";

        public int? CourseId { get; set; }

        public DateTime CreatedAt { get; set; }

      
        
      public CourseEntity Course { get; set; }
      public ICollection<BarrowedItemEntity> BarrowedItem { get; set; }

    }
}
