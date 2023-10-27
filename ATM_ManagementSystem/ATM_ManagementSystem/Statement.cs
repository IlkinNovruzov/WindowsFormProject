using Guna.UI2.WinForms;
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
    public partial class Statement : Form
    {
        public Statement()
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

        private void Statement_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True");
            con.Open();
            string query = $"select * from TransactionTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            guna2DataGridViewTr.DataSource = ds.Tables[0];
        }

        private void guna2ButtonClear_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True"))
            {
                con.Open();
                string query = $"use ATM_DB  drop table TransactionTbl  create table TransactionTbl(ID int primary key identity(1,1),Username varchar(50) not null,Type varchar(50) not null,Amount float not null,Time datetime not null)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                guna2DataGridViewTr.DataSource = 0;
                MessageBox.Show("Clear is Successfully!");
            }
        }
    }
}
