namespace yuyorial3_2
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
            textkm = new TextBox();
            textoil = new TextBox();
            lblshow = new Label();
            btnexit = new Button();
            btncal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft JhengHei UI", 16F);
            label1.Location = new Point(49, 47);
            label1.Name = "label1";
            label1.Size = new Size(156, 56);
            label1.TabIndex = 0;
            label1.Text = "公里數";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft JhengHei UI", 16F);
            label2.Location = new Point(49, 139);
            label2.Name = "label2";
            label2.Size = new Size(156, 56);
            label2.TabIndex = 1;
            label2.Text = "使用油耗";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft JhengHei UI", 16F);
            label3.Location = new Point(49, 271);
            label3.Name = "label3";
            label3.Size = new Size(156, 56);
            label3.TabIndex = 2;
            label3.Text = "公里/每公升";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textkm
            // 
            textkm.Font = new Font("Microsoft JhengHei UI", 15F);
            textkm.Location = new Point(288, 60);
            textkm.Name = "textkm";
            textkm.Size = new Size(179, 33);
            textkm.TabIndex = 3;
            // 
            // textoil
            // 
            textoil.Font = new Font("Microsoft JhengHei UI", 15F);
            textoil.Location = new Point(288, 152);
            textoil.Name = "textoil";
            textoil.Size = new Size(179, 33);
            textoil.TabIndex = 4;
            // 
            // lblshow
            // 
            lblshow.BorderStyle = BorderStyle.Fixed3D;
            lblshow.Font = new Font("Microsoft JhengHei UI", 15F);
            lblshow.Location = new Point(288, 284);
            lblshow.Name = "lblshow";
            lblshow.Size = new Size(179, 30);
            lblshow.TabIndex = 5;
            lblshow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Microsoft JhengHei UI", 15F);
            btnexit.Location = new Point(352, 369);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(131, 56);
            btnexit.TabIndex = 6;
            btnexit.Text = "離開";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // btncal
            // 
            btncal.Font = new Font("Microsoft JhengHei UI", 15F);
            btncal.Location = new Point(92, 369);
            btncal.Name = "btncal";
            btncal.Size = new Size(131, 56);
            btncal.TabIndex = 7;
            btncal.Text = "計算";
            btncal.UseVisualStyleBackColor = true;
            btncal.Click += btncal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 450);
            Controls.Add(btncal);
            Controls.Add(btnexit);
            Controls.Add(lblshow);
            Controls.Add(textoil);
            Controls.Add(textkm);
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
        private TextBox textkm;
        private TextBox textoil;
        private Label lblshow;
        private Button btnexit;
        private Button btncal;
    }
}
