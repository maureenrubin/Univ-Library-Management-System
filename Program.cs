using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Data_Connectivity.Interfaces;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Presentation.UserForms;
using LibraryManagementSystem.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public static class Program
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

            services.AddDbContext<LMSDbContext>(options =>
                  options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                      );

            services.AddTransient<AdminEntity>();

            services.AddTransient<ICreateAccountRepository, CreateAccountRepository>();
            services.AddTransient<IAdminRepository, AdminRepository>();
          
            
            
            
            services.AddTransient<LoginForm>();
            services.AddTransient<SignInForm>();

         
            
            services.AddTransient<MainForm_ADMIN>();
            services.AddTransient<AdminAccountForm>();
            services.AddTransient<AdminBooksForm>();
            services.AddTransient<AdminTransactionForm>();


            services.AddTransient<UserMainForm>();



           

           
            ServiceProvider = services.BuildServiceProvider();

            // Run the application
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
    }
}
