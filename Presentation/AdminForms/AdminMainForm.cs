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

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class MainForm_ADMIN : Form
    {
        public AdminEntity CurrentAdmin;

        private System.Windows.Forms.Timer viewsideTransition;
        private Animations animation;
        private bool sidebarExpanded;

        public MainForm_ADMIN(IBookServices bookServices)
        {

            InitializeComponent();

            this.viewsideTransition = new System.Windows.Forms.Timer { Interval = 10 };
            this.animation = new Animations();
            this.animation.ViewSideTransition(viewsideTransition, AdminPanel, sidebarExpanded);
            MainPanel.Visible = true;

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


        public void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.Clear();

            Form f = (Form)Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            var adminBooksForm = Program.ServiceProvider.GetRequiredService<AdminBooksForm>();
            LoadForm(adminBooksForm);
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            var adminManageUserForm = Program.ServiceProvider.GetRequiredService<AdminManageUserForm>();
            LoadForm(adminManageUserForm);
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminTransactionForm());
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();
            loginForm.Show();

        }


        private void AddAdminBTN_Click_1(object sender, EventArgs e)
        {
            var signInForm = Program.ServiceProvider.GetRequiredService<CreateAdminAccForm>();
            signInForm.Show();
        }

        private void ViewProfileBTN_Click(object sender, EventArgs e)
        {
            viewsideTransition.Start();
        }

        private void ViewAdminBtn_Click(object sender, EventArgs e)
        {
            var manageAdminsForm = Program.ServiceProvider.GetRequiredService<ManageAdminsForm>();
            LoadForm(manageAdminsForm);
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            var adminBooksForm = Program.ServiceProvider.GetRequiredService<AdminBooksForm>();
            LoadForm(adminBooksForm);
        }
    }
}
