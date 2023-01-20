namespace TestLibrary
{
    partial class Form2
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
            this.lbBookName = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbIsbm = new System.Windows.Forms.Label();
            this.lbDatePublished = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbAuthorFirstName = new System.Windows.Forms.Label();
            this.lbAuthorLastName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBookName
            // 
            this.lbBookName.AutoSize = true;
            this.lbBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookName.ForeColor = System.Drawing.Color.Black;
            this.lbBookName.Location = new System.Drawing.Point(307, 101);
            this.lbBookName.Name = "lbBookName";
            this.lbBookName.Size = new System.Drawing.Size(118, 24);
            this.lbBookName.TabIndex = 0;
            this.lbBookName.Text = "Book Name";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(309, 171);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(68, 18);
            this.lbCategory.TabIndex = 1;
            this.lbCategory.Text = "Category";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(312, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Borrow Book";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbIsbm
            // 
            this.lbIsbm.AutoSize = true;
            this.lbIsbm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIsbm.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbIsbm.Location = new System.Drawing.Point(309, 72);
            this.lbIsbm.Name = "lbIsbm";
            this.lbIsbm.Size = new System.Drawing.Size(34, 15);
            this.lbIsbm.TabIndex = 4;
            this.lbIsbm.Text = "Isbm";
            // 
            // lbDatePublished
            // 
            this.lbDatePublished.AutoSize = true;
            this.lbDatePublished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatePublished.Location = new System.Drawing.Point(309, 208);
            this.lbDatePublished.Name = "lbDatePublished";
            this.lbDatePublished.Size = new System.Drawing.Size(107, 18);
            this.lbDatePublished.TabIndex = 7;
            this.lbDatePublished.Text = "Date Published";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.Location = new System.Drawing.Point(380, 243);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(62, 18);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "Quantity";
            this.lbQuantity.Click += new System.EventHandler(this.lbQuantity_Click);
            // 
            // lbAuthorFirstName
            // 
            this.lbAuthorFirstName.AutoSize = true;
            this.lbAuthorFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthorFirstName.Location = new System.Drawing.Point(309, 140);
            this.lbAuthorFirstName.Name = "lbAuthorFirstName";
            this.lbAuthorFirstName.Size = new System.Drawing.Size(95, 18);
            this.lbAuthorFirstName.TabIndex = 8;
            this.lbAuthorFirstName.Text = "Author Name";
            // 
            // lbAuthorLastName
            // 
            this.lbAuthorLastName.AutoSize = true;
            this.lbAuthorLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthorLastName.Location = new System.Drawing.Point(410, 140);
            this.lbAuthorLastName.Name = "lbAuthorLastName";
            this.lbAuthorLastName.Size = new System.Drawing.Size(95, 18);
            this.lbAuthorLastName.TabIndex = 9;
            this.lbAuthorLastName.Text = "Author Name";
            this.lbAuthorLastName.Click += new System.EventHandler(this.lbAuthorLastName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Quantity:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAuthorLastName);
            this.Controls.Add(this.lbAuthorFirstName);
            this.Controls.Add(this.lbDatePublished);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbIsbm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbBookName);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBookName;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbIsbm;
        private System.Windows.Forms.Label lbDatePublished;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbAuthorFirstName;
        private System.Windows.Forms.Label lbAuthorLastName;
        private System.Windows.Forms.Label label1;
    }
}