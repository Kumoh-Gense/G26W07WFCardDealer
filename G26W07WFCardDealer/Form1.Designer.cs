namespace G26W07WFCardDealer
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
            Card1 = new PictureBox();
            btnDeal = new Button();
            Card2 = new PictureBox();
            Card3 = new PictureBox();
            Card4 = new PictureBox();
            Card5 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Card1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Card5).BeginInit();
            SuspendLayout();
            // 
            // Card1
            // 
            Card1.Image = Properties.Resources.red_joker;
            Card1.Location = new Point(25, 12);
            Card1.Name = "Card1";
            Card1.Size = new Size(187, 265);
            Card1.SizeMode = PictureBoxSizeMode.Zoom;
            Card1.TabIndex = 0;
            Card1.TabStop = false;
            Card1.Click += OnDeal0;
            // 
            // btnDeal
            // 
            btnDeal.Location = new Point(383, 302);
            btnDeal.Name = "btnDeal";
            btnDeal.Size = new Size(284, 85);
            btnDeal.TabIndex = 1;
            btnDeal.Text = "카드분배";
            btnDeal.UseVisualStyleBackColor = true;
            btnDeal.Click += Play;
            // 
            // Card2
            // 
            Card2.Image = Properties.Resources.red_joker;
            Card2.Location = new Point(218, 12);
            Card2.Name = "Card2";
            Card2.Size = new Size(187, 265);
            Card2.SizeMode = PictureBoxSizeMode.Zoom;
            Card2.TabIndex = 2;
            Card2.TabStop = false;
            Card2.Click += Ondeal1;
            // 
            // Card3
            // 
            Card3.Image = Properties.Resources.red_joker;
            Card3.Location = new Point(428, 12);
            Card3.Name = "Card3";
            Card3.Size = new Size(187, 265);
            Card3.SizeMode = PictureBoxSizeMode.Zoom;
            Card3.TabIndex = 3;
            Card3.TabStop = false;
            Card3.Click += Ondeal2;
            // 
            // Card4
            // 
            Card4.Image = Properties.Resources.red_joker;
            Card4.Location = new Point(641, 12);
            Card4.Name = "Card4";
            Card4.Size = new Size(187, 265);
            Card4.SizeMode = PictureBoxSizeMode.Zoom;
            Card4.TabIndex = 4;
            Card4.TabStop = false;
            Card4.Click += Ondeal3;
            // 
            // Card5
            // 
            Card5.Image = Properties.Resources.red_joker;
            Card5.Location = new Point(851, 12);
            Card5.Name = "Card5";
            Card5.Size = new Size(187, 265);
            Card5.SizeMode = PictureBoxSizeMode.Zoom;
            Card5.TabIndex = 5;
            Card5.TabStop = false;
            Card5.Click += Ondeal4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(496, 415);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 473);
            Controls.Add(label1);
            Controls.Add(Card5);
            Controls.Add(Card4);
            Controls.Add(Card3);
            Controls.Add(Card2);
            Controls.Add(btnDeal);
            Controls.Add(Card1);
            Name = "Form1";
            Text = "카드딜러";
            ((System.ComponentModel.ISupportInitialize)Card1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Card5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Card1;
        private Button btnDeal;
        private PictureBox Card2;
        private PictureBox Card3;
        private PictureBox Card4;
        private PictureBox Card5;
        private Label label1;
    }
}
