namespace ATM_ManagementSystem
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        int start;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            MyProgressBar.Value = start;
            labelPercent.Text = "" + start + "%";
            if (MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                timer1.Stop();
                var login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void Start_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelPercent_Click(object sender, EventArgs e)
        {

        }
    }
}