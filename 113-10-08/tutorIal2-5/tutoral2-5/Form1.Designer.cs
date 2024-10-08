namespace tutoral2_5
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
            ptxBack = new PictureBox();
            ptxFront = new PictureBox();
            btnShowFront = new Button();
            btnShowwBack = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)ptxBack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).BeginInit();
            SuspendLayout();
            // 
            // ptxBack
            // 
            ptxBack.Image = Properties.Resources.Backface_Blue;
            ptxBack.Location = new Point(47, 52);
            ptxBack.Name = "ptxBack";
            ptxBack.Size = new Size(213, 329);
            ptxBack.SizeMode = PictureBoxSizeMode.Zoom;
            ptxBack.TabIndex = 0;
            ptxBack.TabStop = false;
            ptxBack.Visible = false;
            // 
            // ptxFront
            // 
            ptxFront.Image = Properties.Resources.Ace_Spades;
            ptxFront.Location = new Point(379, 52);
            ptxFront.Name = "ptxFront";
            ptxFront.Size = new Size(213, 329);
            ptxFront.SizeMode = PictureBoxSizeMode.Zoom;
            ptxFront.TabIndex = 1;
            ptxFront.TabStop = false;
            ptxFront.Visible = false;
            // 
            // btnShowFront
            // 
            btnShowFront.Font = new Font("Microsoft JhengHei UI", 16F);
            btnShowFront.Location = new Point(450, 431);
            btnShowFront.Name = "btnShowFront";
            btnShowFront.Size = new Size(107, 40);
            btnShowFront.TabIndex = 2;
            btnShowFront.Text = "正面";
            btnShowFront.UseVisualStyleBackColor = true;
            btnShowFront.Click += btnShowFront_Click;
            // 
            // btnShowwBack
            // 
            btnShowwBack.Font = new Font("Microsoft JhengHei UI", 16F);
            btnShowwBack.Location = new Point(94, 431);
            btnShowwBack.Name = "btnShowwBack";
            btnShowwBack.Size = new Size(107, 40);
            btnShowwBack.TabIndex = 3;
            btnShowwBack.Text = "背面";
            btnShowwBack.UseVisualStyleBackColor = true;
            btnShowwBack.Click += btnShowwBack_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Microsoft JhengHei UI", 24F);
            btnExit.Location = new Point(47, 505);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(545, 85);
            btnExit.TabIndex = 4;
            btnExit.Text = "離開";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 620);
            Controls.Add(btnExit);
            Controls.Add(btnShowwBack);
            Controls.Add(btnShowFront);
            Controls.Add(ptxFront);
            Controls.Add(ptxBack);
            Font = new Font("Microsoft JhengHei UI", 9F);
            Name = "Form1";
            Text = "翻牌";
            ((System.ComponentModel.ISupportInitialize)ptxBack).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptxFront).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptxBack;
        private PictureBox ptxFront;
        private Button btnShowFront;
        private Button btnShowwBack;
        private Button btnExit;
    }
}
