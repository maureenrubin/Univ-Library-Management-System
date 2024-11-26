namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class AdminManageUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageUserForm));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            StudentPanel = new Panel();
            DeleteUserBtn = new Krypton.Toolkit.KryptonButton();
            EditUserBtn = new Krypton.Toolkit.KryptonButton();
            AddUserBtn = new Krypton.Toolkit.KryptonButton();
            ManageUserBTN = new Button();
            panel3 = new Panel();
            label5 = new Label();
            CBShowpass = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CancelBtn = new Krypton.Toolkit.KryptonButton();
            SaveUserBtn = new Krypton.Toolkit.KryptonButton();
            UserCourseCB = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            UserLastNameTXT = new Krypton.Toolkit.KryptonTextBox();
            UserFirstNameTXT = new Krypton.Toolkit.KryptonTextBox();
            UserPasswordTXT = new Krypton.Toolkit.KryptonTextBox();
            UserEmailTXT = new Krypton.Toolkit.KryptonTextBox();
            BrowseImageBtn = new Button();
            UserPicturePB = new PictureBox();
            panel1.SuspendLayout();
            StudentPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicturePB).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(60, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1376, 795);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.AliceBlue;
            flowLayoutPanel1.Location = new Point(13, 24);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1352, 759);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // StudentPanel
            // 
            StudentPanel.BackColor = Color.FromArgb(187, 206, 230);
            StudentPanel.Controls.Add(DeleteUserBtn);
            StudentPanel.Controls.Add(EditUserBtn);
            StudentPanel.Controls.Add(AddUserBtn);
            StudentPanel.Controls.Add(ManageUserBTN);
            StudentPanel.Controls.Add(panel3);
            StudentPanel.Location = new Point(12, 57);
            StudentPanel.Name = "StudentPanel";
            StudentPanel.Size = new Size(1097, 698);
            StudentPanel.TabIndex = 1;
            // 
            // DeleteUserBtn
            // 
            DeleteUserBtn.Cursor = Cursors.Hand;
            DeleteUserBtn.Location = new Point(95, 338);
            DeleteUserBtn.Name = "DeleteUserBtn";
            DeleteUserBtn.Size = new Size(164, 42);
            DeleteUserBtn.StateCommon.Back.Color1 = Color.Firebrick;
            DeleteUserBtn.StateCommon.Back.Color2 = Color.Firebrick;
            DeleteUserBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DeleteUserBtn.StateCommon.Border.Rounding = 6F;
            DeleteUserBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            DeleteUserBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            DeleteUserBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteUserBtn.StateDisabled.Back.Color1 = Color.Transparent;
            DeleteUserBtn.StateDisabled.Back.Color2 = Color.Transparent;
            DeleteUserBtn.StateDisabled.Border.Color1 = Color.Black;
            DeleteUserBtn.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DeleteUserBtn.StateDisabled.Border.Rounding = 6F;
            DeleteUserBtn.StateDisabled.Content.ShortText.Color1 = Color.Black;
            DeleteUserBtn.StateDisabled.Content.ShortText.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteUserBtn.StatePressed.Back.Color1 = Color.Transparent;
            DeleteUserBtn.StatePressed.Border.Color2 = Color.Black;
            DeleteUserBtn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DeleteUserBtn.StatePressed.Border.Rounding = 6F;
            DeleteUserBtn.StatePressed.Content.ShortText.Color2 = Color.Black;
            DeleteUserBtn.StatePressed.Content.ShortText.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteUserBtn.TabIndex = 4;
            DeleteUserBtn.Values.Text = "DELETE STUDENT";
            // 
            // EditUserBtn
            // 
            EditUserBtn.Cursor = Cursors.Hand;
            EditUserBtn.Location = new Point(95, 270);
            EditUserBtn.Name = "EditUserBtn";
            EditUserBtn.Size = new Size(164, 42);
            EditUserBtn.StateCommon.Back.Color1 = Color.DodgerBlue;
            EditUserBtn.StateCommon.Back.Color2 = Color.DodgerBlue;
            EditUserBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EditUserBtn.StateCommon.Border.Rounding = 6F;
            EditUserBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            EditUserBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            EditUserBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditUserBtn.StateDisabled.Back.Color1 = Color.Transparent;
            EditUserBtn.StateDisabled.Back.Color2 = Color.Transparent;
            EditUserBtn.StateDisabled.Border.Color1 = Color.Black;
            EditUserBtn.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EditUserBtn.StateDisabled.Border.Rounding = 6F;
            EditUserBtn.StateDisabled.Content.ShortText.Color1 = Color.Black;
            EditUserBtn.StateDisabled.Content.ShortText.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EditUserBtn.StatePressed.Back.Color1 = Color.Transparent;
            EditUserBtn.StatePressed.Border.Color2 = Color.Black;
            EditUserBtn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EditUserBtn.StatePressed.Border.Rounding = 6F;
            EditUserBtn.StatePressed.Content.ShortText.Color2 = Color.Black;
            EditUserBtn.StatePressed.Content.ShortText.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EditUserBtn.TabIndex = 3;
            EditUserBtn.Values.Text = "EDIT STUDENT";
            // 
            // AddUserBtn
            // 
            AddUserBtn.Cursor = Cursors.Hand;
            AddUserBtn.Location = new Point(94, 205);
            AddUserBtn.Name = "AddUserBtn";
            AddUserBtn.Size = new Size(164, 42);
            AddUserBtn.StateCommon.Back.Color1 = Color.MediumSeaGreen;
            AddUserBtn.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            AddUserBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddUserBtn.StateCommon.Border.Rounding = 6F;
            AddUserBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            AddUserBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            AddUserBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddUserBtn.StateDisabled.Back.Color1 = Color.Transparent;
            AddUserBtn.StateDisabled.Back.Color2 = Color.Transparent;
            AddUserBtn.StateDisabled.Border.Color1 = Color.Black;
            AddUserBtn.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddUserBtn.StateDisabled.Border.Rounding = 6F;
            AddUserBtn.StateDisabled.Content.ShortText.Color1 = Color.Black;
            AddUserBtn.StateDisabled.Content.ShortText.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddUserBtn.StatePressed.Back.Color1 = Color.Transparent;
            AddUserBtn.StatePressed.Border.Color2 = Color.Black;
            AddUserBtn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddUserBtn.StatePressed.Border.Rounding = 6F;
            AddUserBtn.StatePressed.Content.ShortText.Color2 = Color.Black;
            AddUserBtn.StatePressed.Content.ShortText.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddUserBtn.TabIndex = 2;
            AddUserBtn.Values.Text = "ADD STUDENT";
            AddUserBtn.Click += AddUserBtn_Click;
            // 
            // ManageUserBTN
            // 
            ManageUserBTN.Cursor = Cursors.Hand;
            ManageUserBTN.FlatAppearance.BorderSize = 0;
            ManageUserBTN.FlatStyle = FlatStyle.Flat;
            ManageUserBTN.Image = (Image)resources.GetObject("ManageUserBTN.Image");
            ManageUserBTN.Location = new Point(3, 3);
            ManageUserBTN.Name = "ManageUserBTN";
            ManageUserBTN.Size = new Size(36, 44);
            ManageUserBTN.TabIndex = 1;
            ManageUserBTN.UseVisualStyleBackColor = true;
            ManageUserBTN.Click += ManageUserBTN_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(CBShowpass);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(CancelBtn);
            panel3.Controls.Add(SaveUserBtn);
            panel3.Controls.Add(UserCourseCB);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(UserLastNameTXT);
            panel3.Controls.Add(UserFirstNameTXT);
            panel3.Controls.Add(UserPasswordTXT);
            panel3.Controls.Add(UserEmailTXT);
            panel3.Controls.Add(BrowseImageBtn);
            panel3.Controls.Add(UserPicturePB);
            panel3.Location = new Point(290, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(788, 671);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(103, 439);
            label5.Name = "label5";
            label5.Size = new Size(118, 14);
            label5.TabIndex = 16;
            label5.Text = "Date of User Creation";
            // 
            // CBShowpass
            // 
            CBShowpass.AutoSize = true;
            CBShowpass.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBShowpass.Location = new Point(467, 439);
            CBShowpass.Name = "CBShowpass";
            CBShowpass.Size = new Size(107, 18);
            CBShowpass.TabIndex = 15;
            CBShowpass.Text = "Show Password";
            CBShowpass.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(364, 408);
            label4.Name = "label4";
            label4.Size = new Size(59, 14);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(364, 344);
            label3.Name = "label3";
            label3.Size = new Size(37, 14);
            label3.TabIndex = 13;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(364, 199);
            label2.Name = "label2";
            label2.Size = new Size(58, 14);
            label2.TabIndex = 12;
            label2.Text = "Lastname:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(364, 124);
            label1.Name = "label1";
            label1.Size = new Size(60, 14);
            label1.TabIndex = 11;
            label1.Text = "Firstname:";
            // 
            // CancelBtn
            // 
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.Location = new Point(439, 608);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(135, 30);
            CancelBtn.StateCommon.Back.Color1 = Color.Crimson;
            CancelBtn.StateCommon.Back.Color2 = Color.Crimson;
            CancelBtn.StateCommon.Border.Color1 = Color.Black;
            CancelBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBtn.StateCommon.Border.Rounding = 6F;
            CancelBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            CancelBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            CancelBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.TabIndex = 10;
            CancelBtn.Values.Text = "CANCEL";
            // 
            // SaveUserBtn
            // 
            SaveUserBtn.Cursor = Cursors.Hand;
            SaveUserBtn.Location = new Point(599, 608);
            SaveUserBtn.Name = "SaveUserBtn";
            SaveUserBtn.Size = new Size(135, 30);
            SaveUserBtn.StateCommon.Back.Color1 = Color.RoyalBlue;
            SaveUserBtn.StateCommon.Back.Color2 = Color.RoyalBlue;
            SaveUserBtn.StateCommon.Border.Color1 = Color.Black;
            SaveUserBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SaveUserBtn.StateCommon.Border.Rounding = 6F;
            SaveUserBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            SaveUserBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            SaveUserBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveUserBtn.TabIndex = 9;
            SaveUserBtn.Values.Text = "SAVE";
            SaveUserBtn.Click += SaveUserBtn_Click;
            // 
            // UserCourseCB
            // 
            UserCourseCB.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserCourseCB.FormattingEnabled = true;
            UserCourseCB.Items.AddRange(new object[] { "Bachelor in Science & Information Technology", "Bachelor in Science & Business Administration", "Bachelor in Science & Elementary Education", "Bachelor in Science & Social Work", "" });
            UserCourseCB.Location = new Point(463, 256);
            UserCourseCB.Name = "UserCourseCB";
            UserCourseCB.Size = new Size(223, 22);
            UserCourseCB.TabIndex = 7;
            UserCourseCB.Text = "Course";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(61, 456);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 6;
            // 
            // UserLastNameTXT
            // 
            UserLastNameTXT.Cursor = Cursors.IBeam;
            UserLastNameTXT.Location = new Point(463, 179);
            UserLastNameTXT.Name = "UserLastNameTXT";
            UserLastNameTXT.Size = new Size(219, 34);
            UserLastNameTXT.StateActive.Back.Color1 = Color.White;
            UserLastNameTXT.StateActive.Border.Color1 = Color.Black;
            UserLastNameTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserLastNameTXT.StateActive.Border.Rounding = 10F;
            UserLastNameTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserLastNameTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserLastNameTXT.StateActive.Content.Padding = new Padding(5);
            UserLastNameTXT.StateCommon.Back.Color1 = Color.White;
            UserLastNameTXT.StateCommon.Border.Color1 = Color.Black;
            UserLastNameTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserLastNameTXT.StateCommon.Border.Rounding = 10F;
            UserLastNameTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserLastNameTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserLastNameTXT.StateCommon.Content.Padding = new Padding(5);
            UserLastNameTXT.StateDisabled.Back.Color1 = Color.White;
            UserLastNameTXT.StateDisabled.Border.Color1 = Color.Black;
            UserLastNameTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserLastNameTXT.StateDisabled.Border.Rounding = 10F;
            UserLastNameTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserLastNameTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserLastNameTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            UserLastNameTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserLastNameTXT.StateNormal.Border.Rounding = 10F;
            UserLastNameTXT.StateNormal.Border.Width = 10;
            UserLastNameTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserLastNameTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserLastNameTXT.StateNormal.Content.Padding = new Padding(5);
            UserLastNameTXT.TabIndex = 5;
            // 
            // UserFirstNameTXT
            // 
            UserFirstNameTXT.Cursor = Cursors.IBeam;
            UserFirstNameTXT.Location = new Point(463, 104);
            UserFirstNameTXT.Name = "UserFirstNameTXT";
            UserFirstNameTXT.Size = new Size(219, 34);
            UserFirstNameTXT.StateActive.Back.Color1 = Color.White;
            UserFirstNameTXT.StateActive.Border.Color1 = Color.Black;
            UserFirstNameTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserFirstNameTXT.StateActive.Border.Rounding = 10F;
            UserFirstNameTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserFirstNameTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserFirstNameTXT.StateActive.Content.Padding = new Padding(5);
            UserFirstNameTXT.StateCommon.Back.Color1 = Color.White;
            UserFirstNameTXT.StateCommon.Border.Color1 = Color.Black;
            UserFirstNameTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserFirstNameTXT.StateCommon.Border.Rounding = 10F;
            UserFirstNameTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserFirstNameTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserFirstNameTXT.StateCommon.Content.Padding = new Padding(5);
            UserFirstNameTXT.StateDisabled.Back.Color1 = Color.White;
            UserFirstNameTXT.StateDisabled.Border.Color1 = Color.Black;
            UserFirstNameTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserFirstNameTXT.StateDisabled.Border.Rounding = 10F;
            UserFirstNameTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserFirstNameTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserFirstNameTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            UserFirstNameTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserFirstNameTXT.StateNormal.Border.Rounding = 10F;
            UserFirstNameTXT.StateNormal.Border.Width = 10;
            UserFirstNameTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserFirstNameTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserFirstNameTXT.StateNormal.Content.Padding = new Padding(5);
            UserFirstNameTXT.TabIndex = 4;
            // 
            // UserPasswordTXT
            // 
            UserPasswordTXT.Cursor = Cursors.IBeam;
            UserPasswordTXT.Location = new Point(463, 392);
            UserPasswordTXT.Name = "UserPasswordTXT";
            UserPasswordTXT.Size = new Size(219, 34);
            UserPasswordTXT.StateActive.Back.Color1 = Color.White;
            UserPasswordTXT.StateActive.Border.Color1 = Color.Black;
            UserPasswordTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserPasswordTXT.StateActive.Border.Rounding = 10F;
            UserPasswordTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserPasswordTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTXT.StateActive.Content.Padding = new Padding(5);
            UserPasswordTXT.StateCommon.Back.Color1 = Color.White;
            UserPasswordTXT.StateCommon.Border.Color1 = Color.Black;
            UserPasswordTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserPasswordTXT.StateCommon.Border.Rounding = 10F;
            UserPasswordTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserPasswordTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTXT.StateCommon.Content.Padding = new Padding(5);
            UserPasswordTXT.StateDisabled.Back.Color1 = Color.White;
            UserPasswordTXT.StateDisabled.Border.Color1 = Color.Black;
            UserPasswordTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserPasswordTXT.StateDisabled.Border.Rounding = 10F;
            UserPasswordTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserPasswordTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            UserPasswordTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserPasswordTXT.StateNormal.Border.Rounding = 10F;
            UserPasswordTXT.StateNormal.Border.Width = 10;
            UserPasswordTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserPasswordTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserPasswordTXT.StateNormal.Content.Padding = new Padding(5);
            UserPasswordTXT.TabIndex = 3;
            // 
            // UserEmailTXT
            // 
            UserEmailTXT.Cursor = Cursors.IBeam;
            UserEmailTXT.Location = new Point(463, 324);
            UserEmailTXT.Name = "UserEmailTXT";
            UserEmailTXT.Size = new Size(219, 34);
            UserEmailTXT.StateActive.Back.Color1 = Color.White;
            UserEmailTXT.StateActive.Border.Color1 = Color.Black;
            UserEmailTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserEmailTXT.StateActive.Border.Rounding = 10F;
            UserEmailTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserEmailTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserEmailTXT.StateActive.Content.Padding = new Padding(5);
            UserEmailTXT.StateCommon.Back.Color1 = Color.White;
            UserEmailTXT.StateCommon.Border.Color1 = Color.Black;
            UserEmailTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserEmailTXT.StateCommon.Border.Rounding = 10F;
            UserEmailTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserEmailTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserEmailTXT.StateCommon.Content.Padding = new Padding(5);
            UserEmailTXT.StateDisabled.Back.Color1 = Color.White;
            UserEmailTXT.StateDisabled.Border.Color1 = Color.Black;
            UserEmailTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserEmailTXT.StateDisabled.Border.Rounding = 10F;
            UserEmailTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserEmailTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserEmailTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            UserEmailTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UserEmailTXT.StateNormal.Border.Rounding = 10F;
            UserEmailTXT.StateNormal.Border.Width = 10;
            UserEmailTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            UserEmailTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UserEmailTXT.StateNormal.Content.Padding = new Padding(5);
            UserEmailTXT.TabIndex = 2;
            // 
            // BrowseImageBtn
            // 
            BrowseImageBtn.FlatStyle = FlatStyle.Flat;
            BrowseImageBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseImageBtn.Location = new Point(61, 340);
            BrowseImageBtn.Name = "BrowseImageBtn";
            BrowseImageBtn.Size = new Size(206, 27);
            BrowseImageBtn.TabIndex = 1;
            BrowseImageBtn.Text = "Browse Image";
            BrowseImageBtn.UseVisualStyleBackColor = true;
            // 
            // UserPicturePB
            // 
            UserPicturePB.Location = new Point(78, 99);
            UserPicturePB.Name = "UserPicturePB";
            UserPicturePB.Size = new Size(174, 221);
            UserPicturePB.SizeMode = PictureBoxSizeMode.Zoom;
            UserPicturePB.TabIndex = 0;
            UserPicturePB.TabStop = false;
            // 
            // AdminManageUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(187, 206, 230);
            ClientSize = new Size(1436, 795);
            Controls.Add(StudentPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminManageUserForm";
            Text = "AdminAccountForm";
            panel1.ResumeLayout(false);
            StudentPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserPicturePB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel StudentPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private Button ManageUserBTN;
        private Krypton.Toolkit.KryptonButton AddUserBtn;
        private Krypton.Toolkit.KryptonButton EditUserBtn;
        private Krypton.Toolkit.KryptonButton DeleteUserBtn;
        private PictureBox UserPicturePB;
        private Button BrowseImageBtn;
        private Krypton.Toolkit.KryptonTextBox UserEmailTXT;
        private Krypton.Toolkit.KryptonTextBox UserLastNameTXT;
        private Krypton.Toolkit.KryptonTextBox UserFirstNameTXT;
        private Krypton.Toolkit.KryptonTextBox UserPasswordTXT;
        private ComboBox UserCourseCB;
        private DateTimePicker dateTimePicker1;
        private Krypton.Toolkit.KryptonButton CancelBtn;
        private Krypton.Toolkit.KryptonButton SaveUserBtn;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox CBShowpass;
        private Label label5;
    }
}