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
    public class BarrowBooksConfiguration : IEntityTypeConfiguration<BarrowBookEntity>
    {
        public void Configure(EntityTypeBuilder<BarrowBookEntity> builder)
        {
            builder.ToTable("BarrowBook");

            builder.HasKey(p => p.BarrowedItemId);

            
            builder.Property(p => p.BarrowedDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()");


            builder.Property(p => p.BarrowedPrice)
                .IsRequired()
                .HasDefaultValue(0m);

            builder.Property(p => p.Quantity)
                .IsRequired();

            builder.Property(p => p.DueDate)
                .IsRequired();

            // User Relationship
            builder.HasOne(p => p.User)
                .WithMany(u => u.BarrowBooks)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            // Book Relationship
            builder.HasOne(p => p.Book)
                .WithMany(b => b.BarrowBooks)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Restrict);





        }
    }
}
