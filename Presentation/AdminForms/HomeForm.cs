using LibraryManagementSystem.Helpers.Animation;
using LibraryManagementSystem.Presentation.UserForms;
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
    public partial class HomeForm : Form
    {
  
        private readonly Animations animations;

        public HomeForm(
                            Animations animations)
        {
            InitializeComponent();
            
            this.animations = animations;
        
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            var adminBooksForm = Program.ServiceProvider.GetRequiredService<AdminBooksForm>();
            animations.LoadForm(HomePanel, adminBooksForm);
        }
    }
}
