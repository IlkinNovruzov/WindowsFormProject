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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void guna2ButtonBalance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void guna2ButtonDeposit_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.Show();
            this.Hide();
        }

        private void guna2ButtonWithDraw_Click(object sender, EventArgs e)
        {
            var withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void guna2ButtonStatement_Click(object sender, EventArgs e)
        {
            var statement = new Statement();
            statement.Show();
            this.Hide();

        }

        private void guna2ButtonFastCash_Click(object sender, EventArgs e)
        {
            var fastCash = new FastCash();
            fastCash.Show();
            this.Hide();
        }

        private void guna2ButtonChangePin_Click(object sender, EventArgs e)
        {
            var changePin = new ChangePin();
            changePin.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = $"Welcome {Login.username}";
        }
        public static void DataStatement(string type, string amount)
        {
            using (var con = new SqlConnection(@"Data Source=DESKTOP-VCSVAMO\SQLEXPRESS;Initial Catalog=ATM_DB;Integrated Security=True"))
            {
                con.Open();
                string tquery = $"insert into TransactionTbl values('{Login.username}','{type}',{amount}, getdate())";
                SqlCommand cmdT = new SqlCommand(tquery, con);
                cmdT.ExecuteNonQuery();
            }
        }
    }
}
