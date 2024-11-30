using LibraryManagementSystem.Domain.DTO;
using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Presentation.UserControls;
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
        public static void AddUserContromToPanel(UserEntity userList,
                                                 FlowLayoutPanel itPanel,
                                                 FlowLayoutPanel swPanel,
                                                 FlowLayoutPanel bePanel,
                                                 FlowLayoutPanel baPanel)
        {
            if (userList == null) return;

            var userDisplay = new UserDetailsUC(userList);
            
            switch (userList.CourseId)
            {
                case 1:
                    itPanel.Controls.Add(userDisplay);
                    break;
                case 2:
                    swPanel.Controls.Add(userDisplay);
                    break;
                case 3:
                    bePanel.Controls.Add(userDisplay);
                    break;
                case 4:
                    baPanel.Controls.Add(userDisplay);
                    break;
                default:
                    Console.WriteLine($"Unhandled CourseId:  {userList.CourseId}");
                    
                    break;

            }
            
        }
       
    }
}
