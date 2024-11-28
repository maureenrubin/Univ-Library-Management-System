namespace LibraryManagementSystem.Presentation.UserForms
{
    partial class UserMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Dock = DockStyle.Right;
            kryptonPanel1.Location = new Point(1463, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(10, 873);
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Dock = DockStyle.Left;
            kryptonPanel3.Location = new Point(0, 0);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(10, 863);
            kryptonPanel3.TabIndex = 4;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Dock = DockStyle.Bottom;
            kryptonPanel4.Location = new Point(0, 863);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1463, 10);
            kryptonPanel4.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Location = new Point(16, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(1133, 814);
            panel1.TabIndex = 5;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1473, 873);
            Controls.Add(panel1);
            Controls.Add(kryptonPanel3);
            Controls.Add(kryptonPanel4);
            Controls.Add(kryptonPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMainForm";
            Load += UserMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Panel panel1;
    }
}