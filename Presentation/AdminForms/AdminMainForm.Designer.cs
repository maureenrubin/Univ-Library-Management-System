namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class MainForm_ADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_ADMIN));
            AdminPanel = new Krypton.Toolkit.KryptonPanel();
            label1 = new Label();
            LogoutBTN = new Button();
            AccountNameLBL = new Label();
            AddAdminBTN = new Button();
            AccountPic_PB = new PictureBox();
            pictureBox2 = new PictureBox();
            TransactionButton = new Button();
            AccountsButton = new Button();
            BooksButton = new Button();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            HomeButton = new Button();
            ViewAdminButton = new Button();
            ViewProfileBTN = new Button();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            MainPanel = new Panel();
            ViewBooksButton = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)AdminPanel).BeginInit();
            AdminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountPic_PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // AdminPanel
            // 
            AdminPanel.Controls.Add(label1);
            AdminPanel.Controls.Add(LogoutBTN);
            AdminPanel.Controls.Add(AccountNameLBL);
            AdminPanel.Controls.Add(AddAdminBTN);
            AdminPanel.Controls.Add(AccountPic_PB);
            AdminPanel.Controls.Add(pictureBox2);
            AdminPanel.Dock = DockStyle.Right;
            AdminPanel.Location = new Point(1458, 0);
            AdminPanel.Name = "AdminPanel";
            AdminPanel.Size = new Size(10, 877);
            AdminPanel.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            AdminPanel.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            AdminPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 84);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 5;
            label1.Text = "MY PROFILE";
            // 
            // LogoutBTN
            // 
            LogoutBTN.BackColor = Color.Transparent;
            LogoutBTN.FlatAppearance.BorderSize = 0;
            LogoutBTN.FlatStyle = FlatStyle.Flat;
            LogoutBTN.ForeColor = Color.Maroon;
            LogoutBTN.Image = (Image)resources.GetObject("LogoutBTN.Image");
            LogoutBTN.ImageAlign = ContentAlignment.MiddleRight;
            LogoutBTN.Location = new Point(73, 782);
            LogoutBTN.Name = "LogoutBTN";
            LogoutBTN.Size = new Size(136, 39);
            LogoutBTN.TabIndex = 4;
            LogoutBTN.Text = "Logout Account";
            LogoutBTN.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBTN.UseVisualStyleBackColor = false;
            LogoutBTN.Click += LogoutBTN_Click;
            // 
            // AccountNameLBL
            // 
            AccountNameLBL.AutoSize = true;
            AccountNameLBL.BackColor = Color.Transparent;
            AccountNameLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AccountNameLBL.Location = new Point(82, 325);
            AccountNameLBL.Name = "AccountNameLBL";
            AccountNameLBL.Size = new Size(100, 17);
            AccountNameLBL.TabIndex = 7;
            AccountNameLBL.Text = "Nameeeeeeeee";
            // 
            // AddAdminBTN
            // 
            AddAdminBTN.BackColor = Color.Transparent;
            AddAdminBTN.Cursor = Cursors.Hand;
            AddAdminBTN.FlatAppearance.BorderSize = 0;
            AddAdminBTN.FlatStyle = FlatStyle.Flat;
            AddAdminBTN.Image = (Image)resources.GetObject("AddAdminBTN.Image");
            AddAdminBTN.ImageAlign = ContentAlignment.TopCenter;
            AddAdminBTN.Location = new Point(62, 381);
            AddAdminBTN.Name = "AddAdminBTN";
            AddAdminBTN.Size = new Size(135, 52);
            AddAdminBTN.TabIndex = 9;
            AddAdminBTN.Text = "Add Administrator";
            AddAdminBTN.TextAlign = ContentAlignment.BottomCenter;
            AddAdminBTN.UseVisualStyleBackColor = false;
            AddAdminBTN.Click += AddAdminBTN_Click_1;
            // 
            // AccountPic_PB
            // 
            AccountPic_PB.BackColor = Color.Transparent;
            AccountPic_PB.Location = new Point(27, 118);
            AccountPic_PB.Name = "AccountPic_PB";
            AccountPic_PB.Size = new Size(217, 204);
            AccountPic_PB.SizeMode = PictureBoxSizeMode.Zoom;
            AccountPic_PB.TabIndex = 6;
            AccountPic_PB.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(1028, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // TransactionButton
            // 
            TransactionButton.BackColor = Color.Transparent;
            TransactionButton.Cursor = Cursors.Hand;
            TransactionButton.FlatAppearance.BorderSize = 0;
            TransactionButton.FlatStyle = FlatStyle.Flat;
            TransactionButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            TransactionButton.Image = (Image)resources.GetObject("TransactionButton.Image");
            TransactionButton.ImageAlign = ContentAlignment.MiddleRight;
            TransactionButton.Location = new Point(1187, 12);
            TransactionButton.Name = "TransactionButton";
            TransactionButton.Size = new Size(166, 52);
            TransactionButton.TabIndex = 8;
            TransactionButton.Text = "Review Transactions";
            TransactionButton.TextAlign = ContentAlignment.MiddleLeft;
            TransactionButton.UseVisualStyleBackColor = false;
            TransactionButton.Click += TransactionButton_Click;
            // 
            // AccountsButton
            // 
            AccountsButton.BackColor = Color.Transparent;
            AccountsButton.Cursor = Cursors.Hand;
            AccountsButton.FlatAppearance.BorderSize = 0;
            AccountsButton.FlatStyle = FlatStyle.Flat;
            AccountsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AccountsButton.Image = Properties.Resources.Student_Male;
            AccountsButton.ImageAlign = ContentAlignment.MiddleRight;
            AccountsButton.Location = new Point(813, 11);
            AccountsButton.Name = "AccountsButton";
            AccountsButton.Size = new Size(150, 52);
            AccountsButton.TabIndex = 6;
            AccountsButton.Text = "Manage Students";
            AccountsButton.TextAlign = ContentAlignment.MiddleLeft;
            AccountsButton.UseVisualStyleBackColor = false;
            AccountsButton.Click += AccountsButton_Click;
            // 
            // BooksButton
            // 
            BooksButton.BackColor = Color.Transparent;
            BooksButton.Cursor = Cursors.Hand;
            BooksButton.FlatAppearance.BorderSize = 0;
            BooksButton.FlatStyle = FlatStyle.Flat;
            BooksButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BooksButton.Image = (Image)resources.GetObject("BooksButton.Image");
            BooksButton.ImageAlign = ContentAlignment.MiddleRight;
            BooksButton.Location = new Point(632, 11);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(137, 52);
            BooksButton.TabIndex = 7;
            BooksButton.Text = "Manage Books";
            BooksButton.TextAlign = ContentAlignment.MiddleLeft;
            BooksButton.UseVisualStyleBackColor = false;
            BooksButton.Click += BooksButton_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(HomeButton);
            kryptonPanel2.Controls.Add(ViewAdminButton);
            kryptonPanel2.Controls.Add(ViewProfileBTN);
            kryptonPanel2.Controls.Add(BooksButton);
            kryptonPanel2.Controls.Add(TransactionButton);
            kryptonPanel2.Controls.Add(AccountsButton);
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1465, 70);
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            kryptonPanel2.StateCommon.Color2 = Color.FromArgb(152, 96, 64);
            kryptonPanel2.TabIndex = 3;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.Transparent;
            HomeButton.Cursor = Cursors.Hand;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.ImageAlign = ContentAlignment.TopCenter;
            HomeButton.Location = new Point(158, 11);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(75, 56);
            HomeButton.TabIndex = 10;
            HomeButton.Text = "Home";
            HomeButton.TextAlign = ContentAlignment.BottomCenter;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // ViewAdminButton
            // 
            ViewAdminButton.BackColor = Color.Transparent;
            ViewAdminButton.Cursor = Cursors.Hand;
            ViewAdminButton.FlatAppearance.BorderSize = 0;
            ViewAdminButton.FlatStyle = FlatStyle.Flat;
            ViewAdminButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewAdminButton.Image = (Image)resources.GetObject("ViewAdminButton.Image");
            ViewAdminButton.ImageAlign = ContentAlignment.MiddleRight;
            ViewAdminButton.Location = new Point(994, 12);
            ViewAdminButton.Name = "ViewAdminButton";
            ViewAdminButton.Size = new Size(158, 52);
            ViewAdminButton.TabIndex = 9;
            ViewAdminButton.Text = " View Admin Details";
            ViewAdminButton.TextAlign = ContentAlignment.MiddleLeft;
            ViewAdminButton.UseVisualStyleBackColor = false;
            ViewAdminButton.Click += ViewAdminBtn_Click;
            // 
            // ViewProfileBTN
            // 
            ViewProfileBTN.BackColor = Color.Transparent;
            ViewProfileBTN.Cursor = Cursors.Hand;
            ViewProfileBTN.FlatAppearance.BorderSize = 0;
            ViewProfileBTN.FlatStyle = FlatStyle.Flat;
            ViewProfileBTN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewProfileBTN.Image = (Image)resources.GetObject("ViewProfileBTN.Image");
            ViewProfileBTN.ImageAlign = ContentAlignment.TopCenter;
            ViewProfileBTN.Location = new Point(47, 7);
            ViewProfileBTN.Name = "ViewProfileBTN";
            ViewProfileBTN.Size = new Size(105, 60);
            ViewProfileBTN.TabIndex = 8;
            ViewProfileBTN.Text = "View Profile";
            ViewProfileBTN.TextAlign = ContentAlignment.BottomCenter;
            ViewProfileBTN.UseVisualStyleBackColor = false;
            ViewProfileBTN.Click += ViewProfileBTN_Click;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel3);
            kryptonPanel1.Location = new Point(0, 65);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(19, 895);
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            kryptonPanel1.TabIndex = 5;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Location = new Point(1458, 0);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(10, 887);
            kryptonPanel3.TabIndex = 6;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Dock = DockStyle.Bottom;
            kryptonPanel4.Location = new Point(0, 877);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1468, 10);
            kryptonPanel4.StateCommon.Color1 = Color.FromArgb(152, 96, 64);
            kryptonPanel4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightCyan;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 810);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(657, 247);
            label2.Name = "label2";
            label2.Size = new Size(627, 116);
            label2.TabIndex = 8;
            label2.Text = " UNIVERSITY LIBRARY \r\nMANAGEMENT SYSTEM\r\n";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(ViewBooksButton);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Location = new Point(19, 70);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1446, 810);
            MainPanel.TabIndex = 9;
            // 
            // ViewBooksButton
            // 
            ViewBooksButton.Cursor = Cursors.Hand;
            ViewBooksButton.Location = new Point(827, 440);
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
            ViewBooksButton.StatePressed.Back.Color1 = Color.Honeydew;
            ViewBooksButton.StatePressed.Back.Color2 = Color.Honeydew;
            ViewBooksButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StatePressed.Border.Rounding = 10F;
            ViewBooksButton.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewBooksButton.StatePressed.Content.ShortText.Color2 = Color.White;
            ViewBooksButton.StateTracking.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateTracking.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.TabIndex = 11;
            ViewBooksButton.Values.Text = "View Books Here";
            ViewBooksButton.Click += ViewBooksButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(707, 385);
            label3.Name = "label3";
            label3.Size = new Size(530, 20);
            label3.TabIndex = 9;
            label3.Text = "\"From shelves to screens, it’s all so clear, the library you love is always near.\"";
            // 
            // MainForm_ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1468, 887);
            Controls.Add(AdminPanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel4);
            Controls.Add(MainPanel);
            Controls.Add(kryptonPanel1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm_ADMIN";
            Load += MainForm_ADMIN_Load;
            ((System.ComponentModel.ISupportInitialize)AdminPanel).EndInit();
            AdminPanel.ResumeLayout(false);
            AdminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AccountPic_PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel AdminPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Button LogoutBTN;
        private Label AccountNameLBL;
        private PictureBox AccountPic_PB;
        private PictureBox pictureBox2;
        private Button TransactionButton;
        private Button BooksButton;
        private Button AccountsButton;
        private Label label1;
        private Button AddAdminBTN;
        private Button ViewProfileBTN;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Button ViewAdminButton;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel MainPanel;
        private Label label3;
        private Krypton.Toolkit.KryptonButton ViewBooksButton;
        private Button HomeButton;
    }
}