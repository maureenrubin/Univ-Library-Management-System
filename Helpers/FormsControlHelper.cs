using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Helpers
{
     public static class FormsControlHelper
    {

        public static void ClearControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();
                } else if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = -1;
                    comboBox.Text = string.Empty;
                } else if (control is PictureBox pictureBox)
                {
                    pictureBox.Image = null;
                } else if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.Value = DateTime.Now;
                } else if (control is FlowLayoutPanel flowLayoutPanel) 
                {
                    flowLayoutPanel.Controls.Clear();
                
                } else if (control.HasChildren)
                {
                    ClearControls(control);
                }
            }
        }
    }
}
