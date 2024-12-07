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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMainForm));
            UserPanel = new Krypton.Toolkit.KryptonPanel();
            StudentCourseTEXT = new Label();
            StudentNameTEXT = new Label();
            StudentProfilePB = new PictureBox();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            BooksPanel = new Panel();
            pictureBox1 = new PictureBox();
            ViewBooksButton = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label2 = new Label();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            HomeButton = new Button();
            UserTransacButton = new Button();
            BooksButton = new Button();
            UserViewProfileBTN = new Button();
            LogoutButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UserPanel).BeginInit();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentProfilePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            BooksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // UserPanel
            // 
            UserPanel.Controls.Add(LogoutButton);
            UserPanel.Controls.Add(StudentCourseTEXT);
            UserPanel.Controls.Add(StudentNameTEXT);
            UserPanel.Controls.Add(StudentProfilePB);
            UserPanel.Dock = DockStyle.Right;
            UserPanel.Location = new Point(1463, 87);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(10, 786);
            UserPanel.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            UserPanel.TabIndex = 0;
            // 
            // StudentCourseTEXT
            // 
            StudentCourseTEXT.AutoSize = true;
            StudentCourseTEXT.BackColor = Color.Transparent;
            StudentCourseTEXT.Location = new Point(47, 291);
            StudentCourseTEXT.Name = "StudentCourseTEXT";
            StudentCourseTEXT.Size = new Size(96, 15);
            StudentCourseTEXT.TabIndex = 5;
            StudentCourseTEXT.Text = "Student's Course\r\n";
            StudentCourseTEXT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentNameTEXT
            // 
            StudentNameTEXT.AutoSize = true;
            StudentNameTEXT.BackColor = Color.Transparent;
            StudentNameTEXT.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StudentNameTEXT.Location = new Point(88, 274);
            StudentNameTEXT.Name = "StudentNameTEXT";
            StudentNameTEXT.Size = new Size(96, 17);
            StudentNameTEXT.TabIndex = 1;
            StudentNameTEXT.Text = "Student Name";
            // 
            // StudentProfilePB
            // 
            StudentProfilePB.BackColor = Color.Transparent;
            StudentProfilePB.Location = new Point(47, 37);
            StudentProfilePB.Name = "StudentProfilePB";
            StudentProfilePB.Size = new Size(190, 224);
            StudentProfilePB.SizeMode = PictureBoxSizeMode.Zoom;
            StudentProfilePB.TabIndex = 0;
            StudentProfilePB.TabStop = false;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Dock = DockStyle.Left;
            kryptonPanel3.Location = new Point(0, 87);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(24, 786);
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            kryptonPanel3.TabIndex = 4;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Dock = DockStyle.Bottom;
            kryptonPanel4.Location = new Point(24, 863);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1439, 10);
            kryptonPanel4.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            kryptonPanel4.TabIndex = 4;
            // 
            // BooksPanel
            // 
            BooksPanel.BackColor = Color.LightCyan;
            BooksPanel.Controls.Add(pictureBox1);
            BooksPanel.Controls.Add(ViewBooksButton);
            BooksPanel.Controls.Add(label3);
            BooksPanel.Controls.Add(label2);
            BooksPanel.Location = new Point(24, 87);
            BooksPanel.Name = "BooksPanel";
            BooksPanel.Size = new Size(1437, 770);
            BooksPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 770);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // ViewBooksButton
            // 
            ViewBooksButton.Cursor = Cursors.Hand;
            ViewBooksButton.Location = new Point(838, 439);
            ViewBooksButton.Name = "ViewBooksButton";
            ViewBooksButton.Size = new Size(276, 40);
            ViewBooksButton.StateCommon.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateCommon.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StateCommon.Border.Rounding = 10F;
            ViewBooksButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            ViewBooksButton.StateCommon.Content.ShortText.Color2 = Color.Black;
            ViewBooksButton.StateCommon.Content.ShortText.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBooksButton.StateDisabled.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateDisabled.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StateDisabled.Border.Rounding = 10F;
            ViewBooksButton.StateNormal.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateNormal.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateNormal.Border.Color1 = Color.Black;
            ViewBooksButton.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StateNormal.Content.ShortText.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBooksButton.StatePressed.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StatePressed.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StatePressed.Border.Rounding = 10F;
            ViewBooksButton.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewBooksButton.StatePressed.Content.ShortText.Color2 = Color.White;
            ViewBooksButton.StateTracking.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateTracking.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.TabIndex = 18;
            ViewBooksButton.Values.Text = "View Books Here";
            ViewBooksButton.Click += ViewBooksButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(718, 384);
            label3.Name = "label3";
            label3.Size = new Size(530, 20);
            label3.TabIndex = 17;
            label3.Text = "\"From shelves to screens, it’s all so clear, the library you love is always near.\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(668, 246);
            label2.Name = "label2";
            label2.Size = new Size(627, 116);
            label2.TabIndex = 16;
            label2.Text = " UNIVERSITY LIBRARY \r\nMANAGEMENT SYSTEM\r\n";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(HomeButton);
            kryptonPanel2.Controls.Add(UserTransacButton);
            kryptonPanel2.Controls.Add(BooksButton);
            kryptonPanel2.Controls.Add(UserViewProfileBTN);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1473, 87);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(152, 96, 64);
            kryptonPanel2.TabIndex = 6;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.Transparent;
            HomeButton.Cursor = Cursors.Hand;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.ImageAlign = ContentAlignment.TopCenter;
            HomeButton.Location = new Point(46, 12);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(78, 56);
            HomeButton.TabIndex = 21;
            HomeButton.Text = "Home";
            HomeButton.TextAlign = ContentAlignment.BottomCenter;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // UserTransacButton
            // 
            UserTransacButton.BackColor = Color.Transparent;
            UserTransacButton.Cursor = Cursors.Hand;
            UserTransacButton.FlatAppearance.BorderSize = 0;
            UserTransacButton.FlatStyle = FlatStyle.Flat;
            UserTransacButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserTransacButton.Image = (Image)resources.GetObject("UserTransacButton.Image");
            UserTransacButton.ImageAlign = ContentAlignment.TopCenter;
            UserTransacButton.Location = new Point(640, 17);
            UserTransacButton.Name = "UserTransacButton";
            UserTransacButton.Size = new Size(118, 51);
            UserTransacButton.TabIndex = 10;
            UserTransacButton.Text = "My Transactions";
            UserTransacButton.TextAlign = ContentAlignment.BottomCenter;
            UserTransacButton.UseVisualStyleBackColor = false;
            // 
            // BooksButton
            // 
            BooksButton.BackColor = Color.Transparent;
            BooksButton.Cursor = Cursors.Hand;
            BooksButton.FlatAppearance.BorderSize = 0;
            BooksButton.FlatStyle = FlatStyle.Flat;
            BooksButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BooksButton.Image = (Image)resources.GetObject("BooksButton.Image");
            BooksButton.ImageAlign = ContentAlignment.TopCenter;
            BooksButton.Location = new Point(547, 11);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(87, 57);
            BooksButton.TabIndex = 20;
            BooksButton.Text = "View Books";
            BooksButton.TextAlign = ContentAlignment.BottomCenter;
            BooksButton.UseVisualStyleBackColor = false;
            BooksButton.Click += BooksButton_Click;
            // 
            // UserViewProfileBTN
            // 
            UserViewProfileBTN.BackColor = Color.Transparent;
            UserViewProfileBTN.Cursor = Cursors.Hand;
            UserViewProfileBTN.FlatAppearance.BorderSize = 0;
            UserViewProfileBTN.FlatStyle = FlatStyle.Flat;
            UserViewProfileBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserViewProfileBTN.Image = Properties.Resources.Student_Male;
            UserViewProfileBTN.ImageAlign = ContentAlignment.TopCenter;
            UserViewProfileBTN.Location = new Point(130, 11);
            UserViewProfileBTN.Name = "UserViewProfileBTN";
            UserViewProfileBTN.Size = new Size(88, 56);
            UserViewProfileBTN.TabIndex = 9;
            UserViewProfileBTN.Text = "View Profile";
            UserViewProfileBTN.TextAlign = ContentAlignment.BottomCenter;
            UserViewProfileBTN.UseVisualStyleBackColor = false;
            UserViewProfileBTN.Click += UserViewProfileBTN_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.Transparent;
            LogoutButton.FlatAppearance.BorderSize = 0;
            LogoutButton.FlatStyle = FlatStyle.Flat;
            LogoutButton.ForeColor = Color.Black;
            LogoutButton.Image = (Image)resources.GetObject("LogoutButton.Image");
            LogoutButton.ImageAlign = ContentAlignment.MiddleRight;
            LogoutButton.Location = new Point(88, 661);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(136, 39);
            LogoutButton.TabIndex = 6;
            LogoutButton.Text = "Logout Account";
            LogoutButton.TextAlign = ContentAlignment.MiddleLeft;
            LogoutButton.UseVisualStyleBackColor = false;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(152, 96, 64);
            ClientSize = new Size(1473, 873);
            Controls.Add(kryptonPanel4);
            Controls.Add(UserPanel);
            Controls.Add(kryptonPanel3);
            Controls.Add(kryptonPanel2);
            Controls.Add(BooksPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMainForm";
            Load += UserMainForm_Load;
            ((System.ComponentModel.ISupportInitialize)UserPanel).EndInit();
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentProfilePB).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            BooksPanel.ResumeLayout(false);
            BooksPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel UserPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Panel BooksPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Label StudentNameTEXT;
        private PictureBox StudentProfilePB;
        private Button UserViewProfileBTN;
        private Button UserTransacButton;
        private Label StudentCourseTEXT;
        private Button BooksButton;
        private Button HomeButton;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton ViewBooksButton;
        private Label label3;
        private Label label2;
        private Button LogoutButton;
    }
}