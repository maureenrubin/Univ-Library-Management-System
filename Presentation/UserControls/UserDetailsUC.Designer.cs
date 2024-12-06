namespace LibraryManagementSystem.Presentation.UserControls
{
    partial class UserDetailsUC
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
            StudentProfilePB = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            LblFirstname = new Label();
            LblLastname = new Label();
            LblCourse = new Label();
            StudentID = new Label();
            label5 = new Label();
            LblCreatedAt = new Label();
            ((System.ComponentModel.ISupportInitialize)StudentProfilePB).BeginInit();
            SuspendLayout();
            // 
            // StudentProfilePB
            // 
            StudentProfilePB.Location = new Point(12, 14);
            StudentProfilePB.Name = "StudentProfilePB";
            StudentProfilePB.Size = new Size(65, 74);
            StudentProfilePB.SizeMode = PictureBoxSizeMode.Zoom;
            StudentProfilePB.TabIndex = 0;
            StudentProfilePB.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(78, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 14);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 43);
            label2.Name = "label2";
            label2.Size = new Size(46, 14);
            label2.TabIndex = 2;
            label2.Text = "Course:";
            // 
            // LblFirstname
            // 
            LblFirstname.AutoSize = true;
            LblFirstname.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblFirstname.Location = new Point(119, 29);
            LblFirstname.Name = "LblFirstname";
            LblFirstname.Size = new Size(60, 14);
            LblFirstname.TabIndex = 5;
            LblFirstname.Text = "FirstName";
            // 
            // LblLastname
            // 
            LblLastname.AutoSize = true;
            LblLastname.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblLastname.Location = new Point(182, 29);
            LblLastname.Name = "LblLastname";
            LblLastname.Size = new Size(62, 14);
            LblLastname.TabIndex = 6;
            LblLastname.Text = "LastName:";
            // 
            // LblCourse
            // 
            LblCourse.AutoSize = true;
            LblCourse.Font = new Font("Gadugi", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblCourse.Location = new Point(119, 43);
            LblCourse.Name = "LblCourse";
            LblCourse.Size = new Size(185, 14);
            LblCourse.TabIndex = 9;
            LblCourse.Text = "BS in Inforamtion and Technology";
            // 
            // StudentID
            // 
            StudentID.AutoSize = true;
            StudentID.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            StudentID.Location = new Point(26, 91);
            StudentID.Name = "StudentID";
            StudentID.Size = new Size(35, 16);
            StudentID.TabIndex = 10;
            StudentID.Text = "1000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(78, 60);
            label5.Name = "label5";
            label5.Size = new Size(95, 14);
            label5.TabIndex = 11;
            label5.Text = "Account Created:";
            // 
            // LblCreatedAt
            // 
            LblCreatedAt.AutoSize = true;
            LblCreatedAt.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblCreatedAt.Location = new Point(179, 60);
            LblCreatedAt.Name = "LblCreatedAt";
            LblCreatedAt.Size = new Size(57, 14);
            LblCreatedAt.TabIndex = 12;
            LblCreatedAt.Text = "password";
            // 
            // UserDetailsUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(LblCreatedAt);
            Controls.Add(label5);
            Controls.Add(StudentID);
            Controls.Add(LblCourse);
            Controls.Add(LblLastname);
            Controls.Add(LblFirstname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(StudentProfilePB);
            Name = "UserDetailsUC";
            Size = new Size(306, 115);
            ((System.ComponentModel.ISupportInitialize)StudentProfilePB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox StudentProfilePB;
        private Label label1;
        private Label label2;
        private Label LblFirstname;
        private Label LblLastname;
        private Label LblCourse;
        private Label StudentID;
        private Label label5;
        private Label LblCreatedAt;
    }
}
