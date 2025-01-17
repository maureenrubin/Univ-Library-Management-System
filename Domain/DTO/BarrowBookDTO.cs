using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.DTO
{
    public class BarrowBookDTO
    {
        public int BarrowedItemId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }


        public DateTime BarrowedDate { get; set; }
        public DateTime DueDate { get; set; }
        public int Quantity { get; set; }
        public decimal BarrowedPrice { get; set; }

        public string Title { get; set; } = string.Empty;
        public int BookStock { get; set; }
        public decimal BookPrice { get; set; }
        public byte[]? BooksPicture { get; set; }


    }
}
