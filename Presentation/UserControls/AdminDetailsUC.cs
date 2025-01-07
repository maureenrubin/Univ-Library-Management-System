using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.AdminForms;
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

namespace LibraryManagementSystem.Presentation.UserControls
{
    public partial class AdminDetailsUC : UserControl
    {
        private readonly AdminEntity adminEntity;
        public event EventHandler<AdminEntity> AdminClicked;
        public bool SelectedAdmin { get; private set; }

        public AdminDetailsUC(AdminEntity adminEntity)
        {
            InitializeComponent();
            this.adminEntity = adminEntity;
            this.Click += AdminDetailsUC_Click;
            LoadAdminDetails();
        }
        
        
        private void LoadAdminDetails()
        {
            string fullName = $"{adminEntity.FirstName} {adminEntity.LastName}";

            AdminNameTXT.Text = fullName;
            AdminID.Text = adminEntity.AdminID.ToString();
            AdminEmailTXT.Text = adminEntity.Email;
            GenderTXT.Text = adminEntity.Gender;
            CreatedAtLBL.Text = adminEntity.CreatedAt.ToShortDateString();


            if (adminEntity.AdminPicture != null && adminEntity.AdminPicture.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(adminEntity.AdminPicture))
                {
                    AdminPicPB.Image = Image.FromStream(ms);
                }
            }
            
        }

        private void AdminDetailsUC_Click(object sender, EventArgs e)
        {

            SelectedAdmin = !SelectedAdmin;
            this.BackColor = SelectedAdmin ? Color.LightBlue : Color.White;
            AdminClicked?.Invoke(this, adminEntity);
        }

        public AdminEntity GetAdminEntity()
        {
            return adminEntity;
        }

    }
}
