namespace textboxdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullname;
            string firstname;
            string lastname;

            firstname = txtfirstname.Text;
            lastname = txtlastname.Text;
            fullname = lastname+" "+firstname;

            lblshow.Text = fullname;
        }
    }
}
