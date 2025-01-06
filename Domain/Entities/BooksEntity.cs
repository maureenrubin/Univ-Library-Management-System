using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BooksEntity
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Genre { get; set; } = string.Empty;

        [Required]
        public DateTime PublishedDate { get; set; }

        [Range(0, int.MaxValue)]
        public int BookStock { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal BookPrice { get; set; }

        [Column(TypeName = "varbinary(max)")]
        public byte[]? BooksPicture { get; set; }

        [MaxLength(100)]
        public string Category { get; set; } = string.Empty;

        public int BookAvailable { get; set; }

        public ICollection<BarrowedItemEntity> BarrowedItem { get; set; }
    }
}
