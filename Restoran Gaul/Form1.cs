using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server= localhost; database= db_restoran; uid= root; pwd= Fajar12BuDiman;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();          

            if (email.Text.Length == 0 || password.Text.Length == 0)
            {
                MessageBox.Show("Email dan password tidak boleh kosong !", "Ops..");
            }
            else
            {

                try
                {
                    string query = "select * from msemployee where Email = '" + email.Text + "' AND Password = '" + password.Text + "';";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                    //MySqlCommand cmd = new MySqlCommand(query, con);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    //MySqlDataReader reader = cmd.ExecuteReader;
                    if (dtable.Rows[0][5].ToString() == "Admin")
                    {
                        this.Hide();
                        new AdminCenter().Show();
                    }
                    else if (dtable.Rows[0][5].ToString() == "Kasir")
                    {
                        this.Hide();
                        new KasirCenter().Show();
                    }
                }
                catch (Exception ex)
                {
                    if (ex is Exception)
                    {
                        MessageBox.Show("Akun tidak ditemukan !", "Ops..");
                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
