using LibraryManagementSystem.Helpers.Animation;
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

namespace LibraryManagementSystem.Presentation.UserForms
{
    public partial class UserHomeForm : Form
    {
        private readonly Animations animations;

        public UserHomeForm(Animations animations)
        {
            InitializeComponent();
            this.animations = animations;
        }

        private void ViewBooksButton_Click(object sender, EventArgs e)
        {
            var userBooksForm = Program.ServiceProvider.GetRequiredService<UserBookForm>();
            animations.LoadForm(HomePanel, userBooksForm);
        }
    }
}
