namespace BookCatalog
{
    partial class viewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewBook));
            panel1 = new Panel();
            dgv = new DataGridView();
            butt_refresh = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txtSearch = new TextBox();
            txtDPublished = new TextBox();
            txtISBN = new TextBox();
            label5 = new Label();
            txtCategory = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtBAuthor = new TextBox();
            label2 = new Label();
            txtBTitle = new TextBox();
            label6 = new Label();
            label7 = new Label();
            butt_update = new Button();
            butt_delete = new Button();
            butt_cancel = new Button();
            button5 = new Button();
            butt_download = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(dgv);
            panel1.Controls.Add(butt_refresh);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(-5, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 550);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dgv
            // 
            dgv.BackgroundColor = SystemColors.Control;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(17, 157);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(668, 350);
            dgv.TabIndex = 14;
            dgv.CellContentClick += dgv_CellContentClick;
            // 
            // butt_refresh
            // 
            butt_refresh.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_refresh.Location = new Point(488, 114);
            butt_refresh.Name = "butt_refresh";
            butt_refresh.Size = new Size(94, 29);
            butt_refresh.TabIndex = 13;
            butt_refresh.Text = "Refresh";
            butt_refresh.UseVisualStyleBackColor = true;
            butt_refresh.Click += butt_refresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 118);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 12;
            label1.Text = "Book Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.cat;
            panel2.BackgroundImageLayout = ImageLayout.Center;
            panel2.Location = new Point(259, 14);
            panel2.Name = "panel2";
            panel2.Size = new Size(89, 94);
            panel2.TabIndex = 11;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(168, 114);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtDPublished
            // 
            txtDPublished.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDPublished.Location = new Point(905, 206);
            txtDPublished.Name = "txtDPublished";
            txtDPublished.Size = new Size(244, 26);
            txtDPublished.TabIndex = 33;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtISBN.Location = new Point(905, 306);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(244, 26);
            txtISBN.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(772, 307);
            label5.Name = "label5";
            label5.Size = new Size(52, 21);
            label5.TabIndex = 31;
            label5.Text = "ISBN:";
            // 
            // txtCategory
            // 
            txtCategory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCategory.Location = new Point(905, 256);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(244, 26);
            txtCategory.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(772, 256);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 29;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(772, 206);
            label4.Name = "label4";
            label4.Size = new Size(127, 21);
            label4.TabIndex = 28;
            label4.Text = "Date Published:";
            // 
            // txtBAuthor
            // 
            txtBAuthor.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBAuthor.Location = new Point(905, 155);
            txtBAuthor.Name = "txtBAuthor";
            txtBAuthor.Size = new Size(244, 26);
            txtBAuthor.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(772, 160);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 26;
            label2.Text = "Author:";
            // 
            // txtBTitle
            // 
            txtBTitle.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBTitle.Location = new Point(905, 105);
            txtBTitle.Name = "txtBTitle";
            txtBTitle.Size = new Size(244, 26);
            txtBTitle.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(772, 110);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 24;
            label6.Text = "Book Title:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(811, 12);
            label7.Name = "label7";
            label7.Size = new Size(319, 41);
            label7.TabIndex = 34;
            label7.Text = "Book Information";
            // 
            // butt_update
            // 
            butt_update.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_update.Location = new Point(805, 386);
            butt_update.Name = "butt_update";
            butt_update.Size = new Size(94, 29);
            butt_update.TabIndex = 35;
            butt_update.Text = "Update";
            butt_update.UseVisualStyleBackColor = true;
            butt_update.Click += butt_update_Click;
            // 
            // butt_delete
            // 
            butt_delete.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_delete.Location = new Point(922, 386);
            butt_delete.Name = "butt_delete";
            butt_delete.Size = new Size(94, 29);
            butt_delete.TabIndex = 36;
            butt_delete.Text = "Delete";
            butt_delete.UseVisualStyleBackColor = true;
            butt_delete.Click += butt_delete_Click;
            // 
            // butt_cancel
            // 
            butt_cancel.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_cancel.Location = new Point(1042, 386);
            butt_cancel.Name = "butt_cancel";
            butt_cancel.Size = new Size(94, 29);
            butt_cancel.TabIndex = 37;
            butt_cancel.Text = "Cancel";
            butt_cancel.UseVisualStyleBackColor = true;
            butt_cancel.Click += butt_cancel_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveBorder;
            button5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(1208, 12);
            button5.Name = "button5";
            button5.Size = new Size(29, 29);
            button5.TabIndex = 36;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // butt_download
            // 
            butt_download.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_download.Location = new Point(1042, 445);
            butt_download.Name = "butt_download";
            butt_download.Size = new Size(94, 29);
            butt_download.TabIndex = 40;
            butt_download.Text = "Download";
            butt_download.UseVisualStyleBackColor = true;
            butt_download.Click += butt_download_Click;
            // 
            // viewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 543);
            Controls.Add(butt_download);
            Controls.Add(button5);
            Controls.Add(butt_cancel);
            Controls.Add(butt_delete);
            Controls.Add(butt_update);
            Controls.Add(label7);
            Controls.Add(txtDPublished);
            Controls.Add(txtISBN);
            Controls.Add(label5);
            Controls.Add(txtCategory);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtBAuthor);
            Controls.Add(label2);
            Controls.Add(txtBTitle);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "viewBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "viewBook";
            Load += viewBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtSearch;
        private DataGridView dgv;
        private Button butt_refresh;
        private Label label1;
        private Panel panel2;
        private TextBox txtDPublished;
        private TextBox txtISBN;
        private Label label5;
        private TextBox txtCategory;
        private Label label3;
        private Label label4;
        private TextBox txtBAuthor;
        private Label label2;
        private TextBox txtBTitle;
        private Label label6;
        private Label label7;
        private Button butt_update;
        private Button butt_delete;
        private Button butt_cancel;
        private Button button5;
        private Button butt_download;
    }
}