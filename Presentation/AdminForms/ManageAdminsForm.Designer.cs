namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class ManageAdminsForm
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
            AdminsFLP = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // AdminsFLP
            // 
            AdminsFLP.Location = new Point(40, 24);
            AdminsFLP.Name = "AdminsFLP";
            AdminsFLP.Size = new Size(1281, 708);
            AdminsFLP.TabIndex = 0;
            // 
            // ManageAdminsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 756);
            Controls.Add(AdminsFLP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAdminsForm";
            Text = "ManageAdminsForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel AdminsFLP;
    }
}