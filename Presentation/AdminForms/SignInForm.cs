using LibraryManagementSystem.Data_Connectivity.Interfaces;
using LibraryManagementSystem.Domain.DTO;
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
    public partial class SignInForm : Form
    {

        private readonly ICreateAccountRepository createAccountRepository;
        private byte[] AdminPicture;

        public SignInForm(ICreateAccountRepository createAccountRepository)
        {
            InitializeComponent();
            this.createAccountRepository = createAccountRepository;
        }

        private async void SignInBTN_Click(object sender, EventArgs e)
        {
            string firstName = FirstNameTB.Text;
            string lastName = LastNameTB.Text;
            string email = EmailTB.Text;
            string password = PasswordTB.Text;
            string confirmPass = ConfirmPassTB.Text;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPass))

            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var createAdminDto = new AdminDto
            {
                LastName = lastName,
                FirstName = firstName,
                Email = email,
                Password = password,
                ConfirmPass = confirmPass,
            };

            await createAccountRepository.CreateAccountAsync(createAdminDto);
            MessageBox.Show("Admin created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Clear Controls

        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            FirstNameTB.Clear();
            LastNameTB.Clear();
            EmailTB.Clear();
            PasswordTB.Clear();
            ConfirmPassTB.Clear();

            this.Hide();
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();
        }

        private void SelectImageBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images Files | *.jp;*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    AdminPicture = File.ReadAllBytes(openFileDialog.FileName);
                    AdminPicPB.Image = Image.FromStream(new MemoryStream(AdminPicture));
                }
            }
        }
    }
}
