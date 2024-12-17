using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BookCatalog
{
    public partial class viewBook : Form
    {
        string connectionString = "Server=localhost;Database=library;Uid=root;Pwd=080420;";
        private System.Windows.Forms.TextBox FilePathTextBox;
        public viewBook()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewBook_Load(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = "server=localhost; uid=root; pwd=080420;database=library";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from newbook";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgv.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();

        }
        int bid;
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgv.Rows[e.RowIndex].Cells[0].Value != null)
            {

                int bid = int.Parse(dgv.Rows[e.RowIndex].Cells["bid"].Value.ToString());


                string connectionString = "server=localhost; uid=root; pwd=080420; database=library";


                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT * FROM newbook WHERE bid = @bid";
                    cmd.Parameters.AddWithValue("@bid", bid);

                    try
                    {
                        con.Open();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);

                        if (ds.Tables[0].Rows.Count > 0)
                        {

                            txtBTitle.Text = ds.Tables[0].Rows[0]["title"].ToString();
                            txtBAuthor.Text = ds.Tables[0].Rows[0]["author"].ToString();
                            txtCategory.Text = ds.Tables[0].Rows[0]["category"].ToString();
                            txtDPublished.Text = ds.Tables[0].Rows[0]["dpublished"].ToString();
                            txtISBN.Text = ds.Tables[0].Rows[0]["isbn"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No record found!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void butt_cancel_Click(object sender, EventArgs e)
        {

            txtBTitle.Text = " ";
            txtBAuthor.Text = " ";
            txtCategory.Text = " ";
            txtDPublished.Text = " ";
            txtISBN.Text = " ";

            dgv.ClearSelection();
        }

        private void butt_refresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = " ";

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                dgv.DataSource = null;
                return;
            }

            using (MySqlConnection con = new MySqlConnection("server=localhost; uid=root; pwd=080420;database=library"))
            {
                try
                {
                    con.Open();


                    string query = "SELECT * FROM newbook WHERE title LIKE @title ORDER BY title";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@title", searchQuery + "%");




                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    if (dt.Rows.Count == 0)
                    {
                        dgv.DataSource = null;

                    }
                    else
                    {
                        dgv.AutoGenerateColumns = true;
                        dgv.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void butt_update_Click(object sender, EventArgs e)
        {

            string newTitle = txtBTitle.Text.Trim();
            string author = txtBAuthor.Text.Trim();
            string published = txtDPublished.Text.Trim();
            string category = txtCategory.Text.Trim();
            string isbn = txtISBN.Text.Trim();


            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }


            if (!int.TryParse(dgv.CurrentRow.Cells["bid"].Value?.ToString(), out int bid))
            {
                MessageBox.Show("Invalid record selected.");
                return;
            }


            if (string.IsNullOrWhiteSpace(newTitle) ||
                string.IsNullOrWhiteSpace(author) ||
                string.IsNullOrWhiteSpace(published) ||
                string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(isbn))
            {
                MessageBox.Show("All fields are required.");
                return;
            }


            string connectionString = "server=localhost; uid=root; pwd=080420; database=library";


            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();


                    string query = @"UPDATE newbook 
                             SET title = @title, 
                                 author = @auth, 
                                 dpublished = @published, 
                                 category = @cat, 
                                 isbn = @isbn 
                             WHERE bid = @bid";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@title", newTitle);
                        cmd.Parameters.AddWithValue("@auth", author);
                        cmd.Parameters.AddWithValue("@published", published);
                        cmd.Parameters.AddWithValue("@cat", category);
                        cmd.Parameters.AddWithValue("@isbn", isbn);
                        cmd.Parameters.AddWithValue("@bid", bid);


                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully.");


                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        private void RefreshDataGridView()
        {

        }

        private void butt_delete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }


            if (!int.TryParse(dgv.CurrentRow.Cells["bid"].Value?.ToString(), out int bid))
            {
                MessageBox.Show("Invalid record selected.");
                return;
            }


            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }


            string connectionString = "server=localhost; uid=root; pwd=080420; database=library";


            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();


                    string query = @"DELETE FROM newbook WHERE bid = @bid";

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {

                        cmd.Parameters.AddWithValue("@bid", bid);


                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully.");


                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        

        private void butt_download_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || dgv.CurrentRow.Index == -1)
            {
                MessageBox.Show("Please select a record to download.");
                return;
            }

            
            if (!int.TryParse(dgv.CurrentRow.Cells["bid"].Value?.ToString(), out int bid))
            {
                MessageBox.Show("Invalid record selected. Please ensure a valid row is selected.");
                return;
            }

            
            string connectionString = "Server=localhost;Database=library;Uid=root;Pwd=080420;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    
                    string query = "SELECT title, author, dpublished, category, isbn FROM newbook WHERE bid = @bid";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@bid", bid);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                string bookInfo = $"Title: {reader["title"]}\r\n" +
                                                  $"Author: {reader["author"]}\r\n" +
                                                  $"Date Published: {reader["dpublished"]}\r\n" +
                                                  $"Category: {reader["category"]}\r\n" +
                                                  $"ISBN: {reader["isbn"]}";

                                
                                using (SaveFileDialog sfd = new SaveFileDialog())
                                {
                                    sfd.Filter = "Text File|*.txt"; 
                                    sfd.Title = "Save Book Info";

                                    if (sfd.ShowDialog() == DialogResult.OK)
                                    {
                                        
                                        using (StreamWriter writer = new StreamWriter(sfd.FileName))
                                        {
                                            writer.Write(bookInfo);
                                        }

                                        MessageBox.Show("Book information downloaded successfully.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No record found for the selected book.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while downloading the book info: {ex.Message}");
                }
            }
        }

      
    }
}

