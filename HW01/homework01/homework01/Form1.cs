namespace homework01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblshow.Text = "���ߥ|";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblshow.Text = "�®礭";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblshow.Text = "���K";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblshow.Text = "����Q";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
