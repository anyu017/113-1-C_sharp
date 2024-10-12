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
            lblshow.Text = "紅心四";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblshow.Text = "黑桃五";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblshow.Text = "方塊K";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblshow.Text = "梅花Q";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
