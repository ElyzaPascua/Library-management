using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookCatalog
{
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
        }

        private void butt_addBook_Click(object sender, EventArgs e)
        {
            string bname = txtBookTitle.Text;
            string bauthor = txtBookAuthor.Text;
            string dpublished = txtDatePublished.Text;
            string category = txtCategory.Text;
            string isbn = txtISBN.Text;

            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost; uid=root; pwd=080420;database=library";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "INSERT INTO newbook (title, author, dpublished, category, isbn) " +
                  "VALUES ('" + bname + "', '" + bauthor + "', '" + dpublished + "', '" + category + "', '" + isbn + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Book Added!");
            this.Close();
            DashBoard ds = new DashBoard();
            ds.Show();
        }
    }
}
