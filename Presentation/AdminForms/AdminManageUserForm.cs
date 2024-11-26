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

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class AdminManageUserForm : Form
    {
        private System.Windows.Forms.Timer _crudStudentTransition;
        private System.Windows.Forms.Timer _sideUserTransition;
        private Animations _animations;
        private bool _sidebarExpanded;
        private byte[] UserPicture;
        private readonly UserEntity _addedUser;


        public AdminManageUserForm()
        {
            InitializeComponent();
            _crudStudentTransition = new System.Windows.Forms.Timer { Interval = 10 };
            _sideUserTransition = new System.Windows.Forms.Timer { Interval = 10};
            _animations = new Animations();
            _animations.CrudBooksTransition(_crudStudentTransition, StudentPanel, _sidebarExpanded);
            _animations.SideBooksTransition(_crudStudentTransition, StudentPanel, _sidebarExpanded);

            LoadStudentDetails();

        }

        private void ManageUserBTN_Click(object sender, EventArgs e)
        {
            _sideUserTransition.Start();
        }

        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            _crudStudentTransition.Start();
        }

        private void ClearForm()
        {
            UserFirstNameTXT.Clear();
            UserLastNameTXT.Clear();
            UserEmailTXT.Clear();
            UserPasswordTXT.Clear();
        }

       
        
        private void SaveUserBtn_Click(object sender, EventArgs e)
        {



        }
      
        
        
        private void LoadStudentDetails()
        {

        }
    }
}
