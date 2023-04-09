using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                    //MessageBox.Show("Terjadi kesalahan internal !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show(ex.Message);
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
            //img logic
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));



            if (menu_id.Text == "" || nama_menu.Text == "" || harga_menu.Text == "" || carbo_menu.Text == "" || protein_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con_to_db("select * from MsMenu", daftar_menu);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan Insert ?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    sen_to_db("insert into MsMenu(Id, Name, Price, Carbo, Protein, Photo) Values('" + menu_id.Text + "','" + nama_menu.Text + "'," + harga_menu.Text + "," + carbo_menu.Text + "," + protein_menu.Text + ","+arr+");");
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
            if (menu_id.Text == "" || nama_menu.Text == "" || harga_menu.Text == "" || carbo_menu.Text == "" || protein_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con_to_db("select * from MsMenu", daftar_menu);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan Update?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    sen_to_db("Update MsMenu Set Name = '" + nama_menu.Text + "', Price = " + harga_menu.Text + ", Carbo = " + carbo_menu.Text + ", Protein = " + protein_menu.Text + " where Id = " + menu_id.Text + "");
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
            if (menu_id.Text == "" || nama_menu.Text == "" || harga_menu.Text == "" || carbo_menu.Text == "" || protein_menu.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                con_to_db("select * from MsMenu", daftar_menu);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan Update?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    sen_to_db("Delete from MsMenu where Name = '" + nama_menu.Text + "'And Price = " + harga_menu.Text + "And Carbo = " + carbo_menu.Text + "And Protein = " + protein_menu.Text + " And Id = " + menu_id.Text + ";");
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {

                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
