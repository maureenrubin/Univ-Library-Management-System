﻿using System;
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
       
        [Required]
        [MaxLength(200)]
        public string Password { get; set; } = string.Empty;
       
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string LastName { get; set; } = string.Empty;

        [Column(TypeName = "varbinary(max)")]
        public byte[]? UserPicture { get; set; }

        [Required]
        public string Role { get; set; } 

        [Required]
        [MaxLength(200)]
        public string? Course { get; set; }


        public DateTime CreatedAt { get; set; } 

    }
}
