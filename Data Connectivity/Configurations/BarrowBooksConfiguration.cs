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
    public class BarrowBooksConfiguration : IEntityTypeConfiguration<BarrowedItemEntity>
    {
        public void Configure(EntityTypeBuilder<BarrowedItemEntity> builder)
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

            builder.HasOne(p => p.User)
                .WithMany(u => u.BarrowedItem)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.Book)
                .WithMany(b => b.BarrowedItem)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Cascade);





        }
    }
}
