using LibraryManagementSystem.Domain.Entities;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem.Presentation.UserForms
{
    public partial class UserMainForm : Form
    {
        public UserEntity CurrentUsers;
        private readonly BooksEntity booksEntity;
        private readonly IBookServices bookServices;
        private readonly IUserServices userServices;

        private System.Windows.Forms.Timer _viewUsersideTransition;
        private Animations _animation;
        private bool _sidebarExpanded;

        public UserMainForm(
                            IBookServices bookServices, 
                            BooksEntity booksEntity,
                            IUserServices userServices)
        {

            InitializeComponent();
            _viewUsersideTransition = new System.Windows.Forms.Timer { Interval = 10 };
            _animation = new Animations();
            _animation.ViewSideTransition(_viewUsersideTransition, UserPanel, _sidebarExpanded);

            this.userServices = userServices;
            this.bookServices = bookServices;
            LoadBookDetails();
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


        private async void LoadBookDetails()
        {
            var bookList = await bookServices.GetAllBooksAsync();
            UserBooksFLP.Controls.Clear();

            foreach (var book in bookList)
            {
                DisplayBooksToUI(book);
            }
        }

        private void DisplayBooksToUI (BooksEntity booksEntity)
        {
            AdminBooksUserControl bookDisplay = new AdminBooksUserControl(booksEntity);
            UserBooksFLP.Controls.Add(bookDisplay);
        } 
        private void UserViewProfileBTN_Click(object sender, EventArgs e)
        {
            _viewUsersideTransition.Start();
        }
    }
}
