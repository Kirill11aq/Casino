namespace Casino
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbl_casino = new Label();
            lbl_balance = new Label();
            lbl_win = new Label();
            lbl_loss = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_play = new Button();
            btn_bid = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dollar;
            pictureBox1.Location = new Point(22, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dollar;
            pictureBox2.Location = new Point(98, 73);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 70);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.dollar;
            pictureBox3.Location = new Point(174, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(70, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lbl_casino
            // 
            lbl_casino.AutoSize = true;
            lbl_casino.BackColor = Color.Yellow;
            lbl_casino.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_casino.Location = new Point(27, 9);
            lbl_casino.Name = "lbl_casino";
            lbl_casino.Size = new Size(78, 30);
            lbl_casino.TabIndex = 1;
            lbl_casino.Text = "Casino";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.BackColor = Color.Silver;
            lbl_balance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_balance.Location = new Point(27, 39);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(112, 30);
            lbl_balance.TabIndex = 1;
            lbl_balance.Text = "Balance :$";
            // 
            // lbl_win
            // 
            lbl_win.AutoSize = true;
            lbl_win.BackColor = Color.Green;
            lbl_win.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_win.Location = new Point(22, 155);
            lbl_win.Name = "lbl_win";
            lbl_win.Size = new Size(92, 30);
            lbl_win.TabIndex = 1;
            lbl_win.Text = "Wins : 0";
            // 
            // lbl_loss
            // 
            lbl_loss.AutoSize = true;
            lbl_loss.BackColor = Color.FromArgb(255, 128, 0);
            lbl_loss.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lbl_loss.Location = new Point(22, 185);
            lbl_loss.Name = "lbl_loss";
            lbl_loss.Size = new Size(85, 30);
            lbl_loss.TabIndex = 1;
            lbl_loss.Text = "Loss : 0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(138, 155);
            label1.Name = "label1";
            label1.Size = new Size(45, 30);
            label1.TabIndex = 1;
            label1.Text = "Bid";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 22F);
            textBox1.Location = new Point(144, 197);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 47);
            textBox1.TabIndex = 2;
            // 
            // btn_play
            // 
            btn_play.BackColor = Color.White;
            btn_play.Font = new Font("Segoe UI", 22F);
            btn_play.ForeColor = Color.Black;
            btn_play.Location = new Point(22, 218);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(82, 52);
            btn_play.TabIndex = 3;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = false;
            btn_play.Click += btn_play_Click;
            // 
            // btn_bid
            // 
            btn_bid.BackColor = Color.White;
            btn_bid.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_bid.ForeColor = Color.Black;
            btn_bid.Location = new Point(138, 250);
            btn_bid.Name = "btn_bid";
            btn_bid.Size = new Size(106, 52);
            btn_bid.TabIndex = 3;
            btn_bid.Text = "New bid";
            btn_bid.UseVisualStyleBackColor = false;
            btn_bid.Click += btn_bid_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(284, 331);
            Controls.Add(btn_bid);
            Controls.Add(btn_play);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(lbl_loss);
            Controls.Add(lbl_win);
            Controls.Add(lbl_balance);
            Controls.Add(lbl_casino);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbl_casino;
        private Label lbl_balance;
        private Label lbl_win;
        private Label lbl_loss;
        private Label label1;
        private TextBox textBox1;
        private Button btn_play;
        private Button btn_bid;
        private System.Windows.Forms.Timer timer1;
    }
}
