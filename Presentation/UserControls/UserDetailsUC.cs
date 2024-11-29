
using LibraryManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.UserControls
{
    public partial class UserDetailsUC : UserControl
    {
        private readonly UserEntity userEntity;
        
        public UserDetailsUC(UserEntity userEntity)
        {
            InitializeComponent();
            this.userEntity = userEntity;
            LoadStudentDetails();
        }

        private void LoadStudentDetails()
        {
            LblFirstname.Text = userEntity.FirstName;
            LblLastname.Text = userEntity.LastName;
           // LblCourse.Text = userEntity.Course;
            LblCreatedAt.Text = userEntity.CreatedAt.ToShortDateString();
            StudentID.Text = userEntity.UserId.ToString();

            if (userEntity.UserPicture != null)
            {
                using (MemoryStream ms = new MemoryStream(userEntity.UserPicture))
                {
                    StudentProfilePB.Image = Image.FromStream(ms);
                }
            }

        }
    }
}
