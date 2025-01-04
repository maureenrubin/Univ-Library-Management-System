using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Helpers;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Presentation.UserControls;
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Domain.Entities;

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
        private bool IsUpdateMode = false;
        private int UserIdToUpdate;

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

            LoadCources();
            LoadStudentDetails();


        }


        private async void LoadStudentDetails()
        {
            try
            {
                var userList = await userServices.GetAllUsersAsync();
                FormsControlHelper.ClearControls(this);

                foreach (var student in userList)
                {
                    var userDisplay = new UserDetailsUC(student, userServices);
                    userDisplay.StudentClicked += UserDetailsUC_StudentCliked;
                    UserControlHelper.AddUserControlToPanel(userDisplay, ITStudentFLP, SWStudentFLP, BEStudentFLP, BAStudentFLP);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserDetailsUC_StudentCliked(object? sender, UserEntity userEntity)
        {
            animations.CrudStudentTransition(crudStudentTransition, StudentPanel, sidebarExpanded);
            animations.OpenCrudTransition(openCrudTransition, StudentPanel);
            LoadtoUpdateStudentDetails(userEntity);
        }

        private async void LoadtoUpdateStudentDetails(UserEntity userEntity)
        {
            IsUpdateMode = true;
            UserIdToUpdate = userEntity.UserId;

            UserFirstNameTXT.Text = userEntity.FirstName;
            UserLastNameTXT.Text = userEntity.LastName;
            UserEmailTXT.Text = userEntity.Email;

            if (userEntity.UserPicture != null && userEntity.UserPicture.Length > 0)
            {
                using (var ms = new MemoryStream(userEntity.UserPicture))
                {
                    UserPicturePB.Image = Image.FromStream(ms);
                }
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
                MessageBox.Show($"Error Loading Course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int selectedCourseId;

                if (UserCourseCB.SelectedValue == null || !int.TryParse(UserCourseCB.SelectedValue.ToString(), out selectedCourseId))
                {
                    MessageBox.Show("Invalid course selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                                   string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) ||
                                   string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (IsUpdateMode && password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                byte[] userPicture = null;
                if (UserPicturePB.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        UserPicturePB.Image.Save(ms, UserPicturePB.Image.RawFormat);
                        userPicture = ms.ToArray();
                    }
                }



                var newUser = new UserDTO
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


                if (IsUpdateMode)
                {
                    newUser.UserId = UserIdToUpdate;
                    await userServices.UpdateUserAsync(newUser);
                    MessageBox.Show("Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                }
                else
                {
                    PasswordHelper.GeneratePasswordHashAndSalt(newUser.Password);
                    await createAcoountServices.CreateUserAccountAsync(newUser);
                    MessageBox.Show("Student account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FormsControlHelper.ClearControls(this);
                LoadStudentDetails();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Saving User: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BrowseImageBtn_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
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
            FormsControlHelper.ClearControls(crudPanel);

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            animations.CrudStudentTransition(crudStudentTransition, StudentPanel, sidebarExpanded);
        }


        private void ManageStudentBtn_Click(object sender, EventArgs e)
        {
            animations.OpenCrudTransition(openCrudTransition, StudentPanel);

        }

        private async void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if (!IsUpdateMode || UserIdToUpdate == 0)
            {
                MessageBox.Show("Please select a student to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmRemove = MessageBox.Show("Are you sure you want to remove this student?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (confirmRemove == DialogResult.Yes)
            {
                try
                {
                    var remove = await userServices.RemoveUserAsync(UserIdToUpdate);

                    if (remove)
                    {
                        MessageBox.Show("Student removed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormsControlHelper.ClearControls(crudPanel);
                        LoadStudentDetails();
                    }
                    else
                    {
                        MessageBox.Show("Failed to remove the student.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Removing Student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    
        
    }
}
