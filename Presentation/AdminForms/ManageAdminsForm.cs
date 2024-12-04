using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Presentation.UserControls;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class ManageAdminsForm : Form
    {
        private readonly IAdminServices adminServices;

        public ManageAdminsForm(IAdminServices adminServices)
        {
            InitializeComponent();
            this.adminServices = adminServices;
            LoadAdminDetails();
        }

       
        public async void LoadAdminDetails()
        {
            try
            {
                var adminList = await adminServices.GetAllAdminAsync();

                FormsControlHelper.ClearControls(this);

                foreach (var admin in adminList)
                {
                    AdminDetailsUC adminDetails = new AdminDetailsUC(admin);
                    AdminsFLP.Controls.Add(adminDetails);
                }

            }catch(Exception ex)
            {
                throw new Exception($"Error Loading Admin Details: {ex.Message}", ex);
            }
        }

        private void AddAdminBTN_Click(object sender, EventArgs e)
        {
            var signInForm = Program.ServiceProvider.GetRequiredService<CreateAdminAccForm>();
            signInForm.Show();
        }


    }
}
