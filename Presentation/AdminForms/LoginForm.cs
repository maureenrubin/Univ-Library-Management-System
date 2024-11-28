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

        private readonly IAdminRepository adminRepository;
        private readonly IUserRepository userRepository;



        private readonly MainForm_ADMIN mainFormAdmin;
        private readonly SignInForm signInForm;


        public LoginForm
            (IAdminRepository adminRepository, IUserRepository userRepository,
            MainForm_ADMIN mainFormAdmin, 
            SignInForm signInForm)
        {

            InitializeComponent();
            this.adminRepository = adminRepository;
            this.userRepository = userRepository;
            this.mainFormAdmin = mainFormAdmin;
            this.signInForm = signInForm;
        }

        private async void LoginBTN_Click(object sender, EventArgs e)
        {
            string email = UsernameTXT.Text;
            string password = PasswordTXT.Text;
            

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email and Password cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var admin = await adminRepository.GetAdminByEmailAsync(email);
            if (admin != null && admin.Password == password)
            {
                MessageBox.Show("Login Successfully, Welcome! '", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var mainFormAdmin = Program.ServiceProvider.GetRequiredService<MainForm_ADMIN>();
                mainFormAdmin.CurrentAdmin = admin;
                
                this.Hide();
                mainFormAdmin.Show();
                return;

            }


            var user = await userRepository.GetUserByEmailAsync(email);
             if (user != null)

             {
                    if (PasswordHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
                    {
                        MessageBox.Show("Student Login Successfully, Welcome!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        var studentMainForm = Program.ServiceProvider.GetRequiredService<UserMainForm>();
                        studentMainForm.CurrentUser = user;
                        
                        this.Hide();
                        studentMainForm.Show();
                        return;
                    }
             }
            
            
            MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            

          

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
