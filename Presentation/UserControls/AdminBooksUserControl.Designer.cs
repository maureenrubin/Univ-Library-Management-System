namespace LibraryManagementSystem.Presentation
{
    partial class AdminBooksUserControl
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
            ((System.ComponentModel.ISupportInitialize)BooksPB).BeginInit();
            SuspendLayout();
            // 
            // BooksPB
            // 
            BooksPB.Location = new Point(20, 16);
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
            BooksTitleLbl.Location = new Point(20, 218);
            BooksTitleLbl.Name = "BooksTitleLbl";
            BooksTitleLbl.Size = new Size(77, 17);
            BooksTitleLbl.TabIndex = 1;
            BooksTitleLbl.Text = "Books Title";
            // 
            // BooksGenreLbl
            // 
            BooksGenreLbl.AutoSize = true;
            BooksGenreLbl.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksGenreLbl.Location = new Point(268, 42);
            BooksGenreLbl.Name = "BooksGenreLbl";
            BooksGenreLbl.Size = new Size(38, 16);
            BooksGenreLbl.TabIndex = 2;
            BooksGenreLbl.Text = "Genre";
            // 
            // PublishedDate
            // 
            PublishedDate.AutoSize = true;
            PublishedDate.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PublishedDate.Location = new Point(268, 119);
            PublishedDate.Name = "PublishedDate";
            PublishedDate.Size = new Size(65, 16);
            PublishedDate.TabIndex = 3;
            PublishedDate.Text = "11/24/2024";
            // 
            // BooksStockLbl
            // 
            BooksStockLbl.AutoSize = true;
            BooksStockLbl.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksStockLbl.Location = new Point(268, 73);
            BooksStockLbl.Name = "BooksStockLbl";
            BooksStockLbl.Size = new Size(25, 16);
            BooksStockLbl.TabIndex = 4;
            BooksStockLbl.Text = "143";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(204, 42);
            label1.Name = "label1";
            label1.Size = new Size(46, 16);
            label1.TabIndex = 5;
            label1.Text = "GENRE:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(204, 103);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 6;
            label2.Text = "PUBLISHED \r\nDATE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(204, 73);
            label3.Name = "label3";
            label3.Size = new Size(53, 16);
            label3.TabIndex = 7;
            label3.Text = "STOCKS:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(204, 150);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 8;
            label4.Text = "PRICE:";
            // 
            // BooksPriceLbl
            // 
            BooksPriceLbl.AutoSize = true;
            BooksPriceLbl.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksPriceLbl.Location = new Point(268, 150);
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
            BarrowBtn.Location = new Point(204, 208);
            BarrowBtn.Name = "BarrowBtn";
            BarrowBtn.Size = new Size(129, 38);
            BarrowBtn.TabIndex = 10;
            BarrowBtn.Text = "Barrow Book";
            BarrowBtn.UseVisualStyleBackColor = false;
            // 
            // AdminBooksUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BarrowBtn);
            Controls.Add(BooksPriceLbl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BooksStockLbl);
            Controls.Add(PublishedDate);
            Controls.Add(BooksGenreLbl);
            Controls.Add(BooksTitleLbl);
            Controls.Add(BooksPB);
            Name = "AdminBooksUserControl";
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
    }
}
