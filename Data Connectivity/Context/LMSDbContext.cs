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

        public DbSet<AdminEntity> Admins { get; set; } = null!;
        public DbSet<BooksEntity> Books { get; set; } = null!;

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new BooksConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DJOKERZ\SQLEXPRESS;Initial Catalog=LibraryManagementDb;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;");
        }


    }
}
