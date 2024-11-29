using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Presentation.Animation;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.VisualBasic;
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
    public partial class AdminManageUserForm : Form

    {

        private readonly ICreateAccountRepository _createAccountRepository;


        private System.Windows.Forms.Timer _crudStudentTransition;
        private System.Windows.Forms.Timer _sideUserTransition;
        private Animations _animations;
        private bool _sidebarExpanded;
        private byte[] UserPicture;
        private readonly UserEntity _addedUser;


        public AdminManageUserForm(ICreateAccountRepository createAccountRepository)
        {
            _createAccountRepository = createAccountRepository;
            InitializeComponent();
            _crudStudentTransition = new System.Windows.Forms.Timer { Interval = 10 };
            _sideUserTransition = new System.Windows.Forms.Timer { Interval = 10 };
            _animations = new Animations();
            _animations.CrudStudentTransition(_crudStudentTransition, StudentPanel, _sidebarExpanded);
            _animations.SideStudentTransition(_sideUserTransition, StudentPanel, _sidebarExpanded);

            LoadStudentDetails();

        }

        private void ManageUserBTN_Click(object sender, EventArgs e)
        {
            _sideUserTransition.Start();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            _crudStudentTransition.Start();
        }

        private async void SaveUserBtn_Click(object sender, EventArgs e)
        {
            string firstName = UserFirstNameTXT.Text;
            string lastName = UserLastNameTXT.Text;
            string course = UserCourseCB.Text;
            string email = UserEmailTXT.Text;
            string password = UserPasswordTXT.Text;
            string confirmPassword = UserConfirmPassTXT.Text;
            byte[] userPicture = null;

            if (UserPicturePB.Image != null)
            {
                using (var ms = new MemoryStream())
                {
                    UserPicturePB.Image.Save(ms, UserPicturePB.Image.RawFormat);
                    userPicture = ms.ToArray();
                }
            }

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(course) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))

            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var createUser = new UserDto
            {
                FirstName = firstName,
                LastName = lastName,
                Course = course,
                Email = email,
                Password = password,
                ConfirmPassword = confirmPassword,
                Role = "User",
                UserPicture = userPicture,

            };



            await _createAccountRepository.CreateUserAccountAsync(createUser);
            MessageBox.Show("Student Account Created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FormsControlHelper.ClearControls(this);
        }

        private void LoadStudentDetails()
        {

        }

        private void BrowseImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images Files | *.jp; *.jpg; *.jpeg; *.png; *.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    UserPicture = File.ReadAllBytes(openFileDialog.FileName);
                    UserPicturePB.Image = Image.FromStream(new MemoryStream(UserPicture));
                }
            }
        }

        private void CBShowpass_CheckedChanged(object sender, EventArgs e)
        {
            UserPasswordTXT.PasswordChar = CBShowpass.Checked ? '\0' : '●';
            UserConfirmPassTXT.PasswordChar = CBShowpass.Checked ? '\0' : '●';
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            FormsControlHelper.ClearControls(this);

        }
    }
}
