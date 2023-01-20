namespace TestLibrary
{
    partial class Dashboard
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
            this.dbBooks = new System.Windows.Forms.DataGridView();
            this.pbBookImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.tbISBM = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAuthorFirstName = new System.Windows.Forms.TextBox();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAuthorLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCategory = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dtDatePublished = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.plBookTable = new System.Windows.Forms.Panel();
            this.plBorrowBook = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dbBorrowTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSignout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).BeginInit();
            this.plBookTable.SuspendLayout();
            this.plBorrowBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBorrowTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbBooks
            // 
            this.dbBooks.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dbBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbBooks.ColumnHeadersHeight = 34;
            this.dbBooks.GridColor = System.Drawing.Color.Gainsboro;
            this.dbBooks.Location = new System.Drawing.Point(402, 23);
            this.dbBooks.Name = "dbBooks";
            this.dbBooks.ReadOnly = true;
            this.dbBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dbBooks.RowTemplate.Height = 40;
            this.dbBooks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dbBooks.Size = new System.Drawing.Size(526, 480);
            this.dbBooks.TabIndex = 0;
            this.dbBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbBooks_CellClick);
            this.dbBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbBooks_CellContentClick);
            // 
            // pbBookImage
            // 
            this.pbBookImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbBookImage.Location = new System.Drawing.Point(155, 293);
            this.pbBookImage.Name = "pbBookImage";
            this.pbBookImage.Size = new System.Drawing.Size(199, 213);
            this.pbBookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBookImage.TabIndex = 22;
            this.pbBookImage.TabStop = false;
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.BackColor = System.Drawing.Color.White;
            this.btnBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseImage.Location = new System.Drawing.Point(154, 528);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(200, 42);
            this.btnBrowseImage.TabIndex = 21;
            this.btnBrowseImage.Text = "Browse";
            this.btnBrowseImage.UseVisualStyleBackColor = false;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(105, 28);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(33, 13);
            this.Id.TabIndex = 20;
            this.Id.Text = "ISBM";
            // 
            // tbISBM
            // 
            this.tbISBM.Location = new System.Drawing.Point(154, 23);
            this.tbISBM.Name = "tbISBM";
            this.tbISBM.Size = new System.Drawing.Size(200, 20);
            this.tbISBM.TabIndex = 19;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Black;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(402, 526);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(156, 44);
            this.btnInsert.TabIndex = 18;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Author Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book Name";
            // 
            // tbAuthorFirstName
            // 
            this.tbAuthorFirstName.Location = new System.Drawing.Point(154, 101);
            this.tbAuthorFirstName.Name = "tbAuthorFirstName";
            this.tbAuthorFirstName.Size = new System.Drawing.Size(200, 20);
            this.tbAuthorFirstName.TabIndex = 15;
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(154, 62);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(200, 20);
            this.tbBookName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Author First Name";
            // 
            // tbAuthorLastName
            // 
            this.tbAuthorLastName.Location = new System.Drawing.Point(154, 140);
            this.tbAuthorLastName.Name = "tbAuthorLastName";
            this.tbAuthorLastName.Size = new System.Drawing.Size(200, 20);
            this.tbAuthorLastName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date Published";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Category";
            // 
            // tbCategory
            // 
            this.tbCategory.Location = new System.Drawing.Point(154, 179);
            this.tbCategory.Name = "tbCategory";
            this.tbCategory.Size = new System.Drawing.Size(200, 20);
            this.tbCategory.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(154, 257);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 20);
            this.tbQuantity.TabIndex = 29;
            // 
            // dtDatePublished
            // 
            this.dtDatePublished.Location = new System.Drawing.Point(154, 218);
            this.dtDatePublished.Name = "dtDatePublished";
            this.dtDatePublished.Size = new System.Drawing.Size(200, 20);
            this.dtDatePublished.TabIndex = 32;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(564, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 44);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(726, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 44);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // plBookTable
            // 
            this.plBookTable.Controls.Add(this.btnUpdate);
            this.plBookTable.Controls.Add(this.btnDelete);
            this.plBookTable.Controls.Add(this.dtDatePublished);
            this.plBookTable.Controls.Add(this.label7);
            this.plBookTable.Controls.Add(this.tbQuantity);
            this.plBookTable.Controls.Add(this.label3);
            this.plBookTable.Controls.Add(this.tbAuthorLastName);
            this.plBookTable.Controls.Add(this.label4);
            this.plBookTable.Controls.Add(this.label5);
            this.plBookTable.Controls.Add(this.tbCategory);
            this.plBookTable.Controls.Add(this.pbBookImage);
            this.plBookTable.Controls.Add(this.btnBrowseImage);
            this.plBookTable.Controls.Add(this.Id);
            this.plBookTable.Controls.Add(this.tbISBM);
            this.plBookTable.Controls.Add(this.btnInsert);
            this.plBookTable.Controls.Add(this.label2);
            this.plBookTable.Controls.Add(this.label1);
            this.plBookTable.Controls.Add(this.tbAuthorFirstName);
            this.plBookTable.Controls.Add(this.tbBookName);
            this.plBookTable.Controls.Add(this.dbBooks);
            this.plBookTable.Location = new System.Drawing.Point(251, 3);
            this.plBookTable.Name = "plBookTable";
            this.plBookTable.Size = new System.Drawing.Size(957, 598);
            this.plBookTable.TabIndex = 35;
            this.plBookTable.Paint += new System.Windows.Forms.PaintEventHandler(this.plBookTable_Paint);
            // 
            // plBorrowBook
            // 
            this.plBorrowBook.Controls.Add(this.label6);
            this.plBorrowBook.Controls.Add(this.dbBorrowTable);
            this.plBorrowBook.Location = new System.Drawing.Point(251, 0);
            this.plBorrowBook.Name = "plBorrowBook";
            this.plBorrowBook.Size = new System.Drawing.Size(957, 598);
            this.plBorrowBook.TabIndex = 36;
            this.plBorrowBook.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Borrowed Books";
            // 
            // dbBorrowTable
            // 
            this.dbBorrowTable.BackgroundColor = System.Drawing.Color.White;
            this.dbBorrowTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbBorrowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbBorrowTable.Location = new System.Drawing.Point(46, 107);
            this.dbBorrowTable.Name = "dbBorrowTable";
            this.dbBorrowTable.ReadOnly = true;
            this.dbBorrowTable.Size = new System.Drawing.Size(882, 440);
            this.dbBorrowTable.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnSignout);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 601);
            this.panel2.TabIndex = 37;
            // 
            // btnSignout
            // 
            this.btnSignout.BackColor = System.Drawing.Color.White;
            this.btnSignout.Location = new System.Drawing.Point(7, 275);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(238, 50);
            this.btnSignout.TabIndex = 2;
            this.btnSignout.Text = "Signout";
            this.btnSignout.UseVisualStyleBackColor = false;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(7, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "Borrowed Books";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Books";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1208, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.plBookTable);
            this.Controls.Add(this.plBorrowBook);
            this.Name = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookImage)).EndInit();
            this.plBookTable.ResumeLayout(false);
            this.plBookTable.PerformLayout();
            this.plBorrowBook.ResumeLayout(false);
            this.plBorrowBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbBorrowTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbBooks;
        private System.Windows.Forms.PictureBox pbBookImage;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox tbISBM;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAuthorFirstName;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAuthorLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.DateTimePicker dtDatePublished;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel plBookTable;
        private System.Windows.Forms.Panel plBorrowBook;
        private System.Windows.Forms.DataGridView dbBorrowTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSignout;
    }
}