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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static string username;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True");
        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = $"select * from Account where Username='{guna2TextBoxUsername.Text}' and Pin='{guna2TextBoxPinCode.Text}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                int row = sda.Fill(dt);
                if (row == 1)
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    username = dt.Rows[0][0].ToString();
                    home.labelWelcome.Text = $"Welcome {username}";
                }
                else
                {
                    MessageBox.Show("Wrong Username or Pin Code!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void guna2ButtonSignUp_Click(object sender, EventArgs e)
        {
            var rg = new Registration();
            rg.Show();
            this.Hide();
        }
    }
}
