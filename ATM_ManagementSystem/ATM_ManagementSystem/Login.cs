using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void guna2ButtonLogin_Click(object sender, EventArgs e)
        {

        }

        private void guna2ButtonSignUp_Click(object sender, EventArgs e)
        {
            var rg = new Registration();
            rg.Show();
            this.Hide();
        }
    }
}
