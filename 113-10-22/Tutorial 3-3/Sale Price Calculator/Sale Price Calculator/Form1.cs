using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalprice;
            decimal discountpercentage;
            decimal discountamount;
            decimal saleprice;

            originalprice = decimal.Parse(originalPriceTextBox.Text);
            discountpercentage = decimal.Parse(discountPercentageTextBox.Text);
            discountpercentage = discountpercentage / 100;
            discountamount = originalprice * discountpercentage;
            saleprice = originalprice - discountamount;
            salePriceLabel.Text = saleprice.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
