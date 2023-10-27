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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=true");
        int balance = 0;
        private void guna2ButtonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = $"insert into Account values ('{guna2TextBoxUsername.Text}',{guna2TextBoxPinCode.Text},'{guna2TextBoxName.Text}','{guna2TextBoxSurname.Text}',{balance})";
                SqlCommand cmd=new SqlCommand(query,con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration is Successfully!");
            }
            catch
            {
                MessageBox.Show("Missing Infromation!");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
