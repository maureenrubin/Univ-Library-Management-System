using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Presentation.UserControls;
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
using System.Xml.Serialization;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class AdminManageUserForm : Form

    {

        private readonly ICreateAccountServices createAcoountServices;
        private readonly IUserServices userServices;
        private readonly ICourseServices courseServices;


        private System.Windows.Forms.Timer crudStudentTransition;
        private System.Windows.Forms.Timer openCrudTransition;
        private readonly Animations animations;
        private bool sidebarExpanded;

        private byte[] UserPicture;



        public AdminManageUserForm(
               ICreateAccountServices createAcoountServices,
               IUserServices userServices,
               ICourseServices courseServices, 
               Animations animations)
        {

            InitializeComponent();
            this.createAcoountServices = createAcoountServices;
            this.userServices = userServices;
            this.courseServices = courseServices;

            this.crudStudentTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.openCrudTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.animations = animations;
            this.animations.CrudStudentTransition(crudStudentTransition, StudentPanel, sidebarExpanded);
            this.animations.OpenCrudTransition(openCrudTransition, StudentPanel, sidebarExpanded);

            LoadCources();
            LoadStudentDetails();


        }


        private async void LoadStudentDetails()
        {
            var userList = await userServices.GetAllUsersAsync();

            FormsControlHelper.ClearControls(this);

            foreach (var student in userList)
            {
                UserControlHelper.AddUserContromToPanel(student, ITStudentFLP, SWStudentFLP, BEStudentFLP, BAStudentFLP);
            }
        }

        private async void LoadCources()
        {
            try
            {
                var courses = await courseServices.GetAllCourseAsync();
                if (courses.Any())
                {
                    UserCourseCB.DataSource = courses.ToList();
                    UserCourseCB.ValueMember = "CourseId";
                }
                else
                {
                    MessageBox.Show("No courses available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error Loading Course: {ex.Message}", ex);
            }
        }

        private async void SaveUserBtn_Click(object sender, EventArgs e)
        {
            try
            {


                string firstName = UserFirstNameTXT.Text;
                string lastName = UserLastNameTXT.Text;
                string email = UserEmailTXT.Text;
                string password = UserPasswordTXT.Text;
                string confirmPassword = UserConfirmPassTXT.Text;
                byte[] userPicture = null;
                int selectedCourseId;

                if (UserPicturePB.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        UserPicturePB.Image.Save(ms, UserPicturePB.Image.RawFormat);
                        userPicture = ms.ToArray();
                    }
                }


                if (UserCourseCB.SelectedValue == null || !int.TryParse(UserCourseCB.SelectedValue.ToString(), out selectedCourseId))
                {
                    MessageBox.Show("Invalid course selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))

                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                var createUser = new UserDTO
                {
                    FirstName = firstName,
                    LastName = lastName,
                    CourseId = selectedCourseId,
                    Email = email,
                    Password = password,
                    ConfirmPassword = confirmPassword,
                    Role = "User",
                    UserPicture = userPicture,
                    

                };


                await createAcoountServices.CreateUserAccountAsync(createUser);
                MessageBox.Show("Student Account Created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                FormsControlHelper.ClearControls(this);
                LoadStudentDetails();

            }
            catch (Exception ex)
            {
                throw new Exception($"Error Saving User: {ex.Message}", ex);
            }
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

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            animations.CrudStudentTransition(crudStudentTransition, StudentPanel, sidebarExpanded);
            sidebarExpanded = !sidebarExpanded;
        }

        private void ManageUserBtn_Click_1(object sender, EventArgs e)
        {
            animations.OpenCrudTransition(openCrudTransition, StudentPanel, sidebarExpanded);
            sidebarExpanded = !sidebarExpanded;
        }
    }
}
