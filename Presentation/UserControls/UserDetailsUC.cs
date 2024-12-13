
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Presentation.UserControls
{
    public partial class UserDetailsUC : UserControl
    {
        
        public UserEntity userEntity;
        private readonly IUserServices userServices;
        
        public UserDetailsUC(UserEntity userEntity, 
                             IUserServices userServices)
        {
            InitializeComponent();
            this.userServices = userServices;
            this.userEntity = userEntity;
            LoadStudentDetails();
        }

        private async void LoadStudentDetails()
        {
            try
            {


                var user = await userServices.GetUserByIdAsync(userEntity.UserId);

                LblFirstname.Text = userEntity.FirstName;
                LblLastname.Text = userEntity.LastName;
                LblCourse.Text = userEntity.Course.Name ?? "No Course";
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
            catch (Exception ex)
            {
               throw new Exception ($"Failed to load user details. {ex.Message}", ex);
            }
        }

        
    }
}
