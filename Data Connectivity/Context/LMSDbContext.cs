using LibraryManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
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
        public DbSet<BorrowBookEntity> BorrowBook { get; set; }
        public DbSet<BookCategoryEntity> BookCategory { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Admins Entity
            modelBuilder.Entity<AdminEntity>()
                .HasKey(a => a.AdminID);

            // Users Entity
            modelBuilder.Entity<UserEntity>()
                .HasKey(u => u.UserId);

            // Courses to Users
            modelBuilder.Entity<UserEntity>()
                .HasOne(u => u.Course)
                .WithMany(c => c.User)
                .HasForeignKey(u => u.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // Books Entity
            modelBuilder.Entity<BooksEntity>()
                .HasKey(b => b.BookId);

            // BorrowBook to User
            modelBuilder.Entity<BorrowBookEntity>()
                .HasOne(b => b.User)
                .WithMany(u => u.BorrowBooks)
                .HasForeignKey(b => b.UserId);

            // BorrowBook to Book
            modelBuilder.Entity<BorrowBookEntity>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.BorrowBooks)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Restrict);

            // Books to Category
            modelBuilder.Entity<BooksEntity>()
                .HasOne(c => c.Category)
                .WithMany()
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // BookCategory Entity
            modelBuilder.Entity<BookCategoryEntity>()
                .HasKey(bc => bc.BCategoryId);

            // Courses Entity
            modelBuilder.Entity<CourseEntity>()
                .HasKey(c => c.CourseId);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

                var connectionString = configuration.GetConnectionString("DefaultConnection");

                Console.WriteLine($"Connection String: {connectionString}");

                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new ArgumentNullException("connectionString", "Connection string is missing or empty in appsettings.json");
                }

                optionsBuilder.UseSqlServer(connectionString);
            }
        }

    } 
}
