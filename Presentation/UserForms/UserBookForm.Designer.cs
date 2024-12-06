namespace LibraryManagementSystem.Presentation.UserForms
{
    partial class UserBookForm
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
            UserBooksFLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // UserBooksFLP
            // 
            UserBooksFLP.Location = new Point(30, 35);
            UserBooksFLP.Name = "UserBooksFLP";
            UserBooksFLP.Size = new Size(1375, 680);
            UserBooksFLP.TabIndex = 0;
            // 
            // UserBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 131, 110);
            ClientSize = new Size(1441, 766);
            Controls.Add(UserBooksFLP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserBookForm";
            Text = "UserBookForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel UserBooksFLP;
    }
}