using LibraryManagementSystem.Data_Connectivity;
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

        private readonly AdminRepository _adminRepository;
        private readonly MainForm_ADMIN _mainFormAdmin;

        public LoginForm
            (AdminRepository adminRepository, MainForm_ADMIN mainForm_Admin)
        {

            InitializeComponent();
            _adminRepository = adminRepository;
            _mainFormAdmin = mainForm_Admin;
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
            try
            {


                var admin = await _adminRepository.AuthenticateAdminAsync(email, password);

                if (admin != null)
                {
                    MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    _mainFormAdmin.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
    }
}
