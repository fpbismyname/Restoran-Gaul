using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class ManageMemberPage : Form
    {
        Connection con = new Connection();
        public ManageMemberPage()
        {
            InitializeComponent();
        }
        private void ManageMemberPage_Load(object sender, EventArgs e)
        {
            con.connect_to_db("select * From MsMember", list_member);
            list_member.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (member_id.Text == "" || name_member.Text == "" || email_member.Text == "" || no_hp_member.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Opss..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan insert ?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    int id_member = int.Parse(member_id.Text);
                    string name_of_member = name_member.Text;
                    string email_of_member = email_member.Text;
                    string no_hp_of_member = no_hp_member.Text;

                    DateTime date = DateTime.Now;

                    con.sending_to_db("Insert into MsMember(Id, Name, Email, Handphone, JoinDate) Values(" + id_member + ", '" + name_of_member + "', '" + email_of_member + "', '" + no_hp_of_member + "', '" + date.ToString("yyyy-MM-dd") + "');");
                    con.connect_to_db("select * From MsMember", list_member);

                    member_id.Clear();
                    name_member.Clear();
                    email_member.Clear();
                    no_hp_member.Clear();
                }
            }
        }
        private void member_id_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(member_id.Text, "[^0-9]"))
            {
                member_id.Text = member_id.Text.Remove(member_id.Text.Length - 1);
            }
        }

        private void no_hp_member_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(no_hp_member.Text, "[^0-9]"))
            {
                no_hp_member.Text = no_hp_member.Text.Remove(no_hp_member.Text.Length - 1);
                no_hp_member.MaxLength = 13;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new AdminCenter().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.connect_to_db("select * from MsMember where Name like '%" + search_box.Text + "%';", list_member);
        }

        private void list_member_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (list_member.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    list_member.CurrentRow.Selected = true;
                    member_id.Text = list_member.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString();
                    name_member.Text = list_member.Rows[e.RowIndex].Cells["Name"].FormattedValue.ToString();
                    email_member.Text = list_member.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    no_hp_member.Text = list_member.Rows[e.RowIndex].Cells["Handphone"].FormattedValue.ToString();
                }
            }
            catch ( Exception ex)
            {
                if (ex != null)
                {
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (member_id.Text == "" || name_member.Text == "" || email_member.Text == "" || no_hp_member.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Opss..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan update ?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        con.sending_to_db("Update MsMember Set Name='" + name_member.Text + "', Email='" + email_member.Text + "', Handphone='" + no_hp_member.Text + "' Where Id=" + member_id.Text + ";");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        member_id.Clear();
                        email_member.Clear();
                        no_hp_member.Clear();
                        name_member.Clear();
                        con.connect_to_db("Select * from MsMember;", list_member);
                    }
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (member_id.Text == "" || name_member.Text == "" || email_member.Text == "" || no_hp_member.Text == "")
            {
                MessageBox.Show("Field tidak boleh kosong !", "Opss..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult msg = MessageBox.Show("Apakah anda yakin melakukan delete ?", "Perhatian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        con.sending_to_db("Delete MsMember where Id = " + member_id.Text + " AND Name = '" + name_member.Text + "'AND Email = '" + email_member.Text + "'AND Handphone = '" + no_hp_member.Text + "';");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ops..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    finally
                    {
                        con.connect_to_db("select * from MsMember", list_member);
                        member_id.Clear();
                        email_member.Clear();
                        no_hp_member.Clear();
                        name_member.Clear();
                    }
                }
            }
        }
    }
}
