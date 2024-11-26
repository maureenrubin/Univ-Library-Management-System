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
            ViewAdminBtn = new Button();
            ViewProfileBTN = new Button();
            MainPanel = new Panel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
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
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
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
            AdminPanel.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            AdminPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(64, 73);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 5;
            label1.Text = "VIEW PROFILE";
            // 
            // LogoutBTN
            // 
            LogoutBTN.BackColor = Color.Transparent;
            LogoutBTN.FlatAppearance.BorderSize = 0;
            LogoutBTN.FlatStyle = FlatStyle.Flat;
            LogoutBTN.ForeColor = Color.Red;
            LogoutBTN.Image = (Image)resources.GetObject("LogoutBTN.Image");
            LogoutBTN.ImageAlign = ContentAlignment.MiddleRight;
            LogoutBTN.Location = new Point(82, 783);
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
            AccountNameLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AccountNameLBL.Location = new Point(82, 325);
            AccountNameLBL.Name = "AccountNameLBL";
            AccountNameLBL.Size = new Size(98, 16);
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
            AddAdminBTN.Location = new Point(64, 369);
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
            AccountPic_PB.Location = new Point(27, 107);
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
            TransactionButton.Image = (Image)resources.GetObject("TransactionButton.Image");
            TransactionButton.ImageAlign = ContentAlignment.MiddleRight;
            TransactionButton.Location = new Point(681, 12);
            TransactionButton.Name = "TransactionButton";
            TransactionButton.Size = new Size(156, 52);
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
            AccountsButton.Image = (Image)resources.GetObject("AccountsButton.Image");
            AccountsButton.ImageAlign = ContentAlignment.MiddleRight;
            AccountsButton.Location = new Point(532, 12);
            AccountsButton.Name = "AccountsButton";
            AccountsButton.Size = new Size(143, 52);
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
            BooksButton.Image = (Image)resources.GetObject("BooksButton.Image");
            BooksButton.ImageAlign = ContentAlignment.MiddleRight;
            BooksButton.Location = new Point(376, 12);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(150, 52);
            BooksButton.TabIndex = 7;
            BooksButton.Text = "Manage Books";
            BooksButton.TextAlign = ContentAlignment.MiddleLeft;
            BooksButton.UseVisualStyleBackColor = false;
            BooksButton.Click += BooksButton_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(ViewAdminBtn);
            kryptonPanel2.Controls.Add(ViewProfileBTN);
            kryptonPanel2.Controls.Add(BooksButton);
            kryptonPanel2.Controls.Add(TransactionButton);
            kryptonPanel2.Controls.Add(AccountsButton);
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1465, 70);
            kryptonPanel2.TabIndex = 3;
            // 
            // ViewAdminBtn
            // 
            ViewAdminBtn.BackColor = Color.Transparent;
            ViewAdminBtn.Cursor = Cursors.Hand;
            ViewAdminBtn.FlatAppearance.BorderSize = 0;
            ViewAdminBtn.FlatStyle = FlatStyle.Flat;
            ViewAdminBtn.Image = (Image)resources.GetObject("ViewAdminBtn.Image");
            ViewAdminBtn.ImageAlign = ContentAlignment.MiddleRight;
            ViewAdminBtn.Location = new Point(843, 12);
            ViewAdminBtn.Name = "ViewAdminBtn";
            ViewAdminBtn.Size = new Size(143, 52);
            ViewAdminBtn.TabIndex = 9;
            ViewAdminBtn.Text = " View Admin Details";
            ViewAdminBtn.TextAlign = ContentAlignment.MiddleLeft;
            ViewAdminBtn.UseVisualStyleBackColor = false;
            // 
            // ViewProfileBTN
            // 
            ViewProfileBTN.BackColor = Color.Transparent;
            ViewProfileBTN.Cursor = Cursors.Hand;
            ViewProfileBTN.FlatAppearance.BorderSize = 0;
            ViewProfileBTN.FlatStyle = FlatStyle.Flat;
            ViewProfileBTN.Image = (Image)resources.GetObject("ViewProfileBTN.Image");
            ViewProfileBTN.ImageAlign = ContentAlignment.TopCenter;
            ViewProfileBTN.Location = new Point(49, 12);
            ViewProfileBTN.Name = "ViewProfileBTN";
            ViewProfileBTN.Size = new Size(88, 52);
            ViewProfileBTN.TabIndex = 8;
            ViewProfileBTN.Text = "View Profile";
            ViewProfileBTN.TextAlign = ContentAlignment.BottomCenter;
            ViewProfileBTN.UseVisualStyleBackColor = false;
            ViewProfileBTN.Click += ViewProfileBTN_Click;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(16, 76);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1436, 795);
            MainPanel.TabIndex = 4;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel3);
            kryptonPanel1.Location = new Point(0, 65);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(10, 895);
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
            kryptonPanel4.Controls.Add(kryptonPanel5);
            kryptonPanel4.Dock = DockStyle.Bottom;
            kryptonPanel4.Location = new Point(0, 877);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1468, 10);
            kryptonPanel4.TabIndex = 7;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Location = new Point(1458, 0);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.Size = new Size(10, 887);
            kryptonPanel5.TabIndex = 6;
            // 
            // MainForm_ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1468, 887);
            Controls.Add(AdminPanel);
            Controls.Add(kryptonPanel4);
            Controls.Add(MainPanel);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonPanel2);
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
            kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
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
        private Panel MainPanel;
        private Button AddAdminBTN;
        private Button ViewProfileBTN;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Button ViewAdminBtn;
    }
}