namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class SignInForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            GoBackBTN = new Button();
            FirstNameTB = new Krypton.Toolkit.KryptonTextBox();
            LastNameTB = new Krypton.Toolkit.KryptonTextBox();
            EmailTB = new Krypton.Toolkit.KryptonTextBox();
            PasswordTB = new Krypton.Toolkit.KryptonTextBox();
            SignInBTN = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ConfirmPassTB = new Krypton.Toolkit.KryptonTextBox();
            label7 = new Label();
            ShowPasswordTB = new CheckBox();
            AdminPicPB = new PictureBox();
            SelectImageBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AdminPicPB).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = Properties.Resources.abstract_water_ocean_wave_background;
            pictureBox1.Location = new Point(0, 486);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1039, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(400, 115);
            label1.Name = "label1";
            label1.Size = new Size(187, 19);
            label1.TabIndex = 1;
            label1.Text = "Please sign in your account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(225, 75);
            label2.Name = "label2";
            label2.Size = new Size(537, 28);
            label2.TabIndex = 2;
            label2.Text = "UNIVERSITY LIBRARY MANAGEMENT SYSTEM";
            // 
            // GoBackBTN
            // 
            GoBackBTN.BackColor = Color.LightCyan;
            GoBackBTN.Cursor = Cursors.Hand;
            GoBackBTN.FlatAppearance.BorderSize = 0;
            GoBackBTN.FlatStyle = FlatStyle.Flat;
            GoBackBTN.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GoBackBTN.ForeColor = Color.Red;
            GoBackBTN.Image = Properties.Resources.Back;
            GoBackBTN.ImageAlign = ContentAlignment.MiddleLeft;
            GoBackBTN.Location = new Point(21, 21);
            GoBackBTN.Name = "GoBackBTN";
            GoBackBTN.Size = new Size(125, 26);
            GoBackBTN.TabIndex = 8;
            GoBackBTN.Text = "Go Back";
            GoBackBTN.UseVisualStyleBackColor = false;
            GoBackBTN.Click += GoBackBTN_Click;
            // 
            // FirstNameTB
            // 
            FirstNameTB.Cursor = Cursors.IBeam;
            FirstNameTB.Location = new Point(217, 183);
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
            LastNameTB.Location = new Point(217, 236);
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
            EmailTB.Location = new Point(217, 290);
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
            PasswordTB.Location = new Point(217, 350);
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
            PasswordTB.UseSystemPasswordChar = true;
            // 
            // SignInBTN
            // 
            SignInBTN.Cursor = Cursors.Hand;
            SignInBTN.Location = new Point(342, 517);
            SignInBTN.Name = "SignInBTN";
            SignInBTN.Size = new Size(271, 34);
            SignInBTN.StateCommon.Back.Color1 = Color.SteelBlue;
            SignInBTN.StateCommon.Back.Color2 = Color.SteelBlue;
            SignInBTN.StateCommon.Border.Color1 = Color.Black;
            SignInBTN.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SignInBTN.StateCommon.Border.Rounding = 10F;
            SignInBTN.StateCommon.Content.ShortText.Color2 = Color.Black;
            SignInBTN.StateCommon.Content.ShortText.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SignInBTN.TabIndex = 7;
            SignInBTN.Values.Text = "SIGN IN";
            SignInBTN.Click += SignInBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(129, 201);
            label3.Name = "label3";
            label3.Size = new Size(66, 16);
            label3.TabIndex = 8;
            label3.Text = "Firstname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(130, 254);
            label4.Name = "label4";
            label4.Size = new Size(65, 16);
            label4.TabIndex = 9;
            label4.Text = "Lastname:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(154, 308);
            label5.Name = "label5";
            label5.Size = new Size(41, 16);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(129, 368);
            label6.Name = "label6";
            label6.Size = new Size(66, 16);
            label6.TabIndex = 11;
            label6.Text = "Password:";
            // 
            // ConfirmPassTB
            // 
            ConfirmPassTB.Cursor = Cursors.IBeam;
            ConfirmPassTB.Location = new Point(217, 403);
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
            ConfirmPassTB.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(79, 412);
            label7.Name = "label7";
            label7.Size = new Size(116, 16);
            label7.TabIndex = 13;
            label7.Text = "Confirm Password:";
            // 
            // ShowPasswordTB
            // 
            ShowPasswordTB.AutoSize = true;
            ShowPasswordTB.Cursor = Cursors.Hand;
            ShowPasswordTB.Location = new Point(217, 454);
            ShowPasswordTB.Name = "ShowPasswordTB";
            ShowPasswordTB.Size = new Size(109, 19);
            ShowPasswordTB.TabIndex = 6;
            ShowPasswordTB.Text = "Show Password";
            ShowPasswordTB.UseVisualStyleBackColor = true;
            // 
            // AdminPicPB
            // 
            AdminPicPB.Image = Properties.Resources.UserQQ;
            AdminPicPB.Location = new Point(676, 183);
            AdminPicPB.Name = "AdminPicPB";
            AdminPicPB.Size = new Size(218, 183);
            AdminPicPB.SizeMode = PictureBoxSizeMode.Zoom;
            AdminPicPB.TabIndex = 14;
            AdminPicPB.TabStop = false;
            // 
            // SelectImageBTN
            // 
            SelectImageBTN.Cursor = Cursors.Hand;
            SelectImageBTN.FlatAppearance.BorderSize = 0;
            SelectImageBTN.FlatStyle = FlatStyle.Flat;
            SelectImageBTN.Image = Properties.Resources.Image;
            SelectImageBTN.ImageAlign = ContentAlignment.MiddleLeft;
            SelectImageBTN.Location = new Point(676, 383);
            SelectImageBTN.Name = "SelectImageBTN";
            SelectImageBTN.Size = new Size(218, 23);
            SelectImageBTN.TabIndex = 15;
            SelectImageBTN.Text = "Select Image from Files";
            SelectImageBTN.UseVisualStyleBackColor = true;
            SelectImageBTN.Click += SelectImageBTN_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1039, 707);
            Controls.Add(SelectImageBTN);
            Controls.Add(AdminPicPB);
            Controls.Add(ShowPasswordTB);
            Controls.Add(label7);
            Controls.Add(ConfirmPassTB);
            Controls.Add(SignInBTN);
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
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignInForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AdminPicPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button GoBackBTN;
        private Krypton.Toolkit.KryptonTextBox FirstNameTB;
        private Krypton.Toolkit.KryptonTextBox LastNameTB;
        private Krypton.Toolkit.KryptonTextBox EmailTB;
        private Krypton.Toolkit.KryptonTextBox PasswordTB;
        private Krypton.Toolkit.KryptonButton SignInBTN;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Krypton.Toolkit.KryptonTextBox ConfirmPassTB;
        private Label label7;
        private CheckBox ShowPasswordTB;
        private PictureBox AdminPicPB;
        private Button SelectImageBTN;
    }
}