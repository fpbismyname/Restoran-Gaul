using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Restoran_Gaul
{
    public partial class ReportPage : Form
    {
        public ReportPage()
        {
            InitializeComponent();
        }
        private void ReportPage_Load(object sender, EventArgs e)
        {
            string[] From_months = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            string[] To_months = { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            from_month.DataSource = From_months;
            to_month.DataSource = To_months;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (from_month.Text == "Januari" && to_month.Text == "Februari")
            {
                //connect_to_db("Select Name, Price from MsMenu;", chart_smk);
                if (chart_smk.Series["Income"].Points[0] == null)
                {
                    this.chart_smk.Series["Income"].Points.AddXY("Januari", 60);
                    this.chart_smk.Series["Income"].Points.AddXY("Februari", 30);
                } else
                {
                    MessageBox.Show("Already Exist");
                }
            }
            else
            {
                this.chart_smk.Series["Income"].Points.AddXY("Januari", 60);
                this.chart_smk.Series["Income"].Points.AddXY("Februari", 30);
                this.chart_smk.Series["Income"].Points.AddXY("Maret", 70);
                this.chart_smk.Series["Income"].Points.AddXY("April", 90);
                this.chart_smk.Series["Income"].Points.AddXY("Mei", 10);
                this.chart_smk.Series["Income"].Points.AddXY("Juni", 40);
                this.chart_smk.Series["Income"].Points.AddXY("Juli", 50);
                this.chart_smk.Series["Income"].Points.AddXY("Agustus", 10);
                this.chart_smk.Series["Income"].Points.AddXY("September", 40);
                this.chart_smk.Series["Income"].Points.AddXY("Oktober", 20);
                this.chart_smk.Series["Income"].Points.AddXY("November", 80);
                this.chart_smk.Series["Income"].Points.AddXY("Desember", 50);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void connect_to_db(string query, Chart chart)
        {
            string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                chart.DataSource = dt;
                chart.Series["Income"].YValueMembers = "Name";
                chart.Series["Income"].XValueMember = "Price";
                chart.Titles.Add("Income in billion");
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
    }
}
