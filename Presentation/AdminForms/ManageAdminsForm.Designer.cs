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
            button1 = new Button();
            SearchTXT = new Krypton.Toolkit.KryptonTextBox();
            SuspendLayout();
            // 
            // AdminsFLP
            // 
            AdminsFLP.AutoScroll = true;
            AdminsFLP.Location = new Point(28, 81);
            AdminsFLP.Name = "AdminsFLP";
            AdminsFLP.Size = new Size(896, 680);
            AdminsFLP.TabIndex = 0;
            // 
            // AddAdminBTN
            // 
            AddAdminBTN.BackColor = Color.Transparent;
            AddAdminBTN.Cursor = Cursors.Hand;
            AddAdminBTN.FlatAppearance.BorderSize = 0;
            AddAdminBTN.FlatStyle = FlatStyle.Flat;
            AddAdminBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddAdminBTN.ForeColor = Color.MediumBlue;
            AddAdminBTN.Image = (Image)resources.GetObject("AddAdminBTN.Image");
            AddAdminBTN.ImageAlign = ContentAlignment.TopCenter;
            AddAdminBTN.Location = new Point(517, 17);
            AddAdminBTN.Name = "AddAdminBTN";
            AddAdminBTN.Size = new Size(108, 58);
            AddAdminBTN.TabIndex = 10;
            AddAdminBTN.Text = "Add New Admin";
            AddAdminBTN.TextAlign = ContentAlignment.BottomCenter;
            AddAdminBTN.UseVisualStyleBackColor = false;
            AddAdminBTN.Click += AddAdminBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Location = new Point(963, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 680);
            panel1.TabIndex = 11;
            // 
            // RemoveAdminBTN
            // 
            RemoveAdminBTN.BackColor = Color.Transparent;
            RemoveAdminBTN.Cursor = Cursors.Hand;
            RemoveAdminBTN.FlatAppearance.BorderSize = 0;
            RemoveAdminBTN.FlatStyle = FlatStyle.Flat;
            RemoveAdminBTN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveAdminBTN.ForeColor = Color.DarkRed;
            RemoveAdminBTN.Image = (Image)resources.GetObject("RemoveAdminBTN.Image");
            RemoveAdminBTN.ImageAlign = ContentAlignment.TopCenter;
            RemoveAdminBTN.Location = new Point(631, 17);
            RemoveAdminBTN.Name = "RemoveAdminBTN";
            RemoveAdminBTN.Size = new Size(106, 58);
            RemoveAdminBTN.TabIndex = 12;
            RemoveAdminBTN.Text = "Remove Admin";
            RemoveAdminBTN.TextAlign = ContentAlignment.BottomCenter;
            RemoveAdminBTN.UseVisualStyleBackColor = false;
            RemoveAdminBTN.Click += RemoveAdminBTN_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(59, 31);
            button1.Name = "button1";
            button1.Size = new Size(36, 34);
            button1.TabIndex = 18;
            button1.UseVisualStyleBackColor = true;
            // 
            // SearchTXT
            // 
            SearchTXT.Cursor = Cursors.IBeam;
            SearchTXT.Location = new Point(101, 31);
            SearchTXT.Name = "SearchTXT";
            SearchTXT.Size = new Size(381, 34);
            SearchTXT.StateActive.Back.Color1 = Color.White;
            SearchTXT.StateActive.Border.Color1 = Color.Black;
            SearchTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateActive.Border.Rounding = 10F;
            SearchTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateActive.Content.Padding = new Padding(5);
            SearchTXT.StateCommon.Back.Color1 = Color.White;
            SearchTXT.StateCommon.Border.Color1 = Color.Black;
            SearchTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateCommon.Border.Rounding = 10F;
            SearchTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateCommon.Content.Padding = new Padding(5);
            SearchTXT.StateDisabled.Back.Color1 = Color.White;
            SearchTXT.StateDisabled.Border.Color1 = Color.Black;
            SearchTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateDisabled.Border.Rounding = 10F;
            SearchTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            SearchTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SearchTXT.StateNormal.Border.Rounding = 10F;
            SearchTXT.StateNormal.Border.Width = 10;
            SearchTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            SearchTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SearchTXT.StateNormal.Content.Padding = new Padding(5);
            SearchTXT.TabIndex = 19;
            // 
            // ManageAdminsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 131, 110);
            ClientSize = new Size(1446, 810);
            Controls.Add(button1);
            Controls.Add(SearchTXT);
            Controls.Add(RemoveAdminBTN);
            Controls.Add(panel1);
            Controls.Add(AddAdminBTN);
            Controls.Add(AdminsFLP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageAdminsForm";
            Text = "ManageAdminsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel AdminsFLP;
        private Button AddAdminBTN;
        private Panel panel1;
        private Button RemoveAdminBTN;
        private Button button1;
        private Krypton.Toolkit.KryptonTextBox SearchTXT;
    }
}