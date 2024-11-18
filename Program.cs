using LibraryManagementSystem.Data_Connectivity.Context;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.AdminForms;
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

            // configuration for appsettings.json
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();



            var services = new ServiceCollection();

            services.AddDbContext<LMSDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

           
            services.AddTransient<AdminEntity>();
            services.AddTransient<BooksEntity>();

            services.AddTransient<LoginForm>();
            services.AddTransient<MainForm_ADMIN>();

            services.AddTransient<AdminRepository>();

            ServiceProvider = services.BuildServiceProvider();

            // Run the application
            Application.Run(ServiceProvider.GetRequiredService<LoginForm>());
        }
    }
}
