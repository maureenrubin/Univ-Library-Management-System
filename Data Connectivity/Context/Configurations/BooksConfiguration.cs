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
    public class BooksConfiguration : IEntityTypeConfiguration<BooksEntity>
    {

        public void Configure (EntityTypeBuilder<BooksEntity> builder)
        {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(b => b.Genre)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(b => b.CategoryId)
                .IsRequired();

            builder.Property(b => b.PublishedDate)
                .IsRequired();

            builder.Property(b => b.BookStock)
                .IsRequired()
                .HasDefaultValue(0);

            builder.Property(b => b.BookPrice)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.HasOne(b => b.Category) // Navigation property
                 .WithMany()
                 .HasForeignKey(b => b.CategoryId) // Foreign key in BooksEntity
                 .OnDelete(DeleteBehavior.Restrict); //delete books if category is deleted
            


            builder.ToTable("Books");
                
        }

    }
}
