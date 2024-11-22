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
            s = new Krypton.Toolkit.KryptonPanel();
            label1 = new Label();
            AccountNameLBL = new Label();
            AccountPic_PB = new PictureBox();
            pictureBox2 = new PictureBox();
            AddAdminBTN = new Button();
            TransactionButton = new Button();
            LogoutBTN = new Button();
            AccountsButton = new Button();
            BooksButton = new Button();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            pictureBox1 = new PictureBox();
            MainPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)s).BeginInit();
            s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AccountPic_PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // s
            // 
            s.Controls.Add(label1);
            s.Controls.Add(AccountNameLBL);
            s.Controls.Add(AccountPic_PB);
            s.Controls.Add(pictureBox2);
            s.Dock = DockStyle.Left;
            s.Location = new Point(0, 0);
            s.Name = "s";
            s.Size = new Size(310, 887);
            s.StateCommon.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            s.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(257, 50);
            label1.TabIndex = 5;
            label1.Text = "   UNIVERSITY LIBRARY\r\n MANAGEMENT SYSTEM";
            // 
            // AccountNameLBL
            // 
            AccountNameLBL.AutoSize = true;
            AccountNameLBL.BackColor = Color.Transparent;
            AccountNameLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            AccountNameLBL.Location = new Point(104, 342);
            AccountNameLBL.Name = "AccountNameLBL";
            AccountNameLBL.Size = new Size(98, 16);
            AccountNameLBL.TabIndex = 7;
            AccountNameLBL.Text = "Nameeeeeeeee";
            // 
            // AccountPic_PB
            // 
            AccountPic_PB.Location = new Point(44, 122);
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
            // AddAdminBTN
            // 
            AddAdminBTN.BackColor = Color.Transparent;
            AddAdminBTN.Cursor = Cursors.Hand;
            AddAdminBTN.FlatAppearance.BorderSize = 0;
            AddAdminBTN.FlatStyle = FlatStyle.Flat;
            AddAdminBTN.Image = (Image)resources.GetObject("AddAdminBTN.Image");
            AddAdminBTN.ImageAlign = ContentAlignment.MiddleRight;
            AddAdminBTN.Location = new Point(537, 49);
            AddAdminBTN.Name = "AddAdminBTN";
            AddAdminBTN.Size = new Size(140, 39);
            AddAdminBTN.TabIndex = 9;
            AddAdminBTN.Text = "ADD ADMIN";
            AddAdminBTN.TextAlign = ContentAlignment.MiddleLeft;
            AddAdminBTN.UseVisualStyleBackColor = false;
            AddAdminBTN.Click += AddAdminBTN_Click_1;
            // 
            // TransactionButton
            // 
            TransactionButton.BackColor = Color.Transparent;
            TransactionButton.Cursor = Cursors.Hand;
            TransactionButton.FlatAppearance.BorderSize = 0;
            TransactionButton.FlatStyle = FlatStyle.Flat;
            TransactionButton.Image = Properties.Resources.Ledger;
            TransactionButton.ImageAlign = ContentAlignment.MiddleRight;
            TransactionButton.Location = new Point(374, 49);
            TransactionButton.Name = "TransactionButton";
            TransactionButton.Size = new Size(136, 39);
            TransactionButton.TabIndex = 8;
            TransactionButton.Text = "TRANSACTIONS";
            TransactionButton.TextAlign = ContentAlignment.MiddleLeft;
            TransactionButton.UseVisualStyleBackColor = false;
            TransactionButton.Click += TransactionButton_Click;
            // 
            // LogoutBTN
            // 
            LogoutBTN.BackColor = Color.Transparent;
            LogoutBTN.FlatAppearance.BorderSize = 0;
            LogoutBTN.FlatStyle = FlatStyle.Flat;
            LogoutBTN.ForeColor = Color.Red;
            LogoutBTN.Image = (Image)resources.GetObject("LogoutBTN.Image");
            LogoutBTN.ImageAlign = ContentAlignment.MiddleRight;
            LogoutBTN.Location = new Point(1039, 49);
            LogoutBTN.Name = "LogoutBTN";
            LogoutBTN.Size = new Size(107, 39);
            LogoutBTN.TabIndex = 4;
            LogoutBTN.Text = "LOG OUT";
            LogoutBTN.TextAlign = ContentAlignment.MiddleLeft;
            LogoutBTN.UseVisualStyleBackColor = false;
            LogoutBTN.Click += LogoutBTN_Click;
            // 
            // AccountsButton
            // 
            AccountsButton.BackColor = Color.Transparent;
            AccountsButton.Cursor = Cursors.Hand;
            AccountsButton.FlatAppearance.BorderSize = 0;
            AccountsButton.FlatStyle = FlatStyle.Flat;
            AccountsButton.Image = Properties.Resources.Community;
            AccountsButton.ImageAlign = ContentAlignment.MiddleRight;
            AccountsButton.Location = new Point(232, 49);
            AccountsButton.Name = "AccountsButton";
            AccountsButton.Size = new Size(136, 39);
            AccountsButton.TabIndex = 6;
            AccountsButton.Text = "ACCOUNTS";
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
            BooksButton.Image = Properties.Resources.Books;
            BooksButton.ImageAlign = ContentAlignment.MiddleRight;
            BooksButton.Location = new Point(97, 49);
            BooksButton.Name = "BooksButton";
            BooksButton.Size = new Size(129, 39);
            BooksButton.TabIndex = 7;
            BooksButton.Text = "BOOKS";
            BooksButton.TextAlign = ContentAlignment.MiddleLeft;
            BooksButton.UseVisualStyleBackColor = false;
            BooksButton.Click += BooksButton_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(AddAdminBTN);
            kryptonPanel2.Controls.Add(BooksButton);
            kryptonPanel2.Controls.Add(TransactionButton);
            kryptonPanel2.Controls.Add(LogoutBTN);
            kryptonPanel2.Controls.Add(AccountsButton);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(310, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1158, 101);
            kryptonPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(932, 639);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Location = new Point(316, 119);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1140, 756);
            MainPanel.TabIndex = 4;
            // 
            // MainForm_ADMIN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1468, 887);
            Controls.Add(MainPanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(s);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm_ADMIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm_ADMIN";
            Load += MainForm_ADMIN_Load;
            ((System.ComponentModel.ISupportInitialize)s).EndInit();
            s.ResumeLayout(false);
            s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AccountPic_PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel s;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Button LogoutBTN;
        private Label AccountNameLBL;
        private PictureBox AccountPic_PB;
        private PictureBox pictureBox2;
        private Button TransactionButton;
        private Button BooksButton;
        private Button AccountsButton;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel MainPanel;
        private Button AddAdminBTN;
    }
}