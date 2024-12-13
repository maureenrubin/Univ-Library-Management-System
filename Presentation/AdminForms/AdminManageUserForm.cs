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
                    UserControlHelper.AddUserControlToPanel(userDisplay, ITStudentFLP, SWStudentFLP, BEStudentFLP, BAStudentFLP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Loading Students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                if (password != confirmPassword)
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
                MessageBox.Show("Student account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            FormsControlHelper.ClearControls(this);

        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            animations.CrudStudentTransition(crudStudentTransition, StudentPanel, sidebarExpanded);
            sidebarExpanded = !sidebarExpanded;
        }


        private void ManageStudentBtn_Click(object sender, EventArgs e)
        {
            animations.OpenCrudTransition(openCrudTransition, StudentPanel);
         
        }
    }
}
