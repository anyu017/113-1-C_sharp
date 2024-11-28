using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                decimal hoursworked;
                decimal hourlypayrate;
                decimal basepay;
                decimal overtimehours;
                decimal overtimepay;
                decimal grosspay;

                hoursworked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlypayrate = decimal.Parse(hourlyPayRateTextBox.Text);

                if (hoursworked > BASE_HOURS)
                {
                    basepay = hourlypayrate * BASE_HOURS;

                    overtimehours = hoursworked - BASE_HOURS;

                    overtimepay = overtimehours * hourlypayrate * OT_MULTIPLIER;

                    grosspay = basepay + overtimepay;
                }
                else
                {
                    grosspay = hoursworked * hourlypayrate;
                }
                grossPayLabel.Text = grosspay.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }     
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes and gross pay label.
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            // Reset the focus.
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
