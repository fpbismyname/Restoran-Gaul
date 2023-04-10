using System;
using System.Data;
using System.Data.SqlClient;
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

        private void list_siap_order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
