using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BookCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                 
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString ="server=localhost; uid=root; pwd=080420;database=user";

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "SELECT * FROM login WHERE username = '" + txt_username.Text + "' AND pass = '" + txt_password.Text + "'";

            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int a = 5;

            if (ds.Tables[0].Rows.Count != 0)
            {
                this.Hide();
                DashBoard db = new DashBoard();
                db.Show();
                

            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void butt_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }
    }
}
