using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Presentation.AdminForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem.Presentation.UserForms
{
    public partial class UserMainForm : Form
    {
        public UserEntity CurrentUsers;
        private readonly Animations animations;

        private System.Windows.Forms.Timer viewUserProfile;
        private bool sidebarExpanded = false;

        public UserMainForm(Animations animations)
        {

            InitializeComponent();

            this.animations = animations;
            this.viewUserProfile = new System.Windows.Forms.Timer { Interval = 10 };


        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUsers != null)
            {
                StudentCourseTEXT.Text = $"{CurrentUsers.CourseName}";
                StudentNameTEXT.Text = $"{CurrentUsers.FirstName} {CurrentUsers.LastName}";


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
            animations.ViewSideProfile(viewUserProfile, UserPanel, 10, 283);
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

      
    }
}
