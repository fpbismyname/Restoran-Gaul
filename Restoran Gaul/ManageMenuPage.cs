using Mysqlx.Crud;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class ManageMenuPage : Form
    {
        private void con_to_db(string query, DataGridView table)
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
                if (ex != null)
                {
                    MessageBox.Show("Terjadi kesalahan pada sistem!", "Ops..");
                }
            }
            finally
            {
                con.Close();
                daftar_menu.Refresh();

            }
        }
        private void sen_to_db(string query)
        {
            string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    MessageBox.Show("Id tidak boleh sama !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                con.Close();
                daftar_menu.Refresh();
            }
        }
        public ManageMenuPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con_to_db("select * from MsMenu where Name Like '%" + cari_menu.Text + "%';", daftar_menu);
        }
        private void insert_menu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(menu_id.Text);
            string name = nama_menu.Text;
            string photo = photo_menu.Text;
            int price = Convert.ToInt32(harga_menu.Text);
            int carbo = Convert.ToInt32(carbo_menu.Text);
            int protein = Convert.ToInt32(protein_menu.Text);
            if (menu_id.Text == "" || nama_menu.Text == "" || harga_menu.Text == "" || carbo_menu.Text == "" || protein_menu.Text == "" || photo_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con_to_db("select * from MsMenu", daftar_menu);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan Insert ?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    sen_to_db("insert into MsMenu(Id, Name, Price, Carbo, Protein, Photo) Values("+id+",'"+name+"',"+price+","+carbo+","+protein+",'"+photo+"')");
                    menu_id.Clear();
                    nama_menu.Clear();
                    harga_menu.Clear();
                    photo_menu.Clear();
                    carbo_menu.Clear();
                    protein_menu.Clear();
                    con_to_db("select * from MsMenu", daftar_menu);
                }
            }

        }
        private void Kembali_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new AdminCenter().Show();
        }

        private void ManageMenuPage_Load(object sender, EventArgs e)
        {
            con_to_db("select * from Msmenu;", daftar_menu);
            daftar_menu.Columns["Photo"].Visible = false;
            daftar_menu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            photo_menu.ReadOnly = true;
        }

        private void daftar_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (daftar_menu.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    daftar_menu.CurrentRow.Selected = true;
                    menu_id.Text = daftar_menu.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    nama_menu.Text = daftar_menu.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    harga_menu.Text = daftar_menu.Rows[e.RowIndex].Cells["Price"].FormattedValue.ToString();
                    carbo_menu.Text = daftar_menu.Rows[e.RowIndex].Cells["Carbo"].FormattedValue.ToString();
                    protein_menu.Text = daftar_menu.Rows[e.RowIndex].Cells["Protein"].FormattedValue.ToString();
                    photo_menu.Text = daftar_menu.Rows[e.RowIndex].Cells["Photo"].FormattedValue.ToString();
                    view_menu.ImageLocation = daftar_menu.Rows[e.RowIndex].Cells["Photo"].FormattedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                if (ex != null)
                {
                    MessageBox.Show("Judul kolom tidak bisa dipilih !", "Ops..");
                }
            }
        }

        private void update_menu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(menu_id.Text);
            string name = nama_menu.Text;
            string photo = photo_menu.Text;
            int price = Convert.ToInt32(harga_menu.Text);
            int carbo = Convert.ToInt32(carbo_menu.Text);
            int protein = Convert.ToInt32(protein_menu.Text);
            if (menu_id.Text == "" || nama_menu.Text == "" || harga_menu.Text == "" || carbo_menu.Text == "" || protein_menu.Text == "" || photo_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con_to_db("select * from MsMenu", daftar_menu);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan Update?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    sen_to_db("Update MsMenu Set Name = '" + name+ "', Price = " + price+ ", Carbo = " + carbo+ ", Protein = " + protein + " , Photo = '"+photo+"' where Id = " + id + "");
                    menu_id.Clear();
                    nama_menu.Clear();
                    harga_menu.Clear();
                    photo_menu.Clear();
                    carbo_menu.Clear();
                    protein_menu.Clear();
                    con_to_db("select * from MsMenu", daftar_menu);
                }
            }

        }

        private void delete_menu_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(menu_id.Text);
            string name = nama_menu.Text;
            string photo = photo_menu.Text;
            int price = Convert.ToInt32(harga_menu.Text);
            int carbo = Convert.ToInt32(carbo_menu.Text);
            int protein = Convert.ToInt32(protein_menu.Text);

            if (menu_id.Text == "" || nama_menu.Text == "" || harga_menu.Text == "" || carbo_menu.Text == "" || protein_menu.Text == "" || photo_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con_to_db("select * from MsMenu", daftar_menu);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan Update?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    sen_to_db("Delete from MsMenu where Id = "+ id +" AND Name = '" + name + "'And Price = " + price + "And Carbo = " + carbo + "And Protein = " + protein + " And Photo = '"+photo+"';");
                    menu_id.Clear();
                    nama_menu.Clear();
                    harga_menu.Clear();
                    photo_menu.Clear();
                    carbo_menu.Clear();
                    protein_menu.Clear();
                    con_to_db("select * from MsMenu", daftar_menu);
                }
            }
        }

        private void menu_id_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(menu_id.Text, "[^0-9]"))
            {
                menu_id.Text = menu_id.Text.Remove(menu_id.Text.Length - 1);
            }
        }

        private void harga_menu_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(harga_menu.Text, "[^0-9]"))
            {
                harga_menu.Text = harga_menu.Text.Remove(harga_menu.Text.Length - 1);
            }
        }

        private void carbo_menu_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(carbo_menu.Text, "[^0-9]"))
            {
                carbo_menu.Text = carbo_menu.Text.Remove(carbo_menu.Text.Length - 1);
            }
        }

        private void protein_menu_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(protein_menu.Text, "[^0-9]"))
            {
                protein_menu.Text = protein_menu.Text.Remove(protein_menu.Text.Length - 1);
            }
        }

        private void upload_photo_menu_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                view_menu.Image = Image.FromFile(ofd.FileName);
                photo_menu.Text = ofd.FileName;
            }
        }
    }
}
