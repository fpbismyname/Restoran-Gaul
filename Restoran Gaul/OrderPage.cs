using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminCenter().Show();
        }

        private void refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string constring = "server= localhost; database= db_restoran; uid= root; pwd = Fajar12BuDiman;";
            MySqlConnection con = new MySqlConnection(constring);
            string menu = "select Name, Price, Carbo, Protein from msmenu;";
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter(menu, con);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            //read = sda.Fill(dtable);
            daftar_menu.DataSource = dtable;
            daftar_menu.ReadOnly = true;

            string list = "select Name from msmenu;";
            MySqlCommand cmd = new MySqlCommand(list, con);
            MySqlDataReader read;
            read = cmd.ExecuteReader();

            while (read.Read())
            {
                list_menu.Items.Add(read.GetString(0));
                list_menu.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(qty_style.Text, "[^0-9]"))
            {
                qty_style.Text = qty_style.Text.Remove(qty_style.Text.Length - 1);
            }
        }
    }
}
