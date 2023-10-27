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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True");

        private void guna2ButtonWithdraw_Click(object sender, EventArgs e)
        {
            try{
                if (Convert.ToDouble(guna2TextBoxWithDraw.Text) > 0)
                {
                    con.Open();
                    string query = $"update Account set Balance=Balance-{guna2TextBoxWithDraw.Text} where Username='{Login.username}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    Home.DataStatement("WithDraw",guna2TextBoxWithDraw.Text);
                    MessageBox.Show("WithDraw is Successfully!");
                }
                else
                {
                    MessageBox.Show("Informotion is invalid.");
                }
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
    }
}
