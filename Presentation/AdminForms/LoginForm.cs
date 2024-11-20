using LibraryManagementSystem.Data_Connectivity;
using LibraryManagementSystem.Data_Connectivity.Interfaces;
using LibraryManagementSystem.Repositories;
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

        private readonly IAdminRepository adminRepository;
        private readonly MainForm_ADMIN mainFormAdmin;
        private readonly SignInForm signInForm;

        public LoginForm
            (IAdminRepository adminRepository, MainForm_ADMIN mainFormAdmin, SignInForm signInForm)
        {

            InitializeComponent();
            this.adminRepository = adminRepository;
            this.mainFormAdmin = mainFormAdmin;
            this.signInForm = signInForm;
        }

        private async void LoginBTN_Click(object sender, EventArgs e)
        {
            string email = UsernameTXT.Text;
            string password = PasswordTXT.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and Password cannor be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var admin = await adminRepository.GetAdminByEmailAsync(email);

            if (admin != null)
            {
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            this.Hide();
            var mainFormAdmin = Program.ServiceProvider.GetRequiredService<MainForm_ADMIN>();
            mainFormAdmin.Show();
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

        private void SignInLabel_Click(object sender, EventArgs e)
        {
            UsernameTXT.Clear();
            PasswordTXT.Clear();

            this.Hide();
            var signInForm = Program.ServiceProvider.GetRequiredService<SignInForm>();
            signInForm.Show();
        }

        
    }
}
