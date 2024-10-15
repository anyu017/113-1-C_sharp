namespace tutorual3_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textweek = new TextBox();
            textmonth = new TextBox();
            textday = new TextBox();
            textyear = new TextBox();
            label5 = new Label();
            lblshow = new Label();
            btnshow = new Button();
            btnclear = new Button();
            btnexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 16F);
            label1.Location = new Point(59, 55);
            label1.Name = "label1";
            label1.Size = new Size(105, 45);
            label1.TabIndex = 0;
            label1.Text = "星期幾";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 16F);
            label2.Location = new Point(59, 143);
            label2.Name = "label2";
            label2.Size = new Size(105, 45);
            label2.TabIndex = 1;
            label2.Text = "月份";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 16F);
            label3.Location = new Point(59, 235);
            label3.Name = "label3";
            label3.Size = new Size(105, 45);
            label3.TabIndex = 2;
            label3.Text = "日期";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft JhengHei UI", 16F);
            label4.Location = new Point(59, 329);
            label4.Name = "label4";
            label4.Size = new Size(105, 45);
            label4.TabIndex = 3;
            label4.Text = "年份";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textweek
            // 
            textweek.Font = new Font("Microsoft JhengHei UI", 24F);
            textweek.Location = new Point(226, 50);
            textweek.Name = "textweek";
            textweek.Size = new Size(256, 48);
            textweek.TabIndex = 4;
            // 
            // textmonth
            // 
            textmonth.Font = new Font("Microsoft JhengHei UI", 24F);
            textmonth.Location = new Point(226, 138);
            textmonth.Name = "textmonth";
            textmonth.Size = new Size(256, 48);
            textmonth.TabIndex = 5;
            // 
            // textday
            // 
            textday.Font = new Font("Microsoft JhengHei UI", 24F);
            textday.Location = new Point(226, 230);
            textday.Name = "textday";
            textday.Size = new Size(256, 48);
            textday.TabIndex = 6;
            // 
            // textyear
            // 
            textyear.Font = new Font("Microsoft JhengHei UI", 24F);
            textyear.Location = new Point(226, 324);
            textyear.Name = "textyear";
            textyear.Size = new Size(256, 48);
            textyear.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "label5";
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 16F);
            lblshow.Location = new Point(59, 426);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(423, 61);
            lblshow.TabIndex = 9;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnshow
            // 
            btnshow.Font = new Font("Microsoft JhengHei UI", 11F);
            btnshow.Location = new Point(38, 527);
            btnshow.Name = "btnshow";
            btnshow.Size = new Size(109, 52);
            btnshow.TabIndex = 10;
            btnshow.Text = "顯示完整日期";
            btnshow.UseVisualStyleBackColor = true;
            btnshow.Click += btnshow_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Microsoft JhengHei UI", 12F);
            btnclear.Location = new Point(226, 527);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(109, 52);
            btnclear.TabIndex = 11;
            btnclear.Text = "清除";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 12F);
            btnexit.Location = new Point(399, 527);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(109, 52);
            btnexit.TabIndex = 12;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 612);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnshow);
            Controls.Add(lblshow);
            Controls.Add(label5);
            Controls.Add(textyear);
            Controls.Add(textday);
            Controls.Add(textmonth);
            Controls.Add(textweek);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textweek;
        private TextBox textmonth;
        private TextBox textday;
        private TextBox textyear;
        private Label label5;
        private Label lblshow;
        private Button btnshow;
        private Button btnclear;
        private Button btnexit;
    }
}
