﻿using LibraryManagementSystem.Data_Connectivity.Configurations;
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
        public DbSet<BarrowBookEntity> BarrowBook { get; set; }
        public DbSet<BookCategoryEntity> BookCategory { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new BooksConfiguration());

            modelBuilder.Entity<BarrowBookEntity>()
                .HasOne(b => b.User)
                .WithMany(u => u.BarrowBooks)
                .HasForeignKey(b => b.UserId);

            modelBuilder.Entity<BarrowBookEntity>()
                .HasOne(b => b.Book)
                .WithMany(bk => bk.BarrowBooks)
                .HasForeignKey(b => b.BookId);


            modelBuilder.ApplyConfiguration(new BookCatConfiguration());
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
