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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAdminsForm));
            AdminsFLP = new FlowLayoutPanel();
            AddAdminBTN = new Button();
            panel1 = new Panel();
            RemoveAdminBTN = new Button();
            SuspendLayout();
            // 
            // AdminsFLP
            // 
            AdminsFLP.AutoScroll = true;
            AdminsFLP.Location = new Point(40, 76);
            AdminsFLP.Name = "AdminsFLP";
            AdminsFLP.Size = new Size(812, 656);
            AdminsFLP.TabIndex = 0;
            // 
            // AddAdminBTN
            // 
            AddAdminBTN.BackColor = Color.Transparent;
            AddAdminBTN.Cursor = Cursors.Hand;
            AddAdminBTN.FlatAppearance.BorderSize = 0;
            AddAdminBTN.FlatStyle = FlatStyle.Flat;
            AddAdminBTN.Image = (Image)resources.GetObject("AddAdminBTN.Image");
            AddAdminBTN.ImageAlign = ContentAlignment.TopCenter;
            AddAdminBTN.Location = new Point(40, 2);
            AddAdminBTN.Name = "AddAdminBTN";
            AddAdminBTN.Size = new Size(90, 68);
            AddAdminBTN.TabIndex = 10;
            AddAdminBTN.Text = "Add New Administrator";
            AddAdminBTN.TextAlign = ContentAlignment.BottomCenter;
            AddAdminBTN.UseVisualStyleBackColor = false;
            AddAdminBTN.Click += AddAdminBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Location = new Point(894, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 656);
            panel1.TabIndex = 11;
            // 
            // RemoveAdminBTN
            // 
            RemoveAdminBTN.BackColor = Color.Transparent;
            RemoveAdminBTN.Cursor = Cursors.Hand;
            RemoveAdminBTN.FlatAppearance.BorderSize = 0;
            RemoveAdminBTN.FlatStyle = FlatStyle.Flat;
            RemoveAdminBTN.Image = (Image)resources.GetObject("RemoveAdminBTN.Image");
            RemoveAdminBTN.ImageAlign = ContentAlignment.TopCenter;
            RemoveAdminBTN.Location = new Point(136, 2);
            RemoveAdminBTN.Name = "RemoveAdminBTN";
            RemoveAdminBTN.Size = new Size(90, 68);
            RemoveAdminBTN.TabIndex = 12;
            RemoveAdminBTN.Text = "Remove Administrator";
            RemoveAdminBTN.TextAlign = ContentAlignment.BottomCenter;
            RemoveAdminBTN.UseVisualStyleBackColor = false;
            // 
            // ManageAdminsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 756);
            Controls.Add(RemoveAdminBTN);
            Controls.Add(panel1);
            Controls.Add(AddAdminBTN);
            Controls.Add(AdminsFLP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAdminsForm";
            Text = "ManageAdminsForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel AdminsFLP;
        private Button AddAdminBTN;
        private Panel panel1;
        private Button RemoveAdminBTN;
    }
}