using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Presentation.UserControls;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class CreateAdminAccForm : Form
    {

        private readonly ICreateAccountServices createAcoountServices;
        private readonly IAdminServices adminServices;
        private readonly ManageAdminsForm manageAdminsForms;
        private byte[] AdminPicture;
        private bool IsUpdateMode = false;
        private int AdminIdToUpdate;


        public CreateAdminAccForm(
            ICreateAccountServices createAcoountServices,
            IAdminServices adminServices,
            ManageAdminsForm manageAdminsForm)
        {
            InitializeComponent();
            this.createAcoountServices = createAcoountServices;
            this.adminServices = adminServices;
            this.manageAdminsForms = manageAdminsForm;
            
        }


        private async void CreateAdminBTN_Click_1(object sender, EventArgs e)
        {
            try
            {
                string firstName = FirstNameTB.Text;
                string lastName = LastNameTB.Text;
                string email = EmailTB.Text;
                string password = PasswordTB.Text;
                string confirmPass = ConfirmPassTB.Text;
                string gender = GenderCB.Text;
                byte[] adminPicture = null;


                if (AdminPicPB.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var cloneImage = new Bitmap(AdminPicPB.Image))
                        {
                            cloneImage.Save(ms, ImageFormat.Png);
                            adminPicture = ms.ToArray();
                        }
                    }
                }

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(confirmPass))

                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               

               
                var adminDto = new AdminDTO
                {
                    LastName = lastName,
                    FirstName = firstName,
                    Email = email,
                    Password = password,
                    ConfirmPass = confirmPass,
                    AdminPicture = AdminPicture,
                    Gender = gender,

                };
                
                if (IsUpdateMode && password != confirmPass)
                {
                    MessageBox.Show("Passwords do not match. Please try again.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsUpdateMode)
                {
                    // update selected admin
                    adminDto.AdminID = AdminIdToUpdate;
                    await adminServices.UpdateAdminAsync(adminDto);
                    MessageBox.Show("Administrator updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                }
                else
                {
                    // add new admin
                    PasswordHelper.GeneratePasswordHashAndSalt(adminDto.Password);
                    await createAcoountServices.CreateAdminAccountAsync(adminDto);
                    MessageBox.Show("New Administrator created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
               
                FormsControlHelper.ClearControls(this);
                this.Refresh();
                manageAdminsForms.LoadAdminDetails();
                Close();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating new admin: " + ex.Message);
            }
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            FormsControlHelper.ClearControls(this);
        }

        public void LoadAdminDetails(AdminEntity adminEntity)
        {
            IsUpdateMode = true;
            AdminIdToUpdate = adminEntity.AdminID;

            FirstNameTB.Text = adminEntity.FirstName;
            LastNameTB.Text = adminEntity.LastName;
            EmailTB.Text = adminEntity.Email;
            GenderCB.Text = adminEntity.Gender;
            
            
            if(adminEntity.AdminPicture != null && adminEntity.AdminPicture.Length > 0)
            {
                using (var ms = new MemoryStream(adminEntity.AdminPicture))
                {
                    AdminPicPB.Image = Image.FromStream(ms);
                }
            }
           
           
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


        private void ShowPasswordTB_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB.PasswordChar = ShowPasswordTB.Checked ? '\0' : '●';
            ConfirmPassTB.PasswordChar = ShowPasswordTB.Checked ? '\0' : '●';
        }

        private void GoBackBTN_Click(object sender, EventArgs e)
        {
            FormsControlHelper.ClearControls(this);


            this.Hide();
            var adminMainForm = Program.ServiceProvider.GetRequiredService<MainForm_ADMIN>();
            adminMainForm.Show();
        }

    }
}
