using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Entities
{
    public class BookCategoryEntity
    {
        public int BCategoryId { get; set; }

        public int BookId { get; set; }

        public string CategoryName { get; set; }

        public DateTime CreatedAt { get; set; }

        public BooksEntity Book { get; set; }
    }
}
