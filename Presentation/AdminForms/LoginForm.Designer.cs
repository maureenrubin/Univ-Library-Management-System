namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class LoginForm
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
            UsernameTXT = new Krypton.Toolkit.KryptonTextBox();
            PasswordTXT = new Krypton.Toolkit.KryptonTextBox();
            ExitBTN = new Button();
            LoginBTN = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label4 = new Label();
            SignInLabel = new Label();
            pictureBox2 = new PictureBox();
            ShowPassCB = new CheckBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // UsernameTXT
            // 
            UsernameTXT.Cursor = Cursors.IBeam;
            UsernameTXT.Location = new Point(575, 308);
            UsernameTXT.Name = "UsernameTXT";
            UsernameTXT.Size = new Size(331, 40);
            UsernameTXT.StateActive.Back.Color1 = Color.White;
            UsernameTXT.StateActive.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTXT.StateActive.Content.Padding = new Padding(8);
            UsernameTXT.StateCommon.Back.Color1 = Color.White;
            UsernameTXT.StateCommon.Border.Color1 = Color.Black;
            UsernameTXT.StateCommon.Border.Color2 = Color.Black;
            UsernameTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UsernameTXT.StateCommon.Border.Rounding = 10F;
            UsernameTXT.StateCommon.Border.Width = 1;
            UsernameTXT.StateCommon.Content.Color1 = Color.DimGray;
            UsernameTXT.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTXT.StateCommon.Content.Padding = new Padding(8);
            UsernameTXT.StateDisabled.Back.Color1 = Color.White;
            UsernameTXT.StateDisabled.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTXT.StateDisabled.Content.Padding = new Padding(8);
            UsernameTXT.StateNormal.Content.Color1 = Color.Gray;
            UsernameTXT.TabIndex = 1;
            // 
            // PasswordTXT
            // 
            PasswordTXT.Cursor = Cursors.IBeam;
            PasswordTXT.Location = new Point(575, 392);
            PasswordTXT.Name = "PasswordTXT";
            PasswordTXT.PasswordChar = '●';
            PasswordTXT.Size = new Size(331, 40);
            PasswordTXT.StateActive.Back.Color1 = Color.White;
            PasswordTXT.StateActive.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTXT.StateActive.Content.Padding = new Padding(8);
            PasswordTXT.StateCommon.Back.Color1 = Color.White;
            PasswordTXT.StateCommon.Border.Color1 = Color.Black;
            PasswordTXT.StateCommon.Border.Color2 = Color.Black;
            PasswordTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            PasswordTXT.StateCommon.Border.Rounding = 10F;
            PasswordTXT.StateCommon.Border.Width = 1;
            PasswordTXT.StateCommon.Content.Color1 = Color.DimGray;
            PasswordTXT.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTXT.StateCommon.Content.Padding = new Padding(8);
            PasswordTXT.StateDisabled.Back.Color1 = Color.White;
            PasswordTXT.StateDisabled.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTXT.StateDisabled.Content.Padding = new Padding(8);
            PasswordTXT.TabIndex = 2;
            PasswordTXT.UseSystemPasswordChar = true;
            // 
            // ExitBTN
            // 
            ExitBTN.FlatAppearance.BorderSize = 0;
            ExitBTN.FlatStyle = FlatStyle.Flat;
            ExitBTN.Image = Properties.Resources.Close_Window;
            ExitBTN.Location = new Point(1449, 0);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(22, 23);
            ExitBTN.TabIndex = 8;
            ExitBTN.UseVisualStyleBackColor = true;
            ExitBTN.Click += ExitBTN_Click;
            // 
            // LoginBTN
            // 
            LoginBTN.Cursor = Cursors.Hand;
            LoginBTN.Location = new Point(575, 511);
            LoginBTN.Name = "LoginBTN";
            LoginBTN.Size = new Size(331, 40);
            LoginBTN.StateCommon.Back.Color1 = Color.FromArgb(192, 255, 255);
            LoginBTN.StateCommon.Back.Color2 = Color.DarkSlateGray;
            LoginBTN.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginBTN.StateCommon.Border.Rounding = 10F;
            LoginBTN.StateCommon.Content.ShortText.Color1 = Color.Black;
            LoginBTN.StateCommon.Content.ShortText.Color2 = Color.Black;
            LoginBTN.StateCommon.Content.ShortText.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginBTN.StateDisabled.Back.Color1 = Color.FromArgb(192, 255, 255);
            LoginBTN.StateDisabled.Back.Color2 = Color.DarkSlateGray;
            LoginBTN.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginBTN.StateDisabled.Border.Rounding = 10F;
            LoginBTN.StateNormal.Back.Color1 = Color.FromArgb(192, 255, 255);
            LoginBTN.StateNormal.Back.Color2 = Color.DarkSlateGray;
            LoginBTN.StatePressed.Back.Color1 = Color.DarkSlateGray;
            LoginBTN.StatePressed.Back.Color2 = Color.DarkSlateGray;
            LoginBTN.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            LoginBTN.StatePressed.Border.Rounding = 10F;
            LoginBTN.StatePressed.Content.ShortText.Color1 = Color.White;
            LoginBTN.StatePressed.Content.ShortText.Color2 = Color.White;
            LoginBTN.StateTracking.Back.Color1 = Color.FromArgb(192, 255, 255);
            LoginBTN.StateTracking.Back.Color2 = Color.DarkSlateGray;
            LoginBTN.TabIndex = 4;
            LoginBTN.Values.Text = "LOGIN";
            LoginBTN.Click += LoginBTN_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(489, 130);
            label3.Name = "label3";
            label3.Size = new Size(559, 36);
            label3.TabIndex = 11;
            label3.Text = "UNIVERSITY LIBRARY MANAGEMENT SYSTEM";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(641, 220);
            label4.Name = "label4";
            label4.Size = new Size(215, 26);
            label4.TabIndex = 12;
            label4.Text = "LOGIN YOUR ACCOUNT";
            // 
            // SignInLabel
            // 
            SignInLabel.AutoSize = true;
            SignInLabel.Cursor = Cursors.Hand;
            SignInLabel.FlatStyle = FlatStyle.System;
            SignInLabel.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignInLabel.ForeColor = Color.Red;
            SignInLabel.Location = new Point(684, 570);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(114, 19);
            SignInLabel.TabIndex = 5;
            SignInLabel.Text = "ADMIN SIGN IN";
            SignInLabel.Click += SignInLabel_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.abstract_water_ocean_wave_background;
            pictureBox2.Location = new Point(0, 640);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1473, 233);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // ShowPassCB
            // 
            ShowPassCB.AutoSize = true;
            ShowPassCB.Location = new Point(587, 449);
            ShowPassCB.Name = "ShowPassCB";
            ShowPassCB.Size = new Size(108, 19);
            ShowPassCB.TabIndex = 3;
            ShowPassCB.Text = "Show Password";
            ShowPassCB.UseVisualStyleBackColor = true;
            ShowPassCB.CheckedChanged += ShowPassCB_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(684, 573);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 17;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Male_User;
            pictureBox1.Location = new Point(544, 308);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Password;
            pictureBox3.Location = new Point(544, 392);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1473, 873);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(ShowPassCB);
            Controls.Add(label3);
            Controls.Add(ExitBTN);
            Controls.Add(SignInLabel);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(LoginBTN);
            Controls.Add(PasswordTXT);
            Controls.Add(UsernameTXT);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox UsernameTXT;
        private Krypton.Toolkit.KryptonTextBox PasswordTXT;
        private Button ExitBTN;
        private Krypton.Toolkit.KryptonButton LoginBTN;
        private Label label3;
        private Label label4;
        private Label SignInLabel;
        private PictureBox pictureBox2;
        private CheckBox ShowPassCB;
        private Label label5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}