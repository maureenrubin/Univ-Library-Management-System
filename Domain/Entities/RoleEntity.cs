using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class RoleEntity
    {
        [Key]
        public int RoleId { get; set; }

        public string? RoleName { get; set; }

        public ICollection<UserRoleEntity> UserRoles { get; set; }
    }
}
