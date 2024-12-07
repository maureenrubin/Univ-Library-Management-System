namespace LibraryManagementSystem.Presentation.UserForms
{
    partial class UserHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHomeForm));
            pictureBox1 = new PictureBox();
            ViewBooksButton = new Krypton.Toolkit.KryptonButton();
            label3 = new Label();
            label2 = new Label();
            HomePanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            HomePanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(504, 791);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // ViewBooksButton
            // 
            ViewBooksButton.Cursor = Cursors.Hand;
            ViewBooksButton.Location = new Point(845, 410);
            ViewBooksButton.Name = "ViewBooksButton";
            ViewBooksButton.Size = new Size(276, 40);
            ViewBooksButton.StateCommon.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateCommon.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StateCommon.Border.Rounding = 10F;
            ViewBooksButton.StateCommon.Content.ShortText.Color1 = Color.Black;
            ViewBooksButton.StateCommon.Content.ShortText.Color2 = Color.Black;
            ViewBooksButton.StateCommon.Content.ShortText.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBooksButton.StateDisabled.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateDisabled.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StateDisabled.Border.Rounding = 10F;
            ViewBooksButton.StateNormal.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateNormal.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateNormal.Border.Color1 = Color.Black;
            ViewBooksButton.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StateNormal.Content.ShortText.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ViewBooksButton.StatePressed.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StatePressed.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ViewBooksButton.StatePressed.Border.Rounding = 10F;
            ViewBooksButton.StatePressed.Content.ShortText.Color1 = Color.White;
            ViewBooksButton.StatePressed.Content.ShortText.Color2 = Color.White;
            ViewBooksButton.StateTracking.Back.Color1 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.StateTracking.Back.Color2 = Color.FromArgb(152, 96, 64);
            ViewBooksButton.TabIndex = 22;
            ViewBooksButton.Values.Text = "View Books Here";
            ViewBooksButton.Click += ViewBooksButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(725, 355);
            label3.Name = "label3";
            label3.Size = new Size(530, 20);
            label3.TabIndex = 21;
            label3.Text = "\"From shelves to screens, it’s all so clear, the library you love is always near.\"";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(675, 217);
            label2.Name = "label2";
            label2.Size = new Size(627, 116);
            label2.TabIndex = 20;
            label2.Text = " UNIVERSITY LIBRARY \r\nMANAGEMENT SYSTEM\r\n";
            // 
            // HomePanel
            // 
            HomePanel.BackColor = Color.LightCyan;
            HomePanel.Controls.Add(pictureBox1);
            HomePanel.Controls.Add(label2);
            HomePanel.Controls.Add(ViewBooksButton);
            HomePanel.Controls.Add(label3);
            HomePanel.Dock = DockStyle.Fill;
            HomePanel.Location = new Point(0, 0);
            HomePanel.Name = "HomePanel";
            HomePanel.Size = new Size(1445, 791);
            HomePanel.TabIndex = 24;
            // 
            // UserHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 791);
            Controls.Add(HomePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserHomeForm";
            Text = "UserHomeForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            HomePanel.ResumeLayout(false);
            HomePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonButton ViewBooksButton;
        private Label label3;
        private Label label2;
        private Panel HomePanel;
    }
}