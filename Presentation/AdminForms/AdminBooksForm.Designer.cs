﻿namespace LibraryManagementSystem.Presentation.AdminForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBooksForm));
            BooksPanel = new Panel();
            panel1 = new Panel();
            label6 = new Label();
            BooksCategoryTXT = new Krypton.Toolkit.KryptonTextBox();
            BrowseImageBtn = new Button();
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
            SaveBooksBtn = new Krypton.Toolkit.KryptonButton();
            BooksTitleTXT = new Krypton.Toolkit.KryptonTextBox();
            DeleteBookBtn = new Krypton.Toolkit.KryptonButton();
            EditBookBtn = new Krypton.Toolkit.KryptonButton();
            AddBookBtn = new Krypton.Toolkit.KryptonButton();
            ManageBooksBTN = new Button();
            panel2 = new Panel();
            BooksFLP = new FlowLayoutPanel();
            BooksPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BooksPB).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // BooksPanel
            // 
            BooksPanel.BackColor = Color.LavenderBlush;
            BooksPanel.Controls.Add(panel1);
            BooksPanel.Controls.Add(DeleteBookBtn);
            BooksPanel.Controls.Add(EditBookBtn);
            BooksPanel.Controls.Add(AddBookBtn);
            BooksPanel.Controls.Add(ManageBooksBTN);
            BooksPanel.Location = new Point(12, 12);
            BooksPanel.Name = "BooksPanel";
            BooksPanel.Size = new Size(31, 777);
            BooksPanel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Thistle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(BooksCategoryTXT);
            panel1.Controls.Add(BrowseImageBtn);
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
            panel1.Controls.Add(SaveBooksBtn);
            panel1.Controls.Add(BooksTitleTXT);
            panel1.Location = new Point(259, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 762);
            panel1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(409, 427);
            label6.Name = "label6";
            label6.Size = new Size(58, 16);
            label6.TabIndex = 19;
            label6.Text = "Category:";
            // 
            // BooksCategoryTXT
            // 
            BooksCategoryTXT.Cursor = Cursors.IBeam;
            BooksCategoryTXT.Location = new Point(499, 418);
            BooksCategoryTXT.Name = "BooksCategoryTXT";
            BooksCategoryTXT.Size = new Size(219, 34);
            BooksCategoryTXT.StateActive.Back.Color1 = Color.White;
            BooksCategoryTXT.StateActive.Border.Color1 = Color.Black;
            BooksCategoryTXT.StateActive.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksCategoryTXT.StateActive.Border.Rounding = 10F;
            BooksCategoryTXT.StateActive.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksCategoryTXT.StateActive.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksCategoryTXT.StateActive.Content.Padding = new Padding(5);
            BooksCategoryTXT.StateCommon.Back.Color1 = Color.White;
            BooksCategoryTXT.StateCommon.Border.Color1 = Color.Black;
            BooksCategoryTXT.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksCategoryTXT.StateCommon.Border.Rounding = 10F;
            BooksCategoryTXT.StateCommon.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksCategoryTXT.StateCommon.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksCategoryTXT.StateCommon.Content.Padding = new Padding(5);
            BooksCategoryTXT.StateDisabled.Back.Color1 = Color.White;
            BooksCategoryTXT.StateDisabled.Border.Color1 = Color.Black;
            BooksCategoryTXT.StateDisabled.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksCategoryTXT.StateDisabled.Border.Rounding = 10F;
            BooksCategoryTXT.StateDisabled.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksCategoryTXT.StateDisabled.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksCategoryTXT.StateNormal.Back.Color1 = Color.FromArgb(224, 224, 224);
            BooksCategoryTXT.StateNormal.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            BooksCategoryTXT.StateNormal.Border.Rounding = 10F;
            BooksCategoryTXT.StateNormal.Border.Width = 10;
            BooksCategoryTXT.StateNormal.Content.Color1 = Color.FromArgb(64, 64, 64);
            BooksCategoryTXT.StateNormal.Content.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BooksCategoryTXT.StateNormal.Content.Padding = new Padding(5);
            BooksCategoryTXT.TabIndex = 18;
            // 
            // BrowseImageBtn
            // 
            BrowseImageBtn.Cursor = Cursors.Hand;
            BrowseImageBtn.FlatAppearance.BorderSize = 0;
            BrowseImageBtn.FlatStyle = FlatStyle.Popup;
            BrowseImageBtn.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            BrowseImageBtn.Location = new Point(84, 362);
            BrowseImageBtn.Name = "BrowseImageBtn";
            BrowseImageBtn.Size = new Size(224, 27);
            BrowseImageBtn.TabIndex = 17;
            BrowseImageBtn.Text = "Browse Image";
            BrowseImageBtn.UseVisualStyleBackColor = true;
            BrowseImageBtn.Click += BrowseImageBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(148, 472);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 16;
            label5.Text = "Published Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(409, 348);
            label4.Name = "label4";
            label4.Size = new Size(44, 16);
            label4.TabIndex = 15;
            label4.Text = "Stocks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(409, 267);
            label3.Name = "label3";
            label3.Size = new Size(36, 16);
            label3.TabIndex = 14;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(408, 187);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 13;
            label2.Text = "Genre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gadugi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(409, 111);
            label1.Name = "label1";
            label1.Size = new Size(33, 16);
            label1.TabIndex = 12;
            label1.Text = "Title:";
            // 
            // BooksPB
            // 
            BooksPB.Location = new Point(106, 120);
            BooksPB.Name = "BooksPB";
            BooksPB.Size = new Size(174, 221);
            BooksPB.SizeMode = PictureBoxSizeMode.Zoom;
            BooksPB.TabIndex = 11;
            BooksPB.TabStop = false;
            // 
            // PublisedDateTime
            // 
            PublisedDateTime.Cursor = Cursors.Hand;
            PublisedDateTime.Location = new Point(84, 491);
            PublisedDateTime.Name = "PublisedDateTime";
            PublisedDateTime.Size = new Size(224, 23);
            PublisedDateTime.TabIndex = 10;
            // 
            // BooksStocksTXT
            // 
            BooksStocksTXT.Cursor = Cursors.IBeam;
            BooksStocksTXT.Location = new Point(499, 339);
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
            BooksStocksTXT.TabIndex = 9;
            // 
            // BooksPriceTXT
            // 
            BooksPriceTXT.Cursor = Cursors.IBeam;
            BooksPriceTXT.Location = new Point(499, 258);
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
            BooksPriceTXT.TabIndex = 8;
            // 
            // BooksGenreTXT
            // 
            BooksGenreTXT.Cursor = Cursors.IBeam;
            BooksGenreTXT.Location = new Point(499, 178);
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
            BooksGenreTXT.TabIndex = 7;
            // 
            // CancelBtn
            // 
            CancelBtn.Cursor = Cursors.Hand;
            CancelBtn.Location = new Point(601, 710);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(135, 34);
            CancelBtn.StateCommon.Back.Color1 = Color.Crimson;
            CancelBtn.StateCommon.Back.Color2 = Color.Crimson;
            CancelBtn.StateCommon.Border.Color1 = Color.Black;
            CancelBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            CancelBtn.StateCommon.Border.Rounding = 6F;
            CancelBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            CancelBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            CancelBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            CancelBtn.TabIndex = 6;
            CancelBtn.Values.Text = "CANCEL";
            // 
            // SaveBooksBtn
            // 
            SaveBooksBtn.Cursor = Cursors.Hand;
            SaveBooksBtn.Location = new Point(742, 710);
            SaveBooksBtn.Name = "SaveBooksBtn";
            SaveBooksBtn.Size = new Size(135, 34);
            SaveBooksBtn.StateCommon.Back.Color1 = Color.RoyalBlue;
            SaveBooksBtn.StateCommon.Back.Color2 = Color.RoyalBlue;
            SaveBooksBtn.StateCommon.Border.Color1 = Color.Black;
            SaveBooksBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            SaveBooksBtn.StateCommon.Border.Rounding = 6F;
            SaveBooksBtn.StateCommon.Content.ShortText.Color1 = Color.Black;
            SaveBooksBtn.StateCommon.Content.ShortText.Color2 = Color.Black;
            SaveBooksBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            SaveBooksBtn.TabIndex = 5;
            SaveBooksBtn.Values.Text = "SAVE";
            SaveBooksBtn.Click += SaveBooksBtn_Click;
            // 
            // BooksTitleTXT
            // 
            BooksTitleTXT.Cursor = Cursors.IBeam;
            BooksTitleTXT.Location = new Point(499, 102);
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
            BooksTitleTXT.TabIndex = 3;
            // 
            // DeleteBookBtn
            // 
            DeleteBookBtn.Location = new Point(40, 365);
            DeleteBookBtn.Name = "DeleteBookBtn";
            DeleteBookBtn.Size = new Size(164, 42);
            DeleteBookBtn.StateCommon.Back.Color1 = Color.DarkSlateBlue;
            DeleteBookBtn.StateCommon.Back.Color2 = Color.DarkSlateBlue;
            DeleteBookBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            DeleteBookBtn.StateCommon.Border.Rounding = 6F;
            DeleteBookBtn.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            DeleteBookBtn.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            DeleteBookBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBookBtn.TabIndex = 3;
            DeleteBookBtn.Values.Text = "DELETE BOOK";
            // 
            // EditBookBtn
            // 
            EditBookBtn.Location = new Point(40, 302);
            EditBookBtn.Name = "EditBookBtn";
            EditBookBtn.Size = new Size(164, 42);
            EditBookBtn.StateCommon.Back.Color1 = Color.DarkSlateBlue;
            EditBookBtn.StateCommon.Back.Color2 = Color.DarkSlateBlue;
            EditBookBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            EditBookBtn.StateCommon.Border.Rounding = 6F;
            EditBookBtn.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            EditBookBtn.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            EditBookBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            EditBookBtn.TabIndex = 2;
            EditBookBtn.Values.Text = "EDIT BOOK";
            // 
            // AddBookBtn
            // 
            AddBookBtn.Cursor = Cursors.Hand;
            AddBookBtn.Location = new Point(40, 232);
            AddBookBtn.Name = "AddBookBtn";
            AddBookBtn.Size = new Size(164, 42);
            AddBookBtn.StateCommon.Back.Color1 = Color.DarkSlateBlue;
            AddBookBtn.StateCommon.Back.Color2 = Color.DarkSlateBlue;
            AddBookBtn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            AddBookBtn.StateCommon.Border.Rounding = 6F;
            AddBookBtn.StateCommon.Content.ShortText.Color1 = Color.WhiteSmoke;
            AddBookBtn.StateCommon.Content.ShortText.Color2 = Color.WhiteSmoke;
            AddBookBtn.StateCommon.Content.ShortText.Font = new Font("Gadugi", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            AddBookBtn.TabIndex = 1;
            AddBookBtn.Values.Text = "ADD BOOK";
            AddBookBtn.Click += AddBookBtn_Click;
            // 
            // ManageBooksBTN
            // 
            ManageBooksBTN.Cursor = Cursors.Hand;
            ManageBooksBTN.FlatAppearance.BorderSize = 0;
            ManageBooksBTN.FlatStyle = FlatStyle.Flat;
            ManageBooksBTN.Image = (Image)resources.GetObject("ManageBooksBTN.Image");
            ManageBooksBTN.Location = new Point(3, 3);
            ManageBooksBTN.Name = "ManageBooksBTN";
            ManageBooksBTN.Size = new Size(25, 28);
            ManageBooksBTN.TabIndex = 0;
            ManageBooksBTN.UseVisualStyleBackColor = true;
            ManageBooksBTN.Click += ManageBooksBTN_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(BooksFLP);
            panel2.Location = new Point(46, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(1378, 771);
            panel2.TabIndex = 1;
            // 
            // BooksFLP
            // 
            BooksFLP.BackColor = Color.LightCyan;
            BooksFLP.Location = new Point(3, 3);
            BooksFLP.Name = "BooksFLP";
            BooksFLP.Size = new Size(1372, 765);
            BooksFLP.TabIndex = 0;
            // 
            // AdminBooksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1436, 795);
            Controls.Add(BooksPanel);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminBooksForm";
            Text = "AdminBooks";
            BooksPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BooksPB).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel BooksPanel;
        private Panel panel2;
        private FlowLayoutPanel BooksFLP;
        private Button ManageBooksBTN;
        private Krypton.Toolkit.KryptonButton AddBookBtn;
        private Krypton.Toolkit.KryptonButton DeleteBookBtn;
        private Krypton.Toolkit.KryptonButton EditBookBtn;
        private Panel panel1;
        private Krypton.Toolkit.KryptonTextBox BooksTitleTXT;
        private Krypton.Toolkit.KryptonButton CancelBtn;
        private Krypton.Toolkit.KryptonButton SaveBooksBtn;
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
        private Krypton.Toolkit.KryptonTextBox BooksCategoryTXT;
    }
}