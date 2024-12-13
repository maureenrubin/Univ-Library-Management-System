using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.UserControls;
using LibraryManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.Helpers
{
    public static class UserControlHelper
    {
        public static void AddUserControlToPanel(UserDetailsUC userDisplay,
                                                 FlowLayoutPanel itPanel,
                                                 FlowLayoutPanel swPanel,
                                                 FlowLayoutPanel bePanel,
                                                 FlowLayoutPanel baPanel)
        {

            if (userDisplay.userEntity.CourseId == 1) // Assuming CourseId is a valid property
            {
                itPanel.Controls.Add(userDisplay);
            }
            else if (userDisplay.userEntity.CourseId == 2)
            {
                swPanel.Controls.Add(userDisplay);
            }
            else if (userDisplay.userEntity.CourseId == 3)
            {
                bePanel.Controls.Add(userDisplay);
            }
            else if (userDisplay.userEntity.CourseId == 4)
            {
                baPanel.Controls.Add(userDisplay);
            }
            else
            {
                Console.WriteLine($"Unhandled CourseId: {userDisplay.userEntity.CourseId}");
            }



        }
       
    }
}
