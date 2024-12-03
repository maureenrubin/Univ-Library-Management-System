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
            ((System.ComponentModel.ISupportInitialize)AdminPicPB).BeginInit();
            SuspendLayout();
            // 
            // AdminPicPB
            // 
            AdminPicPB.Location = new Point(27, 31);
            AdminPicPB.Name = "AdminPicPB";
            AdminPicPB.Size = new Size(163, 178);
            AdminPicPB.SizeMode = PictureBoxSizeMode.Zoom;
            AdminPicPB.TabIndex = 0;
            AdminPicPB.TabStop = false;
            // 
            // AdminFnameTXT
            // 
            AdminFnameTXT.AutoSize = true;
            AdminFnameTXT.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminFnameTXT.Location = new Point(27, 225);
            AdminFnameTXT.Name = "AdminFnameTXT";
            AdminFnameTXT.Size = new Size(45, 17);
            AdminFnameTXT.TabIndex = 1;
            AdminFnameTXT.Text = "label1";
            // 
            // GenderTXT
            // 
            GenderTXT.AutoSize = true;
            GenderTXT.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            GenderTXT.Location = new Point(27, 255);
            GenderTXT.Name = "GenderTXT";
            GenderTXT.Size = new Size(45, 17);
            GenderTXT.TabIndex = 2;
            GenderTXT.Text = "label1";
            // 
            // AdminID
            // 
            AdminID.AutoSize = true;
            AdminID.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminID.Location = new Point(86, 11);
            AdminID.Name = "AdminID";
            AdminID.Size = new Size(45, 17);
            AdminID.TabIndex = 3;
            AdminID.Text = "label1";
            // 
            // AdminLnameTXT
            // 
            AdminLnameTXT.AutoSize = true;
            AdminLnameTXT.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            AdminLnameTXT.Location = new Point(108, 225);
            AdminLnameTXT.Name = "AdminLnameTXT";
            AdminLnameTXT.Size = new Size(45, 17);
            AdminLnameTXT.TabIndex = 4;
            AdminLnameTXT.Text = "label1";
            // 
            // AdminDetailsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AdminLnameTXT);
            Controls.Add(AdminID);
            Controls.Add(GenderTXT);
            Controls.Add(AdminFnameTXT);
            Controls.Add(AdminPicPB);
            Name = "AdminDetailsUC";
            Size = new Size(220, 308);
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
    }
}
