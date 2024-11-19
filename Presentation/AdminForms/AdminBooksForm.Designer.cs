namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class AdminBooksForm
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
            flpBooks = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpBooks
            // 
            flpBooks.BackColor = Color.DarkSlateGray;
            flpBooks.Dock = DockStyle.Top;
            flpBooks.Location = new Point(0, 0);
            flpBooks.Name = "flpBooks";
            flpBooks.Size = new Size(1091, 618);
            flpBooks.TabIndex = 0;
            // 
            // AdminBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 743);
            Controls.Add(flpBooks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminBooksForm";
            Text = "AdminBooks";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpBooks;
    }
}