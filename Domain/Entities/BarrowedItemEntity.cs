using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BarrowedItemEntity
    {
        public int BarrowedItemId { get; set; }

        public DateTime BarrowedDate { get; set; }

        public DateTime DueDate { get; set; }

        public int BookId { get; set; }

        public int UserId { get; set; }

        public decimal BarrowedPrice { get; set; }

        public int Quantity { get; set; }
       

        public UserEntity User { get; set; }
        public BooksEntity Book { get; set; }
    }
}
