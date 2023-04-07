using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class ManageMenuPage : Form
    {
        public ManageMenuPage()
        {
            InitializeComponent();
        }

        //searching menu
        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "server= localhost; database= db_restoran; uid= root; pwd= Fajar12BuDiman;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            try
            {
                string query = "select * from msmenu where Name like '%" + cari_menu.Text + "%'";
                MySqlDataAdapter sda = new MySqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);
                daftar_menu.DataSource = dataTable;
                daftar_menu.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { con.Close(); }
        }

        private void insert_menu_Click(object sender, EventArgs e)
        {
            string constring = "server= localhost; database= db_restoran; uid= root; pwd= Fajar12BuDiman;";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();

            try
            {
                string query = "insert into msmenu(Id, Name, Price, Photo, Carbo, Protein) Values(" + menu_id.Text + ",'" + nama_menu.Text + "'," + harga_menu.Text + ",'" + photo_menu.Text + "'," + carbo_menu.Text + "," + protein_menu.Text + ");";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Menu telah ditambahkan !", "Yeay..");
                    menu_id.Clear();
                    nama_menu.Clear();
                    harga_menu.Clear();
                    photo_menu.Clear();
                    carbo_menu.Clear();
                    protein_menu.Clear();
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    MessageBox.Show("Menu baru tidak boleh kosong !", "Ops..");
                }
            }
            finally
            { con.Close(); }
        }
    }
}
