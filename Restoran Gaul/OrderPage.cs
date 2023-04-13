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
            try
            {
                if (list_menu.Rows[e.RowIndex].Cells[e.ColumnIndex] != null)
                {
                    list_menu.CurrentRow.Selected = true;
                    nama_menu.Text = list_menu.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    jumlah_menu.Text = "1";
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    MessageBox.Show("Judul tidak untuk dipilih !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void counting_deliver(int row)
        {
            int TotalCarbo = 0;
            int TotalProtein = 0;
            int qty = 0;
            for (int i = 0; i < list_siap_order.Rows.Count; i++)
            {
                TotalCarbo += Convert.ToInt32(list_siap_order.Rows[i].Cells["Carbo"].Value);
                TotalProtein += Convert.ToInt32(list_siap_order.Rows[i].Cells["Protein"].Value);
                qty += Convert.ToInt32(list_siap_order.Rows[i].Cells["Qty"].Value);
            }
            int hasilProtein = TotalProtein * qty;
            int hasilCarbo = TotalCarbo * qty;
            int hasilMenu = int.Parse(list_siap_order.Rows[row].Cells["Total"].FormattedValue.ToString());
            total_carbo.Text = Convert.ToString(hasilCarbo);
            total_protein.Text = Convert.ToString(hasilProtein);
            total_menu.Text = Convert.ToString(hasilMenu);
        }
        private void tambah_order_Click(object sender, EventArgs e)
        {
            if (nama_menu.Text == "" || jumlah_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
                    SqlConnection con = new SqlConnection(constring);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Name, Price, Carbo, Protein from MsMenu where Name = '" + nama_menu.Text + "' ;", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string NameMenu = reader.GetString(0);
                        string Qty = jumlah_menu.Text;
                        int Price = reader.GetInt32(1);
                        int Carbo = reader.GetInt32(2);
                        int Protein = reader.GetInt32(3);
                        int Rows = list_siap_order.Rows.Count;
                        if (Rows < list_menu.Rows.Count)
                        {
                            if (list_siap_order.Rows[Rows].Cells["Menu"].Value == nama_menu.Text)
                            {
                                list_siap_order.Rows.Add(NameMenu, Qty, Price, Carbo, Protein);
                            }
                            else
                            {
                                MessageBox.Show("Kontol");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void list_siap_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list_siap_order.ReadOnly = true;
        }

        private void jumlah_menu_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(jumlah_menu.Text, "[^1-9]"))
            {
                jumlah_menu.Text = jumlah_menu.Text.Remove(jumlah_menu.Text.Length - 1);
            }
        }
    }
}
