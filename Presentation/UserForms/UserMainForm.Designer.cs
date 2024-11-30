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
            label1 = new Label();
            UserActivityLogs = new Panel();
            StudentCourseTEXT = new Label();
            StudentNameTEXT = new Label();
            StudentProfilePB = new PictureBox();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            BooksPanel = new Panel();
            UserBooksFLP = new FlowLayoutPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            button1 = new Button();
            SearchTXT = new Krypton.Toolkit.KryptonTextBox();
            panel2 = new Panel();
            UserTransactionBTN = new Button();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            UserViewProfileBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)UserPanel).BeginInit();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentProfilePB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            BooksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            SuspendLayout();
            // 
            // UserPanel
            // 
            UserPanel.Controls.Add(label1);
            UserPanel.Controls.Add(UserActivityLogs);
            UserPanel.Controls.Add(StudentCourseTEXT);
            UserPanel.Controls.Add(StudentNameTEXT);
            UserPanel.Controls.Add(StudentProfilePB);
            UserPanel.Dock = DockStyle.Right;
            UserPanel.Location = new Point(1188, 82);
            UserPanel.Name = "UserPanel";
            UserPanel.Size = new Size(285, 781);
            UserPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(88, 359);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 4;
            label1.Text = "Student Activity Log";
            // 
            // UserActivityLogs
            // 
            UserActivityLogs.Location = new Point(26, 377);
            UserActivityLogs.Name = "UserActivityLogs";
            UserActivityLogs.Size = new Size(237, 379);
            UserActivityLogs.TabIndex = 3;
            // 
            // StudentCourseTEXT
            // 
            StudentCourseTEXT.AutoSize = true;
            StudentCourseTEXT.BackColor = Color.Transparent;
            StudentCourseTEXT.Location = new Point(51, 282);
            StudentCourseTEXT.Name = "StudentCourseTEXT";
            StudentCourseTEXT.Size = new Size(96, 15);
            StudentCourseTEXT.TabIndex = 2;
            StudentCourseTEXT.Text = "Student's Course\r\n";
            StudentCourseTEXT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StudentNameTEXT
            // 
            StudentNameTEXT.AutoSize = true;
            StudentNameTEXT.BackColor = Color.Transparent;
            StudentNameTEXT.Location = new Point(88, 253);
            StudentNameTEXT.Name = "StudentNameTEXT";
            StudentNameTEXT.Size = new Size(83, 15);
            StudentNameTEXT.TabIndex = 1;
            StudentNameTEXT.Text = "Student Name";
            // 
            // StudentProfilePB
            // 
            StudentProfilePB.BackColor = Color.Transparent;
            StudentProfilePB.Location = new Point(47, 12);
            StudentProfilePB.Name = "StudentProfilePB";
            StudentProfilePB.Size = new Size(190, 224);
            StudentProfilePB.SizeMode = PictureBoxSizeMode.Zoom;
            StudentProfilePB.TabIndex = 0;
            StudentProfilePB.TabStop = false;
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
            kryptonPanel4.Size = new Size(1473, 10);
            kryptonPanel4.TabIndex = 4;
            // 
            // BooksPanel
            // 
            BooksPanel.Controls.Add(UserBooksFLP);
            BooksPanel.Location = new Point(16, 91);
            BooksPanel.Name = "BooksPanel";
            BooksPanel.Size = new Size(1441, 766);
            BooksPanel.TabIndex = 5;
            // 
            // UserBooksFLP
            // 
            UserBooksFLP.Location = new Point(3, 3);
            UserBooksFLP.Name = "UserBooksFLP";
            UserBooksFLP.Size = new Size(1435, 760);
            UserBooksFLP.TabIndex = 0;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(button1);
            kryptonPanel2.Controls.Add(SearchTXT);
            kryptonPanel2.Controls.Add(panel2);
            kryptonPanel2.Controls.Add(UserViewProfileBTN);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(10, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1463, 82);
            kryptonPanel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.Search;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(484, 29);
            button1.Name = "button1";
            button1.Size = new Size(37, 34);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = false;
            // 
            // SearchTXT
            // 
            SearchTXT.Cursor = Cursors.IBeam;
            SearchTXT.Location = new Point(527, 29);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.Size = new Size(479, 34);
            SearchTXT.StateActive.Back.Color1 = Color.White;
            SearchTXT.StateActive.Border.Color1 = Color.Black;
            SearchTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateActive.Border.Rounding = 10F;
            SearchTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateActive.Content.Padding = new Padding(5);
            SearchTXT.StateCommon.Back.Color1 = Color.White;
            SearchTXT.StateCommon.Border.Color1 = Color.Black;
            SearchTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateCommon.Border.Rounding = 10F;
            SearchTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateCommon.Content.Padding = new Padding(5);
            SearchTXT.StateDisabled.Back.Color1 = Color.White;
            SearchTXT.StateDisabled.Border.Color1 = Color.Black;
            SearchTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateDisabled.Border.Rounding = 10F;
            SearchTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            SearchTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateNormal.Border.Rounding = 10F;
            SearchTXT.StateNormal.Border.Width = 10;
            SearchTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateNormal.Content.Padding = new Padding(5);
            SearchTXT.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(UserTransactionBTN);
            panel2.Controls.Add(kryptonPanel5);
            panel2.Location = new Point(153, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(108, 76);
            panel2.TabIndex = 0;
            // 
            // UserTransactionBTN
            // 
            UserTransactionBTN.BackColor = Color.Transparent;
            UserTransactionBTN.Cursor = Cursors.Hand;
            UserTransactionBTN.FlatAppearance.BorderSize = 0;
            UserTransactionBTN.FlatStyle = FlatStyle.Flat;
            UserTransactionBTN.Image = (Image)resources.GetObject("UserTransactionBTN.Image");
            UserTransactionBTN.ImageAlign = ContentAlignment.TopCenter;
            UserTransactionBTN.Location = new Point(3, 9);
            UserTransactionBTN.Name = "UserTransactionBTN";
            UserTransactionBTN.Size = new Size(103, 51);
            UserTransactionBTN.TabIndex = 10;
            UserTransactionBTN.Text = "My Transactions";
            UserTransactionBTN.TextAlign = ContentAlignment.BottomCenter;
            UserTransactionBTN.UseVisualStyleBackColor = false;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Location = new Point(22, 82);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.Size = new Size(733, 483);
            kryptonPanel5.TabIndex = 0;
            // 
            // UserViewProfileBTN
            // 
            UserViewProfileBTN.BackColor = Color.Transparent;
            UserViewProfileBTN.Cursor = Cursors.Hand;
            UserViewProfileBTN.FlatAppearance.BorderSize = 0;
            UserViewProfileBTN.FlatStyle = FlatStyle.Flat;
            UserViewProfileBTN.Image = Properties.Resources.Student_Male;
            UserViewProfileBTN.ImageAlign = ContentAlignment.TopCenter;
            UserViewProfileBTN.Location = new Point(37, 12);
            UserViewProfileBTN.Name = "UserViewProfileBTN";
            UserViewProfileBTN.Size = new Size(88, 56);
            UserViewProfileBTN.TabIndex = 9;
            UserViewProfileBTN.Text = "View Profile";
            UserViewProfileBTN.TextAlign = ContentAlignment.BottomCenter;
            UserViewProfileBTN.UseVisualStyleBackColor = false;
            UserViewProfileBTN.Click += UserViewProfileBTN_Click;
            // 
            // UserMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1473, 873);
            Controls.Add(UserPanel);
            Controls.Add(kryptonPanel2);
            Controls.Add(BooksPanel);
            Controls.Add(kryptonPanel3);
            Controls.Add(kryptonPanel4);
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
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel UserPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Panel BooksPanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Panel panel2;
        private Label StudentNameTEXT;
        private PictureBox StudentProfilePB;
        private Label StudentCourseTEXT;
        private Panel UserActivityLogs;
        private Label label1;
        private Button UserViewProfileBTN;
        private Button UserTransactionBTN;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private FlowLayoutPanel UserBooksFLP;
        private Button button1;
        private Krypton.Toolkit.KryptonTextBox SearchTXT;
    }
}