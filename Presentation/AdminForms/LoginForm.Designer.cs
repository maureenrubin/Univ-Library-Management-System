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
            label1 = new Label();
            UsernameTXT = new Krypton.Toolkit.KryptonTextBox();
            PasswordTXT = new Krypton.Toolkit.KryptonTextBox();
            label2 = new Label();
            ExitBTN = new Button();
            LoginBTN = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label4 = new Label();
            SignInLabel = new Label();
            pictureBox2 = new PictureBox();
            ShowPassCB = new CheckBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(575, 274);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 4;
            label1.Text = "username";
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
            UsernameTXT.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTXT.StateCommon.Content.Padding = new Padding(8);
            UsernameTXT.StateDisabled.Back.Color1 = Color.White;
            UsernameTXT.StateDisabled.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameTXT.StateDisabled.Content.Padding = new Padding(8);
            UsernameTXT.TabIndex = 5;
            // 
            // PasswordTXT
            // 
            PasswordTXT.Cursor = Cursors.IBeam;
            PasswordTXT.Location = new Point(575, 403);
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
            PasswordTXT.StateCommon.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTXT.StateCommon.Content.Padding = new Padding(8);
            PasswordTXT.StateDisabled.Back.Color1 = Color.White;
            PasswordTXT.StateDisabled.Content.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTXT.StateDisabled.Content.Padding = new Padding(8);
            PasswordTXT.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(575, 381);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 7;
            label2.Text = "password";
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
            LoginBTN.TabIndex = 10;
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
            SignInLabel.Location = new Point(788, 570);
            SignInLabel.Name = "SignInLabel";
            SignInLabel.Size = new Size(61, 19);
            SignInLabel.TabIndex = 13;
            SignInLabel.Text = "SIGN IN";
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
            ShowPassCB.TabIndex = 16;
            ShowPassCB.Text = "Show Password";
            ShowPassCB.UseVisualStyleBackColor = true;
            ShowPassCB.CheckedChanged += ShowPassCB_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.System;
            label5.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(628, 573);
            label5.Name = "label5";
            label5.Size = new Size(154, 16);
            label5.TabIndex = 17;
            label5.Text = "doesn't have an account?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(1473, 873);
            Controls.Add(label5);
            Controls.Add(ShowPassCB);
            Controls.Add(label3);
            Controls.Add(ExitBTN);
            Controls.Add(SignInLabel);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(LoginBTN);
            Controls.Add(label2);
            Controls.Add(PasswordTXT);
            Controls.Add(UsernameTXT);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Krypton.Toolkit.KryptonTextBox UsernameTXT;
        private Krypton.Toolkit.KryptonTextBox PasswordTXT;
        private Label label2;
        private Button ExitBTN;
        private Krypton.Toolkit.KryptonButton LoginBTN;
        private Label label3;
        private Label label4;
        private Label SignInLabel;
        private PictureBox pictureBox2;
        private CheckBox ShowPassCB;
        private Label label5;
    }
}