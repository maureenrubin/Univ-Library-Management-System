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
    public class AdminConfiguration : IEntityTypeConfiguration<AdminEntity>
    {

     public void Configure (EntityTypeBuilder<AdminEntity> builder)
        {
            builder.HasKey(a => a.AdminID);

            builder.Property(a => a.Email)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(a => a.FirstName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.LastName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(a => a.Password)
                .IsRequired()
                .HasMaxLength(255);


        }
    }
}
