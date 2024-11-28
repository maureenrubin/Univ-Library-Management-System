using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.Animation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.UserForms
{
    public partial class UserMainForm : Form
    {
        public UserEntity CurrentUser;

        private System.Windows.Forms.Timer _viewUsersideTransition;
        private Animations _animation;
        private bool _sidebarExpanded;

        public UserMainForm()
        {
            InitializeComponent();
            _viewUsersideTransition = new System.Windows.Forms.Timer { Interval = 10 };
            _animation = new Animations();
            _animation.ViewSideTransition(_viewUsersideTransition, UserPanel, _sidebarExpanded);
        }

        private void UserMainForm_Load(object sender, EventArgs e)
        {
            if (CurrentUser != null)
            {
                StudentNameTEXT.Text = $"{CurrentUser.FirstName} {CurrentUser.LastName}";
                StudentCourseTEXT.Text = $"{CurrentUser.Course}";

                if (CurrentUser.UserPicture != null && CurrentUser.UserPicture.Length > 0)
                {
                    using (var ms = new MemoryStream(CurrentUser.UserPicture))
                    {
                        StudentProfilePB.Image = Image.FromStream(ms);
                    }
                }

            }
        }

        private void UserViewProfileBTN_Click(object sender, EventArgs e)
        {
            _viewUsersideTransition.Start();
        }
    }
}
