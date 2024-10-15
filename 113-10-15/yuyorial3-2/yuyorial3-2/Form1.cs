namespace yuyorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            double average;

            kms = double.Parse(textkm.Text);
            liters = double.Parse(textoil.Text);
            average = kms / liters;

            lblshow.Text = average.ToString("n3");

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
