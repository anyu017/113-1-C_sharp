using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class Form1 : Form
    {
        // Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form1()
        {
            InitializeComponent();
        }

        // The InputIsValid method converts the user input and stores
        // it in the arguments (passed by reference). If the conversion
        // is successful, the method returns true. Otherwise it returns
        // false.
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal grossPay; // 宣告變數，不需初始化
            decimal bonus;

            // 呼叫 InputIsValid 方法，使用 out 來取得輸入值
            if (InputIsValid(out grossPay, out bonus))
            {
                // 計算供款金額
                decimal contribution = (grossPay + bonus) * CONTRIB_RATE;
                contributionLabel.Text = contribution.ToString("c"); // 顯示計算結果
            }
            else
            {
                // 當輸入無效時顯示錯誤訊息
                MessageBox.Show("請輸入有效的數字");
            }
        }

        private bool InputIsValid(out decimal grossPay, out decimal bonus)
        {
            // 預設值必須先賦給 out 參數
            grossPay = 0;
            bonus = 0;

            bool inputGood = false;

            // 嘗試解析 grossPayTextBox 的內容
            if (decimal.TryParse(grossPayTextBox.Text, out grossPay))
            {
                // 嘗試解析 bonusTextBox 的內容
                if (decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    inputGood = true; // 兩個輸入都有效
                }
            }

            return inputGood; // 根據判斷結果返回 true 或 false
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
