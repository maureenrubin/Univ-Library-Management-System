using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
     public class CourseEntity
    {
        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<UserEntity> Users { get; set; }
    }
}
