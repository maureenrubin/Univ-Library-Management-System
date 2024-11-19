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
    public partial class MainForm_ADMIN : Form
    {
        public MainForm_ADMIN()
        {
            InitializeComponent();
            MainPanel.Visible = true;
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
            
        }
    }
}
