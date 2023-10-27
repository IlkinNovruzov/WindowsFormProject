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
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True");

        private void guna2ButtonChangePin_Click(object sender, EventArgs e)
        {
            try
            {
                if (guna2TextBoxNewPin.Text == guna2TextBoxConfirmPin.Text)
                {
                    con.Open();
                    string query = $"update Account set Pin={guna2TextBoxNewPin.Text} where Username='{Login.username}'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Change Pin is Successfully!");
                }
                else
                {
                    MessageBox.Show("Pin contains only numbers!");
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

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
