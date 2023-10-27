using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_ManagementSystem
{
    public partial class FastCash : Form
    {
        public FastCash()
        {
            InitializeComponent();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True");
        private void FastCashMethod(int amount)
        {
            try
            {
                con.Open();
                string query = $"update Account set Balance=Balance-{amount} where Username='{Login.username}'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                Home.DataStatement("Fast Cash",$"{amount}");
                MessageBox.Show("Fast Cash is Successfully!");
            }
            catch
            {
                MessageBox.Show("Informotion is invalid.");
            }
            finally
            {
                con.Close();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FastCashMethod(1);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            FastCashMethod(10);
        }

        private void guna2Button100_Click(object sender, EventArgs e)
        {
            FastCashMethod(100);
        }

        private void guna2Button1000_Click(object sender, EventArgs e)
        {
            FastCashMethod(1000);
        }
    }
}
