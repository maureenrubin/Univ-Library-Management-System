namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class CreateAdminAccForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAdminAccForm));
            label1 = new Label();
            label2 = new Label();
            GoBackBTN = new Button();
            FirstNameTB = new Krypton.Toolkit.KryptonTextBox();
            LastNameTB = new Krypton.Toolkit.KryptonTextBox();
            EmailTB = new Krypton.Toolkit.KryptonTextBox();
            PasswordTB = new Krypton.Toolkit.KryptonTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ConfirmPassTB = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            ShowPasswordTB = new CheckBox();
            AdminPicPB = new PictureBox();
            SelectImageBTN = new Button();
            GenderCB = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            CancelBTN = new Krypton.Toolkit.KryptonButton();
            CreateAdminBTN = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)AdminPicPB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(320, 86);
            label1.Name = "label1";
            label1.Size = new Size(265, 19);
            label1.TabIndex = 1;
            label1.Text = "University Library Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(293, 49);
            label2.Name = "label2";
            label2.Size = new Size(336, 28);
            label2.TabIndex = 2;
            label2.Text = "ADD NEW ADMINISTRATOR";
            // 
            // GoBackBTN
            // 
            GoBackBTN.BackColor = Color.Transparent;
            GoBackBTN.Cursor = Cursors.Hand;
            GoBackBTN.FlatAppearance.BorderSize = 0;
            GoBackBTN.FlatStyle = FlatStyle.Flat;
            GoBackBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackBTN.ForeColor = Color.Black;
            GoBackBTN.Image = (Image)resources.GetObject("GoBackBTN.Image");
            GoBackBTN.ImageAlign = ContentAlignment.MiddleLeft;
            GoBackBTN.Location = new Point(28, 31);
            GoBackBTN.Name = "GoBackBTN";
            GoBackBTN.Size = new Size(88, 26);
            GoBackBTN.TabIndex = 8;
            GoBackBTN.Text = "Go Back";
            GoBackBTN.TextAlign = ContentAlignment.MiddleRight;
            GoBackBTN.UseVisualStyleBackColor = false;
            GoBackBTN.Click += GoBackBTN_Click;
            // 
            // FirstNameTB
            // 
            FirstNameTB.Cursor = Cursors.IBeam;
            FirstNameTB.Location = new Point(199, 143);
            FirstNameTB.Name = "FirstNameTB";
            FirstNameTB.Size = new Size(271, 34);
            FirstNameTB.StateActive.Back.Color1 = Color.White;
            FirstNameTB.StateActive.Border.Color1 = Color.Black;
            FirstNameTB.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FirstNameTB.StateActive.Border.Rounding = 10F;
            FirstNameTB.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            FirstNameTB.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTB.StateActive.Content.Padding = new Padding(5);
            FirstNameTB.StateCommon.Back.Color1 = Color.White;
            FirstNameTB.StateCommon.Border.Color1 = Color.Black;
            FirstNameTB.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FirstNameTB.StateCommon.Border.Rounding = 10F;
            FirstNameTB.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            FirstNameTB.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTB.StateCommon.Content.Padding = new Padding(5);
            FirstNameTB.StateDisabled.Back.Color1 = Color.White;
            FirstNameTB.StateDisabled.Border.Color1 = Color.Black;
            FirstNameTB.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FirstNameTB.StateDisabled.Border.Rounding = 10F;
            FirstNameTB.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            FirstNameTB.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTB.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            FirstNameTB.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            FirstNameTB.StateNormal.Border.Rounding = 10F;
            FirstNameTB.StateNormal.Border.Width = 10;
            FirstNameTB.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            FirstNameTB.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameTB.StateNormal.Content.Padding = new Padding(5);
            FirstNameTB.TabIndex = 1;
            // 
            // LastNameTB
            // 
            LastNameTB.Cursor = Cursors.IBeam;
            LastNameTB.Location = new Point(199, 196);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(271, 34);
            LastNameTB.StateActive.Back.Color1 = Color.White;
            LastNameTB.StateActive.Border.Color1 = Color.Black;
            LastNameTB.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LastNameTB.StateActive.Border.Rounding = 10F;
            LastNameTB.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            LastNameTB.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTB.StateActive.Content.Padding = new Padding(5);
            LastNameTB.StateCommon.Back.Color1 = Color.White;
            LastNameTB.StateCommon.Border.Color1 = Color.Black;
            LastNameTB.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LastNameTB.StateCommon.Border.Rounding = 10F;
            LastNameTB.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            LastNameTB.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTB.StateCommon.Content.Padding = new Padding(5);
            LastNameTB.StateDisabled.Back.Color1 = Color.White;
            LastNameTB.StateDisabled.Border.Color1 = Color.Black;
            LastNameTB.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LastNameTB.StateDisabled.Border.Rounding = 10F;
            LastNameTB.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            LastNameTB.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTB.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            LastNameTB.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LastNameTB.StateNormal.Border.Rounding = 10F;
            LastNameTB.StateNormal.Border.Width = 10;
            LastNameTB.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            LastNameTB.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameTB.StateNormal.Content.Padding = new Padding(5);
            LastNameTB.TabIndex = 2;
            // 
            // EmailTB
            // 
            EmailTB.Cursor = Cursors.IBeam;
            EmailTB.Location = new Point(199, 250);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(271, 34);
            EmailTB.StateActive.Back.Color1 = Color.White;
            EmailTB.StateActive.Border.Color1 = Color.Black;
            EmailTB.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EmailTB.StateActive.Border.Rounding = 10F;
            EmailTB.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            EmailTB.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.StateActive.Content.Padding = new Padding(5);
            EmailTB.StateCommon.Back.Color1 = Color.White;
            EmailTB.StateCommon.Border.Color1 = Color.Black;
            EmailTB.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EmailTB.StateCommon.Border.Rounding = 10F;
            EmailTB.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            EmailTB.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.StateCommon.Content.Padding = new Padding(5);
            EmailTB.StateDisabled.Back.Color1 = Color.White;
            EmailTB.StateDisabled.Border.Color1 = Color.Black;
            EmailTB.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EmailTB.StateDisabled.Border.Rounding = 10F;
            EmailTB.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            EmailTB.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            EmailTB.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EmailTB.StateNormal.Border.Rounding = 10F;
            EmailTB.StateNormal.Border.Width = 10;
            EmailTB.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            EmailTB.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.StateNormal.Content.Padding = new Padding(5);
            EmailTB.TabIndex = 3;
            // 
            // PasswordTB
            // 
            PasswordTB.Cursor = Cursors.IBeam;
            PasswordTB.Location = new Point(199, 310);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.PasswordChar = '●';
            PasswordTB.Size = new Size(271, 34);
            PasswordTB.StateActive.Back.Color1 = Color.White;
            PasswordTB.StateActive.Border.Color1 = Color.Black;
            PasswordTB.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PasswordTB.StateActive.Border.Rounding = 10F;
            PasswordTB.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            PasswordTB.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.StateActive.Content.Padding = new Padding(5);
            PasswordTB.StateCommon.Back.Color1 = Color.White;
            PasswordTB.StateCommon.Border.Color1 = Color.Black;
            PasswordTB.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PasswordTB.StateCommon.Border.Rounding = 10F;
            PasswordTB.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            PasswordTB.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.StateCommon.Content.Padding = new Padding(5);
            PasswordTB.StateDisabled.Back.Color1 = Color.White;
            PasswordTB.StateDisabled.Border.Color1 = Color.Black;
            PasswordTB.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PasswordTB.StateDisabled.Border.Rounding = 10F;
            PasswordTB.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            PasswordTB.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            PasswordTB.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PasswordTB.StateNormal.Border.Rounding = 10F;
            PasswordTB.StateNormal.Border.Width = 10;
            PasswordTB.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            PasswordTB.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTB.StateNormal.Content.Padding = new Padding(5);
            PasswordTB.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(61, 161);
            label3.Name = "label3";
            label3.Size = new Size(66, 16);
            label3.TabIndex = 8;
            label3.Text = "Firstname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(62, 205);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 9;
            label4.Text = "Lastname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 264);
            label5.Name = "label5";
            label5.Size = new Size(41, 16);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(62, 319);
            label6.Name = "label6";
            label6.Size = new Size(66, 16);
            label6.TabIndex = 11;
            label6.Text = "Password:";
            // 
            // ConfirmPassTB
            // 
            ConfirmPassTB.Cursor = Cursors.IBeam;
            ConfirmPassTB.Location = new Point(199, 363);
            ConfirmPassTB.Name = "ConfirmPassTB";
            ConfirmPassTB.PasswordChar = '●';
            ConfirmPassTB.Size = new Size(271, 34);
            ConfirmPassTB.StateActive.Back.Color1 = Color.White;
            ConfirmPassTB.StateActive.Border.Color1 = Color.Black;
            ConfirmPassTB.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ConfirmPassTB.StateActive.Border.Rounding = 10F;
            ConfirmPassTB.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            ConfirmPassTB.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPassTB.StateActive.Content.Padding = new Padding(5);
            ConfirmPassTB.StateCommon.Back.Color1 = Color.White;
            ConfirmPassTB.StateCommon.Border.Color1 = Color.Black;
            ConfirmPassTB.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ConfirmPassTB.StateCommon.Border.Rounding = 10F;
            ConfirmPassTB.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            ConfirmPassTB.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPassTB.StateCommon.Content.Padding = new Padding(5);
            ConfirmPassTB.StateDisabled.Back.Color1 = Color.White;
            ConfirmPassTB.StateDisabled.Border.Color1 = Color.Black;
            ConfirmPassTB.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ConfirmPassTB.StateDisabled.Border.Rounding = 10F;
            ConfirmPassTB.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            ConfirmPassTB.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPassTB.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            ConfirmPassTB.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ConfirmPassTB.StateNormal.Border.Rounding = 10F;
            ConfirmPassTB.StateNormal.Border.Width = 10;
            ConfirmPassTB.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            ConfirmPassTB.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ConfirmPassTB.StateNormal.Content.Padding = new Padding(5);
            ConfirmPassTB.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(61, 372);
            label7.Name = "label7";
            label7.Size = new Size(116, 16);
            label7.TabIndex = 13;
            label7.Text = "Confirm Password:";
            // 
            // ShowPasswordTB
            // 
            ShowPasswordTB.AutoSize = true;
            ShowPasswordTB.Cursor = Cursors.Hand;
            ShowPasswordTB.Location = new Point(199, 414);
            ShowPasswordTB.Name = "ShowPasswordTB";
            ShowPasswordTB.Size = new Size(109, 19);
            ShowPasswordTB.TabIndex = 6;
            ShowPasswordTB.Text = "Show Password";
            ShowPasswordTB.UseVisualStyleBackColor = true;
            ShowPasswordTB.CheckedChanged += ShowPasswordTB_CheckedChanged;
            // 
            // AdminPicPB
            // 
            AdminPicPB.Image = Properties.Resources.UserQQ;
            AdminPicPB.Location = new Point(579, 140);
            AdminPicPB.Name = "AdminPicPB";
            AdminPicPB.Size = new Size(218, 183);
            AdminPicPB.SizeMode = PictureBoxSizeMode.Zoom;
            AdminPicPB.TabIndex = 14;
            AdminPicPB.TabStop = false;
            // 
            // SelectImageBTN
            // 
            SelectImageBTN.Cursor = Cursors.Hand;
            SelectImageBTN.FlatAppearance.BorderColor = Color.Black;
            SelectImageBTN.FlatStyle = FlatStyle.Flat;
            SelectImageBTN.ImageAlign = ContentAlignment.MiddleLeft;
            SelectImageBTN.Location = new Point(579, 340);
            SelectImageBTN.Name = "SelectImageBTN";
            SelectImageBTN.Size = new Size(218, 25);
            SelectImageBTN.TabIndex = 15;
            SelectImageBTN.Text = "Select Image from Files";
            SelectImageBTN.UseVisualStyleBackColor = true;
            SelectImageBTN.Click += SelectImageBTN_Click;
            // 
            // GenderCB
            // 
            GenderCB.FlatStyle = FlatStyle.Flat;
            GenderCB.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCB.FormattingEnabled = true;
            GenderCB.Items.AddRange(new object[] { "Female", "Male" });
            GenderCB.Location = new Point(579, 386);
            GenderCB.Margin = new Padding(5);
            GenderCB.Name = "GenderCB";
            GenderCB.Size = new Size(218, 24);
            GenderCB.TabIndex = 17;
            GenderCB.Text = "        GENDER";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(152, 96, 64);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 600);
            panel1.Name = "panel1";
            panel1.Size = new Size(902, 10);
            panel1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(152, 96, 64);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(902, 10);
            panel2.TabIndex = 19;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(152, 96, 64);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 590);
            panel3.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(152, 96, 64);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(892, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 590);
            panel4.TabIndex = 19;
            // 
            // CancelBTN
            // 
            CancelBTN.Cursor = Cursors.Hand;
            CancelBTN.Location = new Point(266, 494);
            CancelBTN.Name = "CancelBTN";
            CancelBTN.Size = new Size(169, 36);
            CancelBTN.StateCommon.Back.Color1 = Color.Crimson;
            CancelBTN.StateCommon.Back.Color2 = Color.Crimson;
            CancelBTN.StateCommon.Border.Color1 = Color.Black;
            CancelBTN.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBTN.StateCommon.Border.Rounding = 6F;
            CancelBTN.StateCommon.Content.ShortText.Color1 = Color.Black;
            CancelBTN.StateCommon.Content.ShortText.Color2 = Color.Black;
            CancelBTN.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBTN.TabIndex = 21;
            CancelBTN.Values.Text = "CANCEL";
            CancelBTN.Click += CancelBTN_Click;
            // 
            // CreateAdminBTN
            // 
            CreateAdminBTN.Cursor = Cursors.Hand;
            CreateAdminBTN.Location = new Point(453, 494);
            CreateAdminBTN.Name = "CreateAdminBTN";
            CreateAdminBTN.Size = new Size(186, 36);
            CreateAdminBTN.StateCommon.Back.Color1 = Color.RoyalBlue;
            CreateAdminBTN.StateCommon.Back.Color2 = Color.RoyalBlue;
            CreateAdminBTN.StateCommon.Border.Color1 = Color.Black;
            CreateAdminBTN.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CreateAdminBTN.StateCommon.Border.Rounding = 6F;
            CreateAdminBTN.StateCommon.Content.ShortText.Color1 = Color.Black;
            CreateAdminBTN.StateCommon.Content.ShortText.Color2 = Color.Black;
            CreateAdminBTN.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CreateAdminBTN.TabIndex = 20;
            CreateAdminBTN.Values.Text = "SAVE";
            CreateAdminBTN.Click += CreateAdminBTN_Click_1;
            // 
            // CreateAdminAccForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 144, 116);
            ClientSize = new Size(902, 610);
            Controls.Add(CancelBTN);
            Controls.Add(CreateAdminBTN);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(GenderCB);
            Controls.Add(SelectImageBTN);
            Controls.Add(AdminPicPB);
            Controls.Add(ShowPasswordTB);
            Controls.Add(label7);
            Controls.Add(ConfirmPassTB);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(PasswordTB);
            Controls.Add(EmailTB);
            Controls.Add(LastNameTB);
            Controls.Add(FirstNameTB);
            Controls.Add(GoBackBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAdminAccForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInForm";
            ((System.ComponentModel.ISupportInitialize)AdminPicPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button GoBackBTN;
        private Krypton.Toolkit.KryptonTextBox FirstNameTB;
        private Krypton.Toolkit.KryptonTextBox LastNameTB;
        private Krypton.Toolkit.KryptonTextBox EmailTB;
        private Krypton.Toolkit.KryptonTextBox PasswordTB;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.KryptonTextBox ConfirmPassTB;
        private Label label7;
        private CheckBox ShowPasswordTB;
        private PictureBox AdminPicPB;
        private Button SelectImageBTN;
        private ComboBox GenderCB;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Krypton.Toolkit.KryptonButton CancelBTN;
        private Krypton.Toolkit.KryptonButton CreateAdminBTN;
    }
}