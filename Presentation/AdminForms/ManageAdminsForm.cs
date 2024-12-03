using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Presentation.UserControls;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class ManageAdminsForm : Form
    {
        private readonly IAdminServices adminServices;

        public ManageAdminsForm(IAdminServices adminServices)
        {
            InitializeComponent();
            LoadAdminDetails();
        }

        private async void LoadAdminDetails()
        {
            var adminList = await adminServices.GetAllAdminAsync();
            
            FormsControlHelper.ClearControls(this);

            foreach (var admin in adminList)
            {
                AdminDetailsUC adminDetails = new AdminDetailsUC(admin);
             

               AdminsFLP.Controls.Add(adminDetails);
            }

        }
    }
}
