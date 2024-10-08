namespace tutoral2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowwBack_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = true;
            ptxFront.Visible = false;
        }

        private void btnShowFront_Click(object sender, EventArgs e)
        {
            ptxBack.Visible = false;
            ptxFront.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
