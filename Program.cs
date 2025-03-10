using LibraryManagementSystem.Data;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Presentation;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Presentation.UserForms;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    static class Program
     {
        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            var services = new ServiceCollection();


            services.AddScoped<IAdminServices, AdminServices>();
            services.AddScoped<IBookServices, BookServices>();
            services.AddScoped<ICourseServices, CourseServices>();
            services.AddScoped<ICreateAccountServices, CreateAccountServices>();
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddScoped<IBorrowBookServices, BorrowBookServices>();
            services.AddScoped<IRoleServices, RoleServices>();

            services.AddScoped<AdminEntity>();
            services.AddScoped<BooksEntity>();
            services.AddScoped<UserEntity>();
            services.AddScoped<CourseEntity>();
            services.AddScoped<BorrowTransaction>(); 
            services.AddScoped<BookCategoryEntity>();


            services.AddScoped<LoginForm>();
            services.AddScoped<CreateAdminAccForm>();
            services.AddScoped<AdminHomeForm>();
            services.AddScoped<BorrowBookForm>();
            
            services.AddScoped<MainForm_ADMIN>();
            services.AddScoped<AdminManageUserForm>();
            services.AddScoped<AdminBooksForm>();
            services.AddScoped<AdminTransactionForm>();
            services.AddScoped<ManageAdminsForm>();
            services.AddScoped<ResetPassForm>();
            services.AddScoped<BookUC>();


            services.AddScoped<UserMainForm>();
            services.AddScoped<UserBookForm>();
            services.AddScoped<UserHomeForm>();

            services.AddScoped<Animations>();

            services.AddDbContext<LMSDbContext>(options =>
                   options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));


            ServiceProvider = services.BuildServiceProvider();

            
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
    }
}
