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

namespace LibraryManagementSystem.Presentation.AdminForms
{
    public partial class MainForm_ADMIN : Form
    {
        public AdminEntity CurrentAdmin;

        public MainForm_ADMIN()
        {
            InitializeComponent();
            MainPanel.Visible = true;
        }
      
        
        private void MainForm_ADMIN_Load(object sender, EventArgs e)
        {
           if(CurrentAdmin != null)
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
            LoadForm(new AdminBooksForm());
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminAccountForm());
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            LoadForm(new AdminTransactionForm());
        }

        private void LogoutBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = Program.ServiceProvider.GetRequiredService<LoginForm>();

        }


        private void AddAdminBTN_Click_1(object sender, EventArgs e)
        {
            var signInForm = Program.ServiceProvider.GetRequiredService<SignInForm>();
            signInForm.Show();
        }

       
    }
}
