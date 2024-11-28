using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Presentation.UserForms;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
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
        public static IServiceProvider ServiceProvider { get; private set; }

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

            services.AddDbContext<LMSDbContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICreateAccountRepository, CreateAccountRepository>();
            services.AddScoped<IBooksRepository, BookRepository>();
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<AdminEntity>();
            services.AddScoped<BooksEntity>();
            services.AddScoped<UserEntity>();


            services.AddScoped<LoginForm>();
            services.AddScoped<SignInForm>();

         
            
            services.AddScoped<MainForm_ADMIN>();
            services.AddScoped<AdminManageUserForm>();
            services.AddScoped<AdminBooksForm>();
            services.AddScoped<AdminTransactionForm>();
       


            services.AddScoped<UserMainForm>();



           

           
            ServiceProvider = services.BuildServiceProvider();

            
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
    }
}
