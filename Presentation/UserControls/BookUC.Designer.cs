namespace LibraryManagementSystem.Presentation
{
    partial class BookUC
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
            BooksPB = new PictureBox();
            BooksTitleLbl = new Label();
            BooksGenreLbl = new Label();
            PublishedDate = new Label();
            BooksStockLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BooksPriceLbl = new Label();
            BarrowBtn = new Button();
            BooksIdLbl = new Label();
            BookCategoryLbl = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)BooksPB).BeginInit();
            SuspendLayout();
            // 
            // BooksPB
            // 
            BooksPB.Location = new Point(19, 23);
            BooksPB.Name = "BooksPB";
            BooksPB.Size = new Size(164, 189);
            BooksPB.SizeMode = PictureBoxSizeMode.Zoom;
            BooksPB.TabIndex = 0;
            BooksPB.TabStop = false;
            // 
            // BooksTitleLbl
            // 
            BooksTitleLbl.AutoSize = true;
            BooksTitleLbl.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BooksTitleLbl.ForeColor = SystemColors.ActiveCaptionText;
            BooksTitleLbl.Location = new Point(198, 41);
            BooksTitleLbl.Name = "BooksTitleLbl";
            BooksTitleLbl.Size = new Size(77, 17);
            BooksTitleLbl.TabIndex = 1;
            BooksTitleLbl.Text = "Books Title";
            // 
            // BooksGenreLbl
            // 
            BooksGenreLbl.AutoSize = true;
            BooksGenreLbl.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksGenreLbl.ForeColor = SystemColors.ControlLightLight;
            BooksGenreLbl.Location = new Point(262, 73);
            BooksGenreLbl.Name = "BooksGenreLbl";
            BooksGenreLbl.Size = new Size(38, 16);
            BooksGenreLbl.TabIndex = 2;
            BooksGenreLbl.Text = "Genre";
            // 
            // PublishedDate
            // 
            PublishedDate.AutoSize = true;
            PublishedDate.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PublishedDate.ForeColor = SystemColors.ControlLightLight;
            PublishedDate.Location = new Point(262, 150);
            PublishedDate.Name = "PublishedDate";
            PublishedDate.Size = new Size(65, 16);
            PublishedDate.TabIndex = 3;
            PublishedDate.Text = "11/24/2024";
            // 
            // BooksStockLbl
            // 
            BooksStockLbl.AutoSize = true;
            BooksStockLbl.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksStockLbl.ForeColor = SystemColors.ControlLightLight;
            BooksStockLbl.Location = new Point(262, 104);
            BooksStockLbl.Name = "BooksStockLbl";
            BooksStockLbl.Size = new Size(25, 16);
            BooksStockLbl.TabIndex = 4;
            BooksStockLbl.Text = "143";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(198, 73);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 5;
            label1.Text = "GENRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(198, 134);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 6;
            label2.Text = "PUBLISHED \r\nDATE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(198, 104);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 7;
            label3.Text = "STOCKS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(198, 181);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 8;
            label4.Text = "PRICE:";
            // 
            // BooksPriceLbl
            // 
            BooksPriceLbl.AutoSize = true;
            BooksPriceLbl.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksPriceLbl.ForeColor = SystemColors.ControlLightLight;
            BooksPriceLbl.Location = new Point(262, 181);
            BooksPriceLbl.Name = "BooksPriceLbl";
            BooksPriceLbl.Size = new Size(25, 16);
            BooksPriceLbl.TabIndex = 9;
            BooksPriceLbl.Text = "143";
            // 
            // BarrowBtn
            // 
            BarrowBtn.BackColor = Color.MediumSeaGreen;
            BarrowBtn.Cursor = Cursors.Hand;
            BarrowBtn.FlatAppearance.BorderColor = Color.Black;
            BarrowBtn.FlatStyle = FlatStyle.Flat;
            BarrowBtn.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BarrowBtn.Location = new Point(204, 218);
            BarrowBtn.Name = "BarrowBtn";
            BarrowBtn.Size = new Size(129, 38);
            BarrowBtn.TabIndex = 10;
            BarrowBtn.Text = "Barrow Book";
            BarrowBtn.UseVisualStyleBackColor = false;
            // 
            // BooksIdLbl
            // 
            BooksIdLbl.AutoSize = true;
            BooksIdLbl.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksIdLbl.Location = new Point(19, 0);
            BooksIdLbl.Name = "BooksIdLbl";
            BooksIdLbl.Size = new Size(51, 16);
            BooksIdLbl.TabIndex = 12;
            BooksIdLbl.Text = "Book ID:";
            // 
            // BookCategoryLbl
            // 
            BookCategoryLbl.AutoSize = true;
            BookCategoryLbl.Font = new Font("Gadugi", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BookCategoryLbl.ForeColor = SystemColors.ActiveCaptionText;
            BookCategoryLbl.Location = new Point(19, 239);
            BookCategoryLbl.Name = "BookCategoryLbl";
            BookCategoryLbl.Size = new Size(29, 17);
            BookCategoryLbl.TabIndex = 14;
            BookCategoryLbl.Text = "143";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(6, 218);
            label5.Name = "label5";
            label5.Size = new Size(64, 14);
            label5.TabIndex = 15;
            label5.Text = "CATEGORY:";
            // 
            // BookUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(label5);
            Controls.Add(BookCategoryLbl);
            Controls.Add(BooksIdLbl);
            Controls.Add(PublishedDate);
            Controls.Add(BarrowBtn);
            Controls.Add(BooksPriceLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BooksStockLbl);
            Controls.Add(BooksGenreLbl);
            Controls.Add(BooksTitleLbl);
            Controls.Add(BooksPB);
            Name = "BookUC";
            Size = new Size(354, 269);
            ((System.ComponentModel.ISupportInitialize)BooksPB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BooksPB;
        private Label BooksTitleLbl;
        private Label BooksGenreLbl;
        private Label PublishedDate;
        private Label BooksStockLbl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label BooksPriceLbl;
        private Button BarrowBtn;
        private Label BooksIdLbl;
        private Label BookCategoryLbl;
        private Label label5;
    }
}
