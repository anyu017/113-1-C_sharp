using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showCard(string cardName)
        {
            switch(cardName)
            {
                case "黑桃ACE":
                    aceSpadesPictureBox.Visible = true;
                    tenHeartsPictureBox.Visible = false;
                    kingClubsPictureBox.Visible = false;
                    break;
                case "紅心十":
                    aceSpadesPictureBox.Visible = false;
                    tenHeartsPictureBox.Visible = true;
                    kingClubsPictureBox.Visible = false;
                    break;
                case "梅花K":
                    aceSpadesPictureBox.Visible = false;
                    tenHeartsPictureBox.Visible = false;
                    kingClubsPictureBox.Visible = true;
                    break;

            }
        }

        private void showCardButton_Click(object sender, EventArgs e)
        {
            if(cardListBox.SelectedIndex != -1)
            {
                showCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("選擇一張牌");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
