using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class PurchaseEntity
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public int Quantity { get; set; }
       
        public UserEntity User { get; set; }
        public BooksEntity Book { get; set; }
    }
}
