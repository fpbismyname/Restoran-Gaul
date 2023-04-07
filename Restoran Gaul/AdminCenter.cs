using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Restoran_Gaul
{
    public partial class AdminCenter : Form
    {
        public AdminCenter()
        {
            InitializeComponent();
        }

        private void orderPage_Click(object sender, EventArgs e)
        { 
            this.Hide();
            new OrderPage().Show();
        }

        private void menuPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMenuPage().Show();
        }

        private void memberPage_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageMemberPage().Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }
    }
}
