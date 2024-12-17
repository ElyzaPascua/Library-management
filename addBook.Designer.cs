namespace BookCatalog
{
    partial class addBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addBook));
            label1 = new Label();
            panel1 = new Panel();
            txtBookTitle = new TextBox();
            txtBookAuthor = new TextBox();
            label2 = new Label();
            txtCategory = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtISBN = new TextBox();
            label5 = new Label();
            butt_addBook = new Button();
            butt_cancel = new Button();
            txtDatePublished = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 209);
            label1.Name = "label1";
            label1.Size = new Size(90, 21);
            label1.TabIndex = 0;
            label1.Text = "Book Title:";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.cat;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(175, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 94);
            panel1.TabIndex = 11;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookTitle.Location = new Point(155, 204);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(244, 26);
            txtBookTitle.TabIndex = 12;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookAuthor.Location = new Point(155, 254);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(244, 26);
            txtBookAuthor.TabIndex = 14;
            txtBookAuthor.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 259);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 13;
            label2.Text = "Author:";
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.Location = new Point(155, 355);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(244, 26);
            txtCategory.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 355);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 17;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 305);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 15;
            label4.Text = "Date Published:";
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(155, 405);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(244, 26);
            txtISBN.TabIndex = 20;
            txtISBN.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 406);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 19;
            label5.Text = "ISBN:";
            // 
            // butt_addBook
            // 
            butt_addBook.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_addBook.Location = new Point(155, 460);
            butt_addBook.Name = "butt_addBook";
            butt_addBook.Size = new Size(109, 51);
            butt_addBook.TabIndex = 21;
            butt_addBook.Text = "Add Book";
            butt_addBook.UseVisualStyleBackColor = true;
            butt_addBook.Click += butt_addBook_Click;
            // 
            // butt_cancel
            // 
            butt_cancel.BackColor = SystemColors.Control;
            butt_cancel.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_cancel.Location = new Point(270, 460);
            butt_cancel.Name = "butt_cancel";
            butt_cancel.Size = new Size(115, 51);
            butt_cancel.TabIndex = 22;
            butt_cancel.Text = "Cancel";
            butt_cancel.UseVisualStyleBackColor = false;
            butt_cancel.Click += button2_Click;
            // 
            // txtDatePublished
            // 
            txtDatePublished.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDatePublished.Location = new Point(155, 305);
            txtDatePublished.Name = "txtDatePublished";
            txtDatePublished.Size = new Size(244, 26);
            txtDatePublished.TabIndex = 23;
            // 
            // addBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 547);
            Controls.Add(txtDatePublished);
            Controls.Add(butt_cancel);
            Controls.Add(butt_addBook);
            Controls.Add(txtISBN);
            Controls.Add(label5);
            Controls.Add(txtCategory);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtBookAuthor);
            Controls.Add(label2);
            Controls.Add(txtBookTitle);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "addBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txtBookTitle;
        private TextBox txtBookAuthor;
        private Label label2;
        private TextBox txtCategory;
        private Label label3;
        private Label label4;
        private TextBox txtISBN;
        private Label label5;
        private Button butt_addBook;
        private Button butt_cancel;
        private TextBox txtDatePublished;
    }
}