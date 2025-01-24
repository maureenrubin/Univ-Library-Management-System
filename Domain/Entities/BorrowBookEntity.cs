using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BorrowBookEntity
    {
        [Key]
        public int BarrowedItemId { get; set; }
        public DateTime BarrowedDate { get; set; }
        public DateTime? DueDate { get; set; }

        public int? BookId { get; set; }
        public int UserId { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal BarrowedPrice { get; set; }
        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }
        public int BookStock  { get; set; }

        public UserEntity User { get; set; }
        public BooksEntity Book { get; set; }
    }
}
