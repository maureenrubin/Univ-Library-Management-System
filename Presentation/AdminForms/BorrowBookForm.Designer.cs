namespace LibraryManagementSystem.Presentation.AdminForms
{
    partial class BorrowBookForm
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
            ExitBTN = new Button();
            BookPB = new PictureBox();
            label1 = new Label();
            label = new Label();
            BookIdLBL = new Label();
            label2 = new Label();
            label4 = new Label();
            BarrowDateLBL = new Label();
            label3 = new Label();
            DueDateLBL = new Label();
            label5 = new Label();
            BarrowedPriceLBL = new Label();
            BorrowPanel = new Panel();
            BarrowBookBTN = new Krypton.Toolkit.KryptonButton();
            CancelBarrowBTN = new Krypton.Toolkit.KryptonButton();
            labeel = new Label();
            StockLBL = new Label();
            BookTitle = new Label();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            QuantityTXT = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)BookPB).BeginInit();
            BorrowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ExitBTN
            // 
            ExitBTN.FlatAppearance.BorderSize = 0;
            ExitBTN.FlatStyle = FlatStyle.Flat;
            ExitBTN.Image = Properties.Resources.Close_Window;
            ExitBTN.Location = new Point(788, 3);
            ExitBTN.Name = "ExitBTN";
            ExitBTN.Size = new Size(22, 23);
            ExitBTN.TabIndex = 9;
            ExitBTN.UseVisualStyleBackColor = true;
            ExitBTN.Click += ExitBTN_Click_1;
            // 
            // BookPB
            // 
            BookPB.Location = new Point(75, 103);
            BookPB.Name = "BookPB";
            BookPB.Size = new Size(164, 189);
            BookPB.SizeMode = PictureBoxSizeMode.Zoom;
            BookPB.TabIndex = 10;
            BookPB.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(312, 20);
            label1.Name = "label1";
            label1.Size = new Size(194, 19);
            label1.TabIndex = 17;
            label1.Text = "BORROW BOOK DETAILS";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ActiveCaptionText;
            label.Location = new Point(267, 113);
            label.Name = "label";
            label.Size = new Size(54, 16);
            label.TabIndex = 18;
            label.Text = "Book Id:";
            // 
            // BookIdLBL
            // 
            BookIdLBL.AutoSize = true;
            BookIdLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BookIdLBL.ForeColor = SystemColors.ActiveCaptionText;
            BookIdLBL.Location = new Point(345, 112);
            BookIdLBL.Name = "BookIdLBL";
            BookIdLBL.Size = new Size(36, 17);
            BookIdLBL.TabIndex = 19;
            BookIdLBL.Text = "1000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(267, 145);
            label2.Name = "label2";
            label2.Size = new Size(67, 16);
            label2.TabIndex = 20;
            label2.Text = "Book Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(264, 176);
            label4.Name = "label4";
            label4.Size = new Size(97, 16);
            label4.TabIndex = 22;
            label4.Text = "Barrowed Date:";
            // 
            // BarrowDateLBL
            // 
            BarrowDateLBL.AutoSize = true;
            BarrowDateLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BarrowDateLBL.ForeColor = SystemColors.ActiveCaptionText;
            BarrowDateLBL.Location = new Point(367, 176);
            BarrowDateLBL.Name = "BarrowDateLBL";
            BarrowDateLBL.Size = new Size(74, 17);
            BarrowDateLBL.TabIndex = 23;
            BarrowDateLBL.Text = "mm/dd/yy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(267, 207);
            label3.Name = "label3";
            label3.Size = new Size(64, 16);
            label3.TabIndex = 24;
            label3.Text = "Due Date:";
            // 
            // DueDateLBL
            // 
            DueDateLBL.AutoSize = true;
            DueDateLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            DueDateLBL.ForeColor = SystemColors.ActiveCaptionText;
            DueDateLBL.Location = new Point(345, 207);
            DueDateLBL.Name = "DueDateLBL";
            DueDateLBL.Size = new Size(74, 17);
            DueDateLBL.TabIndex = 25;
            DueDateLBL.Text = "mm/dd/yy";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(267, 241);
            label5.Name = "label5";
            label5.Size = new Size(98, 16);
            label5.TabIndex = 26;
            label5.Text = "Barrowed Price:";
            // 
            // BarrowedPriceLBL
            // 
            BarrowedPriceLBL.AutoSize = true;
            BarrowedPriceLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BarrowedPriceLBL.ForeColor = SystemColors.ActiveCaptionText;
            BarrowedPriceLBL.Location = new Point(379, 241);
            BarrowedPriceLBL.Name = "BarrowedPriceLBL";
            BarrowedPriceLBL.Size = new Size(40, 17);
            BarrowedPriceLBL.TabIndex = 27;
            BarrowedPriceLBL.Text = "10.00";
            // 
            // BorrowPanel
            // 
            BorrowPanel.BackColor = SystemColors.ControlLight;
            BorrowPanel.Controls.Add(BarrowBookBTN);
            BorrowPanel.Controls.Add(ExitBTN);
            BorrowPanel.Controls.Add(CancelBarrowBTN);
            BorrowPanel.Controls.Add(labeel);
            BorrowPanel.Controls.Add(StockLBL);
            BorrowPanel.Controls.Add(BookTitle);
            BorrowPanel.Controls.Add(dateTimePicker1);
            BorrowPanel.Controls.Add(label9);
            BorrowPanel.Controls.Add(label8);
            BorrowPanel.Controls.Add(QuantityTXT);
            BorrowPanel.Controls.Add(BarrowedPriceLBL);
            BorrowPanel.Controls.Add(label5);
            BorrowPanel.Controls.Add(BookPB);
            BorrowPanel.Controls.Add(DueDateLBL);
            BorrowPanel.Controls.Add(label1);
            BorrowPanel.Controls.Add(label3);
            BorrowPanel.Controls.Add(label);
            BorrowPanel.Controls.Add(BarrowDateLBL);
            BorrowPanel.Controls.Add(BookIdLBL);
            BorrowPanel.Controls.Add(label4);
            BorrowPanel.Controls.Add(label2);
            BorrowPanel.Dock = DockStyle.Top;
            BorrowPanel.Location = new Point(0, 0);
            BorrowPanel.Name = "BorrowPanel";
            BorrowPanel.Size = new Size(813, 365);
            BorrowPanel.TabIndex = 29;
            // 
            // BarrowBookBTN
            // 
            BarrowBookBTN.Cursor = Cursors.Hand;
            BarrowBookBTN.Location = new Point(643, 276);
            BarrowBookBTN.Name = "BarrowBookBTN";
            BarrowBookBTN.Size = new Size(125, 38);
            BarrowBookBTN.StateCommon.Back.Color1 = Color.MediumSeaGreen;
            BarrowBookBTN.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            BarrowBookBTN.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BarrowBookBTN.StateCommon.Border.Rounding = 6F;
            BarrowBookBTN.StateCommon.Content.ShortText.Color1 = Color.Black;
            BarrowBookBTN.StateCommon.Content.ShortText.Color2 = Color.Black;
            BarrowBookBTN.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BarrowBookBTN.TabIndex = 32;
            BarrowBookBTN.Values.Text = "BARROW NOW!";
            BarrowBookBTN.Click += BarrowBookBTN_Click;
            // 
            // CancelBarrowBTN
            // 
            CancelBarrowBTN.Location = new Point(496, 276);
            CancelBarrowBTN.Name = "CancelBarrowBTN";
            CancelBarrowBTN.Size = new Size(125, 38);
            CancelBarrowBTN.StateCommon.Back.Color1 = Color.Firebrick;
            CancelBarrowBTN.StateCommon.Back.Color2 = Color.Firebrick;
            CancelBarrowBTN.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBarrowBTN.StateCommon.Border.Rounding = 6F;
            CancelBarrowBTN.StateCommon.Content.ShortText.Color1 = Color.Black;
            CancelBarrowBTN.StateCommon.Content.ShortText.Color2 = Color.Black;
            CancelBarrowBTN.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBarrowBTN.TabIndex = 31;
            CancelBarrowBTN.Values.Text = "CANCEL";
            // 
            // labeel
            // 
            labeel.AutoSize = true;
            labeel.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labeel.ForeColor = SystemColors.ActiveCaptionText;
            labeel.Location = new Point(267, 276);
            labeel.Name = "labeel";
            labeel.Size = new Size(74, 16);
            labeel.TabIndex = 34;
            labeel.Text = "Book Stock:";
            // 
            // StockLBL
            // 
            StockLBL.AutoSize = true;
            StockLBL.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            StockLBL.ForeColor = SystemColors.ActiveCaptionText;
            StockLBL.Location = new Point(379, 276);
            StockLBL.Name = "StockLBL";
            StockLBL.Size = new Size(15, 17);
            StockLBL.TabIndex = 35;
            StockLBL.Text = "0";
            // 
            // BookTitle
            // 
            BookTitle.AutoSize = true;
            BookTitle.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BookTitle.ForeColor = SystemColors.ActiveCaptionText;
            BookTitle.Location = new Point(347, 145);
            BookTitle.Name = "BookTitle";
            BookTitle.Size = new Size(74, 17);
            BookTitle.TabIndex = 33;
            BookTitle.Text = "mm/dd/yy";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(585, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(510, 112);
            label9.Name = "label9";
            label9.Size = new Size(64, 16);
            label9.TabIndex = 35;
            label9.Text = "Due Date:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(510, 167);
            label8.Name = "label8";
            label8.Size = new Size(58, 16);
            label8.TabIndex = 34;
            label8.Text = "Quantity:";
            // 
            // QuantityTXT
            // 
            QuantityTXT.Cursor = Cursors.IBeam;
            QuantityTXT.Location = new Point(585, 158);
            QuantityTXT.Name = "QuantityTXT";
            QuantityTXT.Size = new Size(160, 34);
            QuantityTXT.StateActive.Back.Color1 = Color.White;
            QuantityTXT.StateActive.Border.Color1 = Color.Black;
            QuantityTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            QuantityTXT.StateActive.Border.Rounding = 10F;
            QuantityTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            QuantityTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTXT.StateActive.Content.Padding = new Padding(5);
            QuantityTXT.StateCommon.Back.Color1 = Color.White;
            QuantityTXT.StateCommon.Border.Color1 = Color.Black;
            QuantityTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            QuantityTXT.StateCommon.Border.Rounding = 10F;
            QuantityTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            QuantityTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTXT.StateCommon.Content.Padding = new Padding(5);
            QuantityTXT.StateDisabled.Back.Color1 = Color.White;
            QuantityTXT.StateDisabled.Border.Color1 = Color.Black;
            QuantityTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            QuantityTXT.StateDisabled.Border.Rounding = 10F;
            QuantityTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            QuantityTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            QuantityTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            QuantityTXT.StateNormal.Border.Rounding = 10F;
            QuantityTXT.StateNormal.Border.Width = 10;
            QuantityTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            QuantityTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            QuantityTXT.StateNormal.Content.Padding = new Padding(5);
            QuantityTXT.TabIndex = 30;
            // 
            // BorrowBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 366);
            Controls.Add(BorrowPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowBookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BarrowBookForm";
            ((System.ComponentModel.ISupportInitialize)BookPB).EndInit();
            BorrowPanel.ResumeLayout(false);
            BorrowPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ExitBTN;
        private PictureBox BookPB;
        private Label BarrowedDateLBL;
        private Label QuantityLBL;
        private Krypton.Toolkit.KryptonTextBox QuantityTXT;
        private Krypton.Toolkit.KryptonTextBox DueDateTXT;
        private Label label1;
        private Label label;
        private Label BookIdLBL;
        private Label label2;
        private Label BooksTitleTXT;
        private Label label4;
        private Label BarrowDateLBL;
        private Label label3;
        private Label DueDateLBL;
        private Label label5;
        private Label BarrowedPriceLBL;
        private Panel BorrowPanel;
        private Krypton.Toolkit.KryptonButton CancelBarrowBTN;
        private Krypton.Toolkit.KryptonButton BarrowBookBTN;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label BookTitle;
        private Label BooksTitlesLBL;
        private Label labeel;
        private Label StockLBL;
    }
}