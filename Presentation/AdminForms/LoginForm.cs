using LibraryManagementSystem.Data_Connectivity;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Presentation.UserForms;
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
    public partial class LoginForm : Form
    {

        private readonly IAdminServices adminServices;
        private readonly IUserServices userServices;



        private readonly MainForm_ADMIN mainFormAdmin;
        private readonly CreateAdminAccForm signInForm;


        public LoginForm(
                            IAdminServices adminServices, IUserServices userServices,
                            MainForm_ADMIN mainFormAdmin,
                            CreateAdminAccForm signInForm)
        {

            InitializeComponent();
            this.adminServices = adminServices;
            this.userServices = userServices;
            this.mainFormAdmin = mainFormAdmin;
            this.signInForm = signInForm;
        }


        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void ShowPassCB_CheckedChanged(object sender, EventArgs e)
        {

            if (ShowPassCB.Checked)
            {
                PasswordTXT.PasswordChar = '\0';
            }
            else
            {
                PasswordTXT.PasswordChar = '●';
            }
        }

        private async void LoginBTN_Click_1(object sender, EventArgs e)
        {
            string email = UsernameTXT.Text;
            string password = PasswordTXT.Text;


            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var admin = await adminServices.GetAdminByEmailAsync(email);

            if (admin != null && PasswordHelper.VerifyPasswordHash(password, admin.PasswordHash, admin.PasswordSalt))
            {
                MessageBox.Show("Admin Logged in Successfully, Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var mainFormAdmin = Program.ServiceProvider.GetRequiredService<MainForm_ADMIN>();
                mainFormAdmin.CurrentAdmin = admin;

                this.Hide();
                mainFormAdmin.Show();
                FormsControlHelper.ClearControls(this);
                return;
            }

            var user = await userServices.GetUserByEmailAsync(email);

            if (user != null && PasswordHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                MessageBox.Show("Student Logged in Successfully, Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var studentMainForm = Program.ServiceProvider.GetRequiredService<UserMainForm>();
                studentMainForm.CurrentUsers = user;

                this.Hide();
                studentMainForm.Show();
                FormsControlHelper.ClearControls(this);
                return;
            }

            MessageBox.Show("Incorrect email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void ForgotPassLBL_Click(object sender, EventArgs e)
        {
            // forgot pass form

        }
    }
}
