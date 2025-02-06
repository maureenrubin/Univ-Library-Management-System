using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Presentation.AdminForms;
using LibraryManagementSystem.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem.Presentation.UserForms
{
    public partial class UserMainForm : Form
    {
        public UserEntity CurrentUsers;
        private readonly Animations animations;
        private readonly IUserServices userServices;

        private System.Windows.Forms.Timer viewUserProfile;
        private bool sidebarExpanded = false;

        public UserMainForm(Animations animations, IUserServices userServices)
        {

            InitializeComponent();

            this.animations = animations;
            this.viewUserProfile = new System.Windows.Forms.Timer { Interval = 10 };
            this.userServices = userServices;
        }

        private async void UserMainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUsers == null)
            {
                // Retrieve the logged-in user's data using their ID
                CurrentUsers = await userServices.GetUserByIdAsync(BookUC.LoggedInUserId);
            }

            if (CurrentUsers != null)
            {

                StudentNameTEXT.Text = $"{CurrentUsers.FirstName} {CurrentUsers.LastName}";

                if (CurrentUsers.Course != null)
                {
                    StudentCourseTEXT.Text = CurrentUsers.Course.Name;
                }

                if (CurrentUsers.UserPicture != null && CurrentUsers.UserPicture.Length > 0)
                {
                    using (var ms = new MemoryStream(CurrentUsers.UserPicture))
                    {
                        StudentProfilePB.Image = Image.FromStream(ms);
                    }
                }

            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var userHomeForm = Program.ServiceProvider.GetRequiredService<UserHomeForm>();
            animations.LoadForm(BooksPanel, userHomeForm);
        }

        private void UserViewProfileBTN_Click(object sender, EventArgs e)
        {
            viewUserProfile.Interval = 20;
            animations.TransitionPanelWidth(viewUserProfile, UserPanel, 10, 283, sidebarExpanded);
            viewUserProfile.Start();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            var userBooksForm = Program.ServiceProvider.GetRequiredService<UserBookForm>();
            animations.LoadForm(BooksPanel, userBooksForm);
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            var userBooksForm = Program.ServiceProvider.GetRequiredService<UserBookForm>();
            animations.LoadForm(BooksPanel, userBooksForm);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();

            this.Close();
        }
    }
}
