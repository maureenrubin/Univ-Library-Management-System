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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBooksForm));
            BooksPanel = new Panel();
            panel1 = new Panel();
            BookCategoryCB = new ComboBox();
            bookCategoryEntityBindingSource = new BindingSource(components);
            label6 = new Label();
            DeleteBookBtn = new Krypton.Toolkit.KryptonButton();
            UpdateBookBtn = new Krypton.Toolkit.KryptonButton();
            BrowseImageBtn = new Button();
            AddBookBtn = new Krypton.Toolkit.KryptonButton();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            BooksPB = new PictureBox();
            PublisedDateTime = new DateTimePicker();
            BooksStocksTXT = new Krypton.Toolkit.KryptonTextBox();
            BooksPriceTXT = new Krypton.Toolkit.KryptonTextBox();
            BooksGenreTXT = new Krypton.Toolkit.KryptonTextBox();
            CancelBtn = new Krypton.Toolkit.KryptonButton();
            BooksTitleTXT = new Krypton.Toolkit.KryptonTextBox();
            ManageBooksBTN = new Button();
            panel2 = new Panel();
            BooksFLP = new FlowLayoutPanel();
            BooksPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookCategoryEntityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BooksPB).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BooksPanel
            // 
            BooksPanel.BackColor = Color.FromArgb(152, 96, 64);
            BooksPanel.Controls.Add(panel1);
            BooksPanel.Controls.Add(ManageBooksBTN);
            BooksPanel.Location = new Point(12, 132);
            BooksPanel.Name = "BooksPanel";
            BooksPanel.Size = new Size(881, 611);
            BooksPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 144, 116);
            panel1.Controls.Add(BookCategoryCB);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(DeleteBookBtn);
            panel1.Controls.Add(UpdateBookBtn);
            panel1.Controls.Add(BrowseImageBtn);
            panel1.Controls.Add(AddBookBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BooksPB);
            panel1.Controls.Add(PublisedDateTime);
            panel1.Controls.Add(BooksStocksTXT);
            panel1.Controls.Add(BooksPriceTXT);
            panel1.Controls.Add(BooksGenreTXT);
            panel1.Controls.Add(CancelBtn);
            panel1.Controls.Add(BooksTitleTXT);
            panel1.Location = new Point(56, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 577);
            panel1.TabIndex = 4;
            // 
            // BookCategoryCB
            // 
            BookCategoryCB.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BookCategoryCB.FormattingEnabled = true;
            BookCategoryCB.Location = new Point(498, 377);
            BookCategoryCB.Name = "BookCategoryCB";
            BookCategoryCB.Size = new Size(219, 27);
            BookCategoryCB.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(408, 388);
            label6.Name = "label6";
            label6.Size = new Size(58, 16);
            label6.TabIndex = 19;
            label6.Text = "Category:";
            // 
            // DeleteBookBtn
            // 
            DeleteBookBtn.Location = new Point(524, 495);
            DeleteBookBtn.Name = "DeleteBookBtn";
            DeleteBookBtn.Size = new Size(164, 42);
            DeleteBookBtn.StateCommon.Back.Color1 = Color.Firebrick;
            DeleteBookBtn.StateCommon.Back.Color2 = Color.Firebrick;
            DeleteBookBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DeleteBookBtn.StateCommon.Border.Rounding = 6F;
            DeleteBookBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            DeleteBookBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            DeleteBookBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBookBtn.TabIndex = 3;
            DeleteBookBtn.Values.Text = "DELETE BOOK";
            DeleteBookBtn.Click += DeleteBookBtn_Click;
            // 
            // UpdateBookBtn
            // 
            UpdateBookBtn.Location = new Point(313, 495);
            UpdateBookBtn.Name = "UpdateBookBtn";
            UpdateBookBtn.Size = new Size(164, 42);
            UpdateBookBtn.StateCommon.Back.Color1 = Color.Turquoise;
            UpdateBookBtn.StateCommon.Back.Color2 = Color.Turquoise;
            UpdateBookBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            UpdateBookBtn.StateCommon.Border.Rounding = 6F;
            UpdateBookBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            UpdateBookBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            UpdateBookBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateBookBtn.TabIndex = 2;
            UpdateBookBtn.Values.Text = "UPDATE BOOK";
            UpdateBookBtn.Click += UpdateBookBtn_Click;
            // 
            // BrowseImageBtn
            // 
            BrowseImageBtn.Cursor = Cursors.Hand;
            BrowseImageBtn.FlatAppearance.BorderSize = 0;
            BrowseImageBtn.FlatStyle = FlatStyle.Popup;
            BrowseImageBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseImageBtn.Location = new Point(84, 328);
            BrowseImageBtn.Name = "BrowseImageBtn";
            BrowseImageBtn.Size = new Size(224, 27);
            BrowseImageBtn.TabIndex = 9;
            BrowseImageBtn.Text = "Browse Image";
            BrowseImageBtn.UseVisualStyleBackColor = true;
            BrowseImageBtn.Click += BrowseImageBtn_Click;
            // 
            // AddBookBtn
            // 
            AddBookBtn.Cursor = Cursors.Hand;
            AddBookBtn.Location = new Point(106, 495);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(164, 42);
            AddBookBtn.StateCommon.Back.Color1 = Color.MediumSeaGreen;
            AddBookBtn.StateCommon.Back.Color2 = Color.MediumSeaGreen;
            AddBookBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddBookBtn.StateCommon.Border.Rounding = 6F;
            AddBookBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            AddBookBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            AddBookBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddBookBtn.TabIndex = 1;
            AddBookBtn.Values.Text = "ADD BOOK";
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(148, 397);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 16;
            label5.Text = "Published Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(408, 309);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 15;
            label4.Text = "Stocks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(408, 228);
            label3.Name = "label3";
            label3.Size = new Size(36, 16);
            label3.TabIndex = 14;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(407, 148);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 13;
            label2.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(408, 72);
            label1.Name = "label1";
            label1.Size = new Size(33, 16);
            label1.TabIndex = 12;
            label1.Text = "Title:";
            // 
            // BooksPB
            // 
            BooksPB.Location = new Point(106, 86);
            BooksPB.Name = "BooksPB";
            BooksPB.Size = new Size(174, 221);
            BooksPB.SizeMode = PictureBoxSizeMode.Zoom;
            BooksPB.TabIndex = 11;
            BooksPB.TabStop = false;
            // 
            // PublisedDateTime
            // 
            PublisedDateTime.Cursor = Cursors.Hand;
            PublisedDateTime.Location = new Point(84, 416);
            PublisedDateTime.Name = "PublisedDateTime";
            PublisedDateTime.Size = new Size(224, 23);
            PublisedDateTime.TabIndex = 6;
            // 
            // BooksStocksTXT
            // 
            BooksStocksTXT.Cursor = Cursors.IBeam;
            BooksStocksTXT.Location = new Point(498, 291);
            BooksStocksTXT.Name = "BooksStocksTXT";
            BooksStocksTXT.Size = new Size(219, 34);
            BooksStocksTXT.StateActive.Back.Color1 = Color.White;
            BooksStocksTXT.StateActive.Border.Color1 = Color.Black;
            BooksStocksTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksStocksTXT.StateActive.Border.Rounding = 10F;
            BooksStocksTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksStocksTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksStocksTXT.StateActive.Content.Padding = new Padding(5);
            BooksStocksTXT.StateCommon.Back.Color1 = Color.White;
            BooksStocksTXT.StateCommon.Border.Color1 = Color.Black;
            BooksStocksTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksStocksTXT.StateCommon.Border.Rounding = 10F;
            BooksStocksTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksStocksTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksStocksTXT.StateCommon.Content.Padding = new Padding(5);
            BooksStocksTXT.StateDisabled.Back.Color1 = Color.White;
            BooksStocksTXT.StateDisabled.Border.Color1 = Color.Black;
            BooksStocksTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksStocksTXT.StateDisabled.Border.Rounding = 10F;
            BooksStocksTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksStocksTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksStocksTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            BooksStocksTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksStocksTXT.StateNormal.Border.Rounding = 10F;
            BooksStocksTXT.StateNormal.Border.Width = 10;
            BooksStocksTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksStocksTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksStocksTXT.StateNormal.Content.Padding = new Padding(5);
            BooksStocksTXT.TabIndex = 4;
            // 
            // BooksPriceTXT
            // 
            BooksPriceTXT.Cursor = Cursors.IBeam;
            BooksPriceTXT.Location = new Point(498, 219);
            BooksPriceTXT.Name = "BooksPriceTXT";
            BooksPriceTXT.Size = new Size(219, 34);
            BooksPriceTXT.StateActive.Back.Color1 = Color.White;
            BooksPriceTXT.StateActive.Border.Color1 = Color.Black;
            BooksPriceTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksPriceTXT.StateActive.Border.Rounding = 10F;
            BooksPriceTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksPriceTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksPriceTXT.StateActive.Content.Padding = new Padding(5);
            BooksPriceTXT.StateCommon.Back.Color1 = Color.White;
            BooksPriceTXT.StateCommon.Border.Color1 = Color.Black;
            BooksPriceTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksPriceTXT.StateCommon.Border.Rounding = 10F;
            BooksPriceTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksPriceTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksPriceTXT.StateCommon.Content.Padding = new Padding(5);
            BooksPriceTXT.StateDisabled.Back.Color1 = Color.White;
            BooksPriceTXT.StateDisabled.Border.Color1 = Color.Black;
            BooksPriceTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksPriceTXT.StateDisabled.Border.Rounding = 10F;
            BooksPriceTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksPriceTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksPriceTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            BooksPriceTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksPriceTXT.StateNormal.Border.Rounding = 10F;
            BooksPriceTXT.StateNormal.Border.Width = 10;
            BooksPriceTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksPriceTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksPriceTXT.StateNormal.Content.Padding = new Padding(5);
            BooksPriceTXT.TabIndex = 3;
            // 
            // BooksGenreTXT
            // 
            BooksGenreTXT.Cursor = Cursors.IBeam;
            BooksGenreTXT.Location = new Point(498, 130);
            BooksGenreTXT.Name = "BooksGenreTXT";
            BooksGenreTXT.Size = new Size(219, 34);
            BooksGenreTXT.StateActive.Back.Color1 = Color.White;
            BooksGenreTXT.StateActive.Border.Color1 = Color.Black;
            BooksGenreTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksGenreTXT.StateActive.Border.Rounding = 10F;
            BooksGenreTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksGenreTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksGenreTXT.StateActive.Content.Padding = new Padding(5);
            BooksGenreTXT.StateCommon.Back.Color1 = Color.White;
            BooksGenreTXT.StateCommon.Border.Color1 = Color.Black;
            BooksGenreTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksGenreTXT.StateCommon.Border.Rounding = 10F;
            BooksGenreTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksGenreTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksGenreTXT.StateCommon.Content.Padding = new Padding(5);
            BooksGenreTXT.StateDisabled.Back.Color1 = Color.White;
            BooksGenreTXT.StateDisabled.Border.Color1 = Color.Black;
            BooksGenreTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksGenreTXT.StateDisabled.Border.Rounding = 10F;
            BooksGenreTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksGenreTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksGenreTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            BooksGenreTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksGenreTXT.StateNormal.Border.Rounding = 10F;
            BooksGenreTXT.StateNormal.Border.Width = 10;
            BooksGenreTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksGenreTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksGenreTXT.StateNormal.Content.Padding = new Padding(5);
            BooksGenreTXT.TabIndex = 2;
            // 
            // CancelBtn
            // 
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.Location = new Point(33, 35);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(157, 30);
            CancelBtn.StateCommon.Back.Color1 = Color.Crimson;
            CancelBtn.StateCommon.Back.Color2 = Color.Crimson;
            CancelBtn.StateCommon.Border.Color1 = Color.Black;
            CancelBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBtn.StateCommon.Border.Rounding = 6F;
            CancelBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            CancelBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            CancelBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.TabIndex = 8;
            CancelBtn.Values.Text = "CANCEL";
            // 
            // BooksTitleTXT
            // 
            BooksTitleTXT.Cursor = Cursors.IBeam;
            BooksTitleTXT.Location = new Point(498, 63);
            BooksTitleTXT.Name = "BooksTitleTXT";
            BooksTitleTXT.Size = new Size(219, 34);
            BooksTitleTXT.StateActive.Back.Color1 = Color.White;
            BooksTitleTXT.StateActive.Border.Color1 = Color.Black;
            BooksTitleTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksTitleTXT.StateActive.Border.Rounding = 10F;
            BooksTitleTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksTitleTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksTitleTXT.StateActive.Content.Padding = new Padding(5);
            BooksTitleTXT.StateCommon.Back.Color1 = Color.White;
            BooksTitleTXT.StateCommon.Border.Color1 = Color.Black;
            BooksTitleTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksTitleTXT.StateCommon.Border.Rounding = 10F;
            BooksTitleTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksTitleTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksTitleTXT.StateCommon.Content.Padding = new Padding(5);
            BooksTitleTXT.StateDisabled.Back.Color1 = Color.White;
            BooksTitleTXT.StateDisabled.Border.Color1 = Color.Black;
            BooksTitleTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksTitleTXT.StateDisabled.Border.Rounding = 10F;
            BooksTitleTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksTitleTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksTitleTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            BooksTitleTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksTitleTXT.StateNormal.Border.Rounding = 10F;
            BooksTitleTXT.StateNormal.Border.Width = 10;
            BooksTitleTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksTitleTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksTitleTXT.StateNormal.Content.Padding = new Padding(5);
            BooksTitleTXT.TabIndex = 1;
            // 
            // ManageBooksBTN
            // 
            ManageBooksBTN.Cursor = Cursors.Hand;
            ManageBooksBTN.FlatAppearance.BorderSize = 0;
            ManageBooksBTN.FlatStyle = FlatStyle.Flat;
            ManageBooksBTN.Image = (Image)resources.GetObject("ManageBooksBTN.Image");
            ManageBooksBTN.Location = new Point(3, 3);
            ManageBooksBTN.Name = "ManageBooksBTN";
            ManageBooksBTN.Size = new Size(44, 47);
            ManageBooksBTN.TabIndex = 0;
            ManageBooksBTN.UseVisualStyleBackColor = true;
            ManageBooksBTN.Click += ManageBooksBTN_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(169, 131, 110);
            panel2.Controls.Add(BooksFLP);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(65, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1371, 795);
            panel2.TabIndex = 1;
            // 
            // BooksFLP
            // 
            BooksFLP.AutoScroll = true;
            BooksFLP.BackColor = Color.FromArgb(169, 131, 110);
            BooksFLP.Location = new Point(25, 73);
            BooksFLP.Name = "BooksFLP";
            BooksFLP.Size = new Size(1304, 688);
            BooksFLP.TabIndex = 0;
            // 
            // AdminBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(152, 96, 64);
            ClientSize = new Size(1436, 795);
            Controls.Add(BooksPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminBooksForm";
            Text = "AdminBooks";
            BooksPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookCategoryEntityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)BooksPB).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BooksPanel;
        private Panel panel2;
        private Button ManageBooksBTN;
        private Krypton.Toolkit.KryptonButton AddBookBtn;
        private Krypton.Toolkit.KryptonButton DeleteBookBtn;
        private Krypton.Toolkit.KryptonButton UpdateBookBtn;
        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox BooksTitleTXT;
        private Krypton.Toolkit.KryptonButton CancelBtn;
        private Krypton.Toolkit.KryptonTextBox BooksPriceTXT;
        private Krypton.Toolkit.KryptonTextBox BooksGenreTXT;
        private Label label2;
        private Label label1;
        private PictureBox BooksPB;
        private DateTimePicker PublisedDateTime;
        private Krypton.Toolkit.KryptonTextBox BooksStocksTXT;
        private Label label4;
        private Label label3;
        private Button BrowseImageBtn;
        private Label label5;
        private Label label6;
        private FlowLayoutPanel BooksFLP;
        private ComboBox BookCategoryCB;
        private BindingSource bookCategoryEntityBindingSource;
    }
}