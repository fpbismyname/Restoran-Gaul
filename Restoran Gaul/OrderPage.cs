using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class OrderPage : Form
    {
        Connection con = new Connection();
        int Carbo;
        int Protein;
        int Price;
        string NamaMenu;
        int Qty;
        int Total;
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
            list_siap_order.Columns.Add("menu", "Menu");
            list_siap_order.Columns.Add("qty", "Qty");
            list_siap_order.Columns.Add("carbo", "Carbo");
            list_siap_order.Columns.Add("protein", "Protein");
            list_siap_order.Columns.Add("price", "Price");
            list_siap_order.Columns.Add("total", "Total");

            list_siap_order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            list_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            con_to_db("Select Name, Price, Carbo, Protein, Photo from MsMenu;", list_menu);

            list_siap_order.ReadOnly = true;
            nama_menu.ReadOnly = true;
            list_menu.Columns[4].Visible = false;
            jumlah_menu.ReadOnly = true;
            //show_menu();
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
                    jumlah_menu.ReadOnly = false;
                    view_order.ImageLocation = list_menu.Rows[e.RowIndex].Cells["Photo"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                }
            }
        }
        public void counting_deliver()
        {
            int TotalCarbo = 0;
            int TotalProtein = 0;
            int TotalMenu = 0;
            for (int i = 0; i < list_siap_order.Rows.Count; i++)
            {
                int quantity = Convert.ToInt16(list_siap_order.Rows[i].Cells["Qty"].Value);

                TotalCarbo += Convert.ToInt32(list_siap_order.Rows[i].Cells["Carbo"].Value) * quantity;
                TotalProtein += Convert.ToInt32(list_siap_order.Rows[i].Cells["Protein"].Value) * quantity;
                TotalMenu += Convert.ToInt32(list_siap_order.Rows[i].Cells["Total"].Value);

            }

            total_carbo.Text = Convert.ToString(TotalCarbo);
            total_menu.Text = Convert.ToString(TotalMenu);
            total_protein.Text = Convert.ToString(TotalProtein);
        }
        private void siap_order()
        {
            string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select Name, Price, Carbo, Protein from MsMenu where Name = '" + nama_menu.Text + "';", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NamaMenu = reader.GetString(0);
                    Qty = int.Parse(jumlah_menu.Text);
                    Carbo = reader.GetInt32(2);
                    Protein = reader.GetInt32(3);
                    Price = reader.GetInt32(1);
                    Total = Price * Qty;
                }

                bool Found = false;
                if (list_siap_order.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in list_siap_order.Rows)
                    {
                        if (Convert.ToString(row.Cells[0].Value) == nama_menu.Text)
                        {
                            row.Cells[1].Value = Convert.ToString(Convert.ToInt16(row.Cells[1].Value.ToString()) + Convert.ToInt16(jumlah_menu.Text));
                            row.Cells[5].Value = Convert.ToString(Convert.ToInt16(row.Cells[1].Value) * Convert.ToInt16(row.Cells[4].Value));
                            Found = true;
                        }
                    }
                    if (!Found)
                    {
                        list_siap_order.Rows.Add(nama_menu.Text, Qty, Carbo, Protein, Price, Total);
                    }
                }
                else
                {
                    list_siap_order.Rows.Add(nama_menu.Text, Qty, Carbo, Protein, Price, Total);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                siap_order();
                counting_deliver();
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

        private void hapus_order_Click(object sender, EventArgs e)
        {
            list_siap_order.Rows.Clear();
            total_carbo.Text = "-";
            total_protein.Text = "-";
            total_menu.Text = "-";
        }

        private void order_menu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime Date = DateTime.Now;
                con.sending_to_db("Insert into OrderHeader(Id, Employeeid, Memberid, Date, PaymentType, CardNumber, Bank) Values(1,1,1," + Date.ToString("yyyy-MM-dd") + ",'Cash','-','-');");

                foreach (DataGridViewRow menu in list_siap_order.Rows)
                {
                    con.sending_to_db("Insert into OrderDetail(Id, Orderid, Menuid, Qty, Status) Values(1,1,1," + menu.Cells[1] + ",'Pending');");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                list_siap_order.Rows.Clear();
                total_carbo.Text = "-";
                total_protein.Text = "-";
                total_menu.Text = "-";
                nama_menu.Text = "-";
                jumlah_menu.Clear();
            }
        }
    }
}