namespace LibraryManagementSystem.Presentation.UserControls
{
    partial class AdminDetailsUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AdminPicPB = new PictureBox();
            AdminFnameTXT = new Label();
            GenderTXT = new Label();
            AdminID = new Label();
            AdminLnameTXT = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            AdminEmailTXT = new Label();
            label5 = new Label();
            CreatedAtLBL = new Label();
            ((System.ComponentModel.ISupportInitialize)AdminPicPB).BeginInit();
            SuspendLayout();
            // 
            // AdminPicPB
            // 
            AdminPicPB.Location = new Point(27, 31);
            AdminPicPB.Name = "AdminPicPB";
            AdminPicPB.Size = new Size(145, 139);
            AdminPicPB.SizeMode = PictureBoxSizeMode.Zoom;
            AdminPicPB.TabIndex = 0;
            AdminPicPB.TabStop = false;
            // 
            // AdminFnameTXT
            // 
            AdminFnameTXT.AutoSize = true;
            AdminFnameTXT.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminFnameTXT.ForeColor = SystemColors.ControlLightLight;
            AdminFnameTXT.Location = new Point(225, 48);
            AdminFnameTXT.Name = "AdminFnameTXT";
            AdminFnameTXT.Size = new Size(45, 17);
            AdminFnameTXT.TabIndex = 1;
            AdminFnameTXT.Text = "label1";
            // 
            // GenderTXT
            // 
            GenderTXT.AutoSize = true;
            GenderTXT.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GenderTXT.ForeColor = SystemColors.ControlLightLight;
            GenderTXT.Location = new Point(232, 100);
            GenderTXT.Name = "GenderTXT";
            GenderTXT.Size = new Size(38, 16);
            GenderTXT.TabIndex = 2;
            GenderTXT.Text = "label1";
            // 
            // AdminID
            // 
            AdminID.AutoSize = true;
            AdminID.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminID.Location = new Point(71, 11);
            AdminID.Name = "AdminID";
            AdminID.Size = new Size(45, 17);
            AdminID.TabIndex = 3;
            AdminID.Text = "label1";
            // 
            // AdminLnameTXT
            // 
            AdminLnameTXT.AutoSize = true;
            AdminLnameTXT.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLnameTXT.ForeColor = SystemColors.ControlLightLight;
            AdminLnameTXT.Location = new Point(276, 48);
            AdminLnameTXT.Name = "AdminLnameTXT";
            AdminLnameTXT.Size = new Size(45, 17);
            AdminLnameTXT.TabIndex = 4;
            AdminLnameTXT.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 11);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 5;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(186, 50);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(183, 99);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Gender:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(183, 74);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // AdminEmailTXT
            // 
            AdminEmailTXT.AutoSize = true;
            AdminEmailTXT.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AdminEmailTXT.ForeColor = SystemColors.ControlLightLight;
            AdminEmailTXT.Location = new Point(225, 74);
            AdminEmailTXT.Name = "AdminEmailTXT";
            AdminEmailTXT.Size = new Size(38, 16);
            AdminEmailTXT.TabIndex = 9;
            AdminEmailTXT.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(183, 125);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 10;
            label5.Text = "Date Created: ";
            // 
            // CreatedAtLBL
            // 
            CreatedAtLBL.AutoSize = true;
            CreatedAtLBL.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CreatedAtLBL.ForeColor = SystemColors.ControlLightLight;
            CreatedAtLBL.Location = new Point(276, 124);
            CreatedAtLBL.Name = "CreatedAtLBL";
            CreatedAtLBL.Size = new Size(38, 16);
            CreatedAtLBL.TabIndex = 11;
            CreatedAtLBL.Text = "label1";
            // 
            // AdminDetailsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(CreatedAtLBL);
            Controls.Add(label5);
            Controls.Add(AdminLnameTXT);
            Controls.Add(AdminEmailTXT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdminID);
            Controls.Add(GenderTXT);
            Controls.Add(AdminFnameTXT);
            Controls.Add(AdminPicPB);
            Name = "AdminDetailsUC";
            Size = new Size(377, 194);
            ((System.ComponentModel.ISupportInitialize)AdminPicPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox AdminPicPB;
        private Label AdminFnameTXT;
        private Label GenderTXT;
        private Label AdminID;
        private Label AdminLnameTXT;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label AdminEmailTXT;
        private Label label5;
        private Label CreatedAtLBL;
    }
}
