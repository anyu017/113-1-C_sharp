namespace tutorual3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            string output;
            output = "民國" + textyear.Text + "年" + textmonth.Text + "月" + textday.Text + "日" + "星期" + textweek.Text;
            lblshow.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textday.Text = "";
            textmonth.Text = "";
            textweek.Text = "";
            textyear.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
