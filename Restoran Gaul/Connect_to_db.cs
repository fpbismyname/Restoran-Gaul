using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Restoran_Gaul
{
    public class Connection
    {
        public void connect_to_db(string query, DataGridView table)
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
        public virtual void sending_to_db(string query)
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
                MessageBox.Show(ex.Message, "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        /////////////////////////////////////////////////////////////////////////////
        ///
        //public void ordering_menu(string query)
        //{
        //    string constring = "Data Source=localhost;Initial Catalog=db_restoran_smk;Integrated Security=True";
        //    SqlConnection con = new SqlConnection(constring);
        //    con.Open();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        reader.Read();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}
