using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Connectivity.Configurations
{
    public class BookCatConfiguration : IEntityTypeConfiguration<BookCategoryEntity>
    {

        public void Configure(EntityTypeBuilder<BookCategoryEntity> builder)
        {
            builder
                .HasKey(c => c.BCategoryId);

            builder.HasOne(bc => bc.Book)
                .WithMany(b => b.BookCategories)
                .HasForeignKey(bc => bc.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
