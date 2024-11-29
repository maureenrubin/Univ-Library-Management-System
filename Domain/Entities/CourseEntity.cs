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

        [Required]
        [StringLength(100)]
        public string Course { get; set; }



        public virtual ICollection<UserEntity> Students {get; set;}
        
    }
}
