namespace textboxdemo
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
            button1 = new Button();
            txtfirstname = new TextBox();
            txtlastname = new TextBox();
            lblshow = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 24F);
            label1.Location = new Point(71, 49);
            label1.Name = "label1";
            label1.Size = new Size(214, 41);
            label1.TabIndex = 0;
            label1.Text = "First Name：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 24F);
            label2.Location = new Point(71, 173);
            label2.Name = "label2";
            label2.Size = new Size(211, 41);
            label2.TabIndex = 1;
            label2.Text = "Last Name：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 24F);
            label3.Location = new Point(71, 274);
            label3.Name = "label3";
            label3.Size = new Size(202, 41);
            label3.TabIndex = 2;
            label3.Text = "Full Name：";
            // 
            // button1
            // 
            button1.Location = new Point(226, 383);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 3;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtfirstname
            // 
            txtfirstname.Font = new Font("Microsoft JhengHei UI", 20F);
            txtfirstname.Location = new Point(295, 57);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(212, 41);
            txtfirstname.TabIndex = 4;
            // 
            // txtlastname
            // 
            txtlastname.Font = new Font("Microsoft JhengHei UI", 20F);
            txtlastname.Location = new Point(295, 174);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(212, 41);
            txtlastname.TabIndex = 5;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Cursor = Cursors.No;
            lblshow.Font = new Font("Microsoft JhengHei UI", 24F);
            lblshow.Location = new Point(295, 274);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(212, 41);
            lblshow.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 450);
            Controls.Add(lblshow);
            Controls.Add(txtlastname);
            Controls.Add(txtfirstname);
            Controls.Add(button1);
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
        private Button button1;
        private TextBox txtfirstname;
        private TextBox txtlastname;
        private Label lblshow;
    }
}
