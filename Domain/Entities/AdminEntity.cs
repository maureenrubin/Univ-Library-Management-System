﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class AdminEntity
    {
        public int AdminID { get; set; }

        public string Email { get; set; } = string.Empty;
       
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public byte[]? PasswordHash { get; set; }

        public byte[]?PasswordSalt { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[] AdminPicture { get; set; } 

        [Required]
        [MaxLength(10)]
        public string Role { get; set; } = "Admin";

        public DateTime CreatedAt { get; set; } 

        [Required]
        [MaxLength(10)]
        public string Gender { get; set; }

    }
}
