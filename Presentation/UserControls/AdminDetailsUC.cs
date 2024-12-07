using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.UserControls
{
    public partial class AdminDetailsUC : UserControl
    {
        private readonly AdminEntity adminEntity;


        public AdminDetailsUC(AdminEntity adminEntity)
        {
            InitializeComponent();
            this.adminEntity = adminEntity;
            LoadAdminDetails();
        }

        private void LoadAdminDetails()
        {
            AdminFnameTXT.Text = adminEntity.FirstName;
            AdminLnameTXT.Text = adminEntity.LastName;
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
            else
            {
                MessageBox.Show("Invalid image data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
