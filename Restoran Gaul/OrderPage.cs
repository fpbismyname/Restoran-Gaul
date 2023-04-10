using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class OrderPage : Form
    {
        public OrderPage()
        {
            InitializeComponent();
        }
        public void con_to_db(string query, DataGridView table)
        {
            string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                table.DataSource = dt;
                table.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        private void OrderPage_Load(object sender, EventArgs e)
        {
            con_to_db("select * from MsMenu;", list_menu);
            list_siap_order.Columns.Add(Name = "menu", "Menu");
            list_siap_order.Columns.Add(Name = "qty", "Qty");
            list_siap_order.Columns.Add(Name = "carbo", "Carbo");
            list_siap_order.Columns.Add(Name = "protein", "Protein");
            list_siap_order.Columns.Add(Name = "price", "Price");
            list_siap_order.Columns.Add(Name = "Total", "Total");
            list_siap_order.ReadOnly = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new AdminCenter().Show();
        }

        private void list_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (list_menu.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
            {
                list_menu.CurrentRow.Selected = true;
                nama_menu.Text = list_menu.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
            }
        }
        private void tambah_order_Click(object sender, EventArgs e)
        {
            if (nama_menu.Text == "" || jumlah_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("select Name, Price, Protein, Carbo from MsMenu where Name = '" + nama_menu.Text + "'", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int qty = Convert.ToInt32(jumlah_menu.Text);
                        int total = reader.GetInt32(1) * qty;
                        list_siap_order.Rows.Add(reader.GetString(0), jumlah_menu.Text, reader.GetInt32(3), reader.GetInt32(2), reader.GetInt32(1), total);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

            int TotalMenu = 0;
            int TotalCarbo = 0;
            int TotalProtein = 0;
            if (list_siap_order != null)
            {
                for (int i = 0; i < list_siap_order.Rows.Count; i++)
                {
                    int Menu = TotalMenu + int.Parse(list_siap_order.Rows[i].Cells["Price"].FormattedValue.ToString());
                    int Carbo = TotalCarbo + int.Parse(list_siap_order.Rows[i].Cells["Carbo"].FormattedValue.ToString());
                    int Protein = TotalProtein + int.Parse(list_siap_order.Rows[i].Cells["Protein"].FormattedValue.ToString());
                    total_carbo.Text = Convert.ToString(Menu);
                    total_protein.Text = Convert.ToString(Carbo);
                    total_menu.Text = Convert.ToString(Protein);
                }
            }
        }

        private void list_siap_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list_siap_order.ReadOnly = true;
        }

        private void jumlah_menu_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(jumlah_menu.Text, "[^0-9]"))
            {
                jumlah_menu.Text = jumlah_menu.Text.Remove(jumlah_menu.Text.Length - 1);
            }
        }
    }
}
