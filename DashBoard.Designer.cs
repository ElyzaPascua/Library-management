namespace BookCatalog
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            butt_addBooks = new Button();
            butt_viewBooks = new Button();
            butt_exit = new Button();
            label4 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // butt_addBooks
            // 
            butt_addBooks.BackColor = SystemColors.ActiveBorder;
            butt_addBooks.Font = new Font("Tahoma", 10.8F);
            butt_addBooks.Location = new Point(148, 233);
            butt_addBooks.Name = "butt_addBooks";
            butt_addBooks.Size = new Size(149, 55);
            butt_addBooks.TabIndex = 0;
            butt_addBooks.Text = "Add Book";
            butt_addBooks.UseVisualStyleBackColor = false;
            butt_addBooks.Click += button1_Click;
            // 
            // butt_viewBooks
            // 
            butt_viewBooks.BackColor = SystemColors.ActiveBorder;
            butt_viewBooks.Font = new Font("Tahoma", 10.8F);
            butt_viewBooks.Location = new Point(148, 315);
            butt_viewBooks.Name = "butt_viewBooks";
            butt_viewBooks.Size = new Size(149, 55);
            butt_viewBooks.TabIndex = 4;
            butt_viewBooks.Text = "View Books";
            butt_viewBooks.UseVisualStyleBackColor = false;
            butt_viewBooks.Click += butt_viewBooks_Click;
            // 
            // butt_exit
            // 
            butt_exit.BackColor = SystemColors.ActiveBorder;
            butt_exit.Font = new Font("Tahoma", 10.8F);
            butt_exit.Location = new Point(148, 398);
            butt_exit.Name = "butt_exit";
            butt_exit.Size = new Size(149, 55);
            butt_exit.TabIndex = 5;
            butt_exit.Text = "Exit";
            butt_exit.UseVisualStyleBackColor = false;
            butt_exit.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveBorder;
            label4.Location = new Point(135, 159);
            label4.Name = "label4";
            label4.Size = new Size(178, 34);
            label4.TabIndex = 11;
            label4.Text = "Book Library ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.cat;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(178, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 94);
            panel1.TabIndex = 10;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(458, 547);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(butt_exit);
            Controls.Add(butt_viewBooks);
            Controls.Add(butt_addBooks);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DashBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += DashBoard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butt_addBooks;
        private Button butt_viewBooks;
        private Button butt_exit;
        private Label label4;
        private Panel panel1;
    }
}