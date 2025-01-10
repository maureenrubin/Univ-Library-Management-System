using LibraryManagementSystem.Data_Connectivity.Configurations;
using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Data_Connectivity.Context
{
    public class LMSDbContext : DbContext
    {
        public LMSDbContext()
        {

        }

        public LMSDbContext(DbContextOptions<LMSDbContext> options) : base(options)
        {
        
        }
        
        public DbSet<AdminEntity> Admins { get; set; }
        public DbSet<BooksEntity> Books { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CourseEntity> Courses { get; set; }
        public DbSet<BarrowedItemEntity> BarrowedItems { get; set; }
        public DbSet<BookCategoryEntity> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new BooksConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new BarrowItemsConfiguration());
            modelBuilder.ApplyConfiguration(new BookCatConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DJOKERZ\\SQLEXPRESS;Initial Catalog=LibraryManagementDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;");
            }
        }

    } 
}
