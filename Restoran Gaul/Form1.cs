using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void connect_to_db(string query)
        {
            string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][2].ToString() == "Admin")
                {
                    this.Hide();
                    new AdminCenter().Show();
                }
                else if (dt.Rows[0][2].ToString() == "Kasir")
                {
                    this.Hide();
                    new KasirCenter().Show();
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    MessageBox.Show("Maaf, Data tidak valid !", "Ops..");
                }
            }
            finally
            {
                con.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..");
            }
            else
            {
                connect_to_db("select Email, Password, Position from MsEmployee where Email = '" + email.Text + "' AND Password = '" + password.Text + "';");
            }
        }
    }
}
