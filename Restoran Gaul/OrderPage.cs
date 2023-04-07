using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
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
                list_menu.DropDownStyle = ComboBoxStyle.DropDownList;
                list_menu.Items.Add(read.GetString(0));
                list_menu.SelectedItem = read.GetString(0);
            }
            list_menu.Enabled = true;
            qty_style.Enabled = true;
            add_order.Enabled = true;
            daftar_siap_order.Columns.Add("menu", "Menu");
            daftar_siap_order.Columns.Add("qty", "Qty");
            daftar_siap_order.Columns.Add("carbo", "Carbo");
            daftar_siap_order.Columns.Add("protein", "Protein");
            daftar_siap_order.Columns.Add("price", "Price");
            daftar_siap_order.Columns.Add("total", "Total");
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(qty_style.Text, "[^0-9]"))
            {
                qty_style.Text = qty_style.Text.Remove(qty_style.Text.Length - 1);
            }
        }

        private void add_order_Click(object sender, EventArgs e)
        {
            //to connect and read the data from database
            string constring = "server= localhost; database= db_restoran; uid= root; pwd = Fajar12BuDiman;";
            string menu = list_menu.SelectedItem.ToString();
            string query = "select Name, Protein, Carbo, Price from msmenu where Name = '" + menu + "';";
            MySqlConnection con = new MySqlConnection(constring);
            con.Open();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader read = cmd.ExecuteReader();
            read.Read();

            //to make the table daftar order just read only
            daftar_siap_order.ReadOnly = true;

            //to handle error if qty not have some value
            if (qty_style.Text == "")
            {
                MessageBox.Show("Qty tidak boleh kosong !", "Ops..");
            }
            else
            {
                //to activied delete button & order menu button
                order_menu.Enabled = true;
                delete_order.Enabled = true;

                //variable to add menu
                int qty = Convert.ToInt32(qty_style.Text);
                int Protein = (int)read[1];
                int Carbo = (int)read[2];
                int Price = (int)read[3];
                int Total = Price * qty;


                //to execute the logic, and catch the error and change it
                try
                {
                    //for add some order list
                    daftar_siap_order.Rows.Add(new object[]
                    {
                    menu,
                    qty,
                    Protein,
                    Carbo,
                    Price,
                    Total
                    });

                    //to show how much protein, carbo and price order
                    decimal totalProtein = 0;
                    decimal totalCarbo = 0;
                    decimal totalOrder = 0;

                    for (int i = 0; i < daftar_siap_order.Rows.Count; i++)
                    {
                        totalProtein += Convert.ToDecimal(daftar_siap_order.Rows[i].Cells["Protein"].Value);
                    }
                    for (int i = 0; i < daftar_siap_order.Rows.Count; i++)
                    {
                        totalCarbo += Convert.ToDecimal(daftar_siap_order.Rows[i].Cells["Carbo"].Value);
                    }
                    for (int i = 0; i < daftar_siap_order.Rows.Count;i++)
                    {
                        totalOrder += Convert.ToDecimal(daftar_siap_order.Rows[i].Cells["Total"].Value);
                    }

                    //for changing the total value
                    total_carbo.Text = totalCarbo.ToString();
                    total_order.Text = totalOrder.ToString();
                    total_protein.Text = totalProtein.ToString();

                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    if (ex != null)
                    {
                        MessageBox.Show("Masukan Menu untuk melakukan order !", "Ops..");
                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void delete_order_Click(object sender, EventArgs e)
        {
            daftar_siap_order.Rows.Clear();
        }
    }
}
