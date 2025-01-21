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
    public class UserConfiguration : IEntityTypeConfiguration<UserEntity>
    {

        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {

            builder
                .HasKey(s => s.UserId);

            builder
                .Property(s => s.UserId)
                .ValueGeneratedOnAdd();

            builder
                .HasOne(s => s.Course)
                .WithMany(c => c.User)
                .HasForeignKey(s => s.CourseId);

        }

    }

}

