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
            output = "����" + textyear.Text + "�~" + textmonth.Text + "��" + textday.Text + "��" + "�P��" + textweek.Text;
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
