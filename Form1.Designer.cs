namespace BookCatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            panel1 = new Panel();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            butt_login = new Button();
            label4 = new Label();
            butt_exit = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 258);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.cat;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(173, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(89, 94);
            panel1.TabIndex = 2;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_username.Location = new Point(120, 256);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(247, 26);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_password.Location = new Point(120, 321);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(247, 26);
            txt_password.TabIndex = 5;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 323);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 4;
            label1.Text = "Password:";
            // 
            // butt_login
            // 
            butt_login.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_login.Location = new Point(273, 362);
            butt_login.Name = "butt_login";
            butt_login.Size = new Size(94, 29);
            butt_login.TabIndex = 6;
            butt_login.Text = "Login";
            butt_login.UseVisualStyleBackColor = true;
            butt_login.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 159);
            label4.Name = "label4";
            label4.Size = new Size(178, 34);
            label4.TabIndex = 9;
            label4.Text = "Book Library ";
            // 
            // butt_exit
            // 
            butt_exit.BackColor = SystemColors.AppWorkspace;
            butt_exit.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            butt_exit.Location = new Point(413, 12);
            butt_exit.Name = "butt_exit";
            butt_exit.Size = new Size(33, 29);
            butt_exit.TabIndex = 10;
            butt_exit.Text = "X";
            butt_exit.UseVisualStyleBackColor = false;
            butt_exit.Click += butt_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 547);
            Controls.Add(butt_exit);
            Controls.Add(label4);
            Controls.Add(butt_login);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label1;
        private Button butt_login;
        private Label label4;
        private Button butt_exit;
    }
}
