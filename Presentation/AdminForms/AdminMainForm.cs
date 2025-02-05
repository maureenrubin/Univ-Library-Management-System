using LibraryManagementSystem.Domain.Entities;
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
using LibraryManagementSystem.Repositories;
using LibraryManagementSystem.Repositories.Interfaces;
using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Presentation.UserForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class MainForm_ADMIN : Form
    {
        public AdminEntity CurrentAdmin;

        private System.Windows.Forms.Timer viewsideTransition;
        private readonly Animations animation;
        private bool sidebarExpanded;
        

        public MainForm_ADMIN(IBookServices bookServices, Animations animations)
        {

            InitializeComponent();

            this.viewsideTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.animation = animations;
            sidebarExpanded = false;
            
        }


        private void MainForm_ADMIN_Load(object sender, EventArgs e)
        {
            if (CurrentAdmin != null)
            {
                AccountNameLBL.Text = $"{CurrentAdmin.FirstName} {CurrentAdmin.LastName}";

                if (CurrentAdmin.AdminPicture != null && CurrentAdmin.AdminPicture.Length > 0)
                {
                    using (var ms = new MemoryStream(CurrentAdmin.AdminPicture))
                    {
                        AccountPic_PB.Image = Image.FromStream(ms);
                    }
                }

            }

        }


        private void BooksButton_Click(object sender, EventArgs e)
        {
            var adminBooksForm = Program.ServiceProvider.GetRequiredService<AdminBooksForm>();
            animation.LoadForm(MainPanel,adminBooksForm);
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            var adminManageUserForm = Program.ServiceProvider.GetRequiredService<AdminManageUserForm>();
            animation.LoadForm(MainPanel, adminManageUserForm);
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            animation.LoadForm(MainPanel, new AdminTransactionForm());
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();

            this.Close();

        }


        private void AddAdminBTN_Click_1(object sender, EventArgs e)
        {
            var signInForm = Program.ServiceProvider.GetRequiredService<CreateAdminAccForm>();
            signInForm.Show();
        }

        private void ViewProfileBTN_Click(object sender, EventArgs e)
        {
            viewsideTransition.Interval = 20;
            animation.TransitionPanelWidth(viewsideTransition, AdminPanel, 10, 283, sidebarExpanded);
            viewsideTransition.Start();
        }

        private void ViewAdminBtn_Click(object sender, EventArgs e)
        {
            var manageAdminsForm = Program.ServiceProvider.GetRequiredService<ManageAdminsForm>();
            animation.LoadForm(MainPanel, manageAdminsForm);
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            var adminBooksForm = Program.ServiceProvider.GetRequiredService<AdminBooksForm>();
            animation.LoadForm(MainPanel, adminBooksForm);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            var homeForm = Program.ServiceProvider.GetRequiredService<AdminHomeForm>();
            animation.LoadForm(MainPanel, homeForm);
        }
    }
}
