using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.DTO
{
    public class BookDTO
    {
        public int BookId { get; set; }

        public string? Title { get; set; }

        public string? Genre { get; set; }

        public DateTime PublishedDate { get; set; }

        public int BookStock { get; set; }

        public decimal BookPrice { get; set; }

        public byte []? BooksPicture { get; set; }

        public string? Category { get; set; }

        

    }
}
