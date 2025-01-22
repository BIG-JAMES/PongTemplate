namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.RAT1 = new System.Windows.Forms.Timer(this.components);
            this.RAT2 = new System.Windows.Forms.Timer(this.components);
            this.RAT3 = new System.Windows.Forms.Timer(this.components);
            this.RAT4 = new System.Windows.Forms.Timer(this.components);
            this.RATB1 = new System.Windows.Forms.Timer(this.components);
            this.RATB2 = new System.Windows.Forms.Timer(this.components);
            this.RATB3 = new System.Windows.Forms.Timer(this.components);
            this.RATB4 = new System.Windows.Forms.Timer(this.components);
            this.BATB1 = new System.Windows.Forms.Timer(this.components);
            this.BAT1 = new System.Windows.Forms.Timer(this.components);
            this.BAT2 = new System.Windows.Forms.Timer(this.components);
            this.BAT3 = new System.Windows.Forms.Timer(this.components);
            this.BAT4 = new System.Windows.Forms.Timer(this.components);
            this.BATB2 = new System.Windows.Forms.Timer(this.components);
            this.BATB3 = new System.Windows.Forms.Timer(this.components);
            this.BATB4 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.player2HB = new System.Windows.Forms.Label();
            this.player1HB = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.player1DHB = new System.Windows.Forms.Label();
            this.player2DHB = new System.Windows.Forms.Label();
            this.winingtext = new System.Windows.Forms.Label();
            this.player2dis = new System.Windows.Forms.PictureBox();
            this.player1dis = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player2dis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1dis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // RAT1
            // 
            this.RAT1.Interval = 300;
            this.RAT1.Tick += new System.EventHandler(this.RAT1_Tick);
            // 
            // RAT2
            // 
            this.RAT2.Interval = 300;
            this.RAT2.Tick += new System.EventHandler(this.RAT2_Tick);
            // 
            // RAT3
            // 
            this.RAT3.Interval = 300;
            this.RAT3.Tick += new System.EventHandler(this.RAT3_Tick);
            // 
            // RAT4
            // 
            this.RAT4.Interval = 300;
            this.RAT4.Tick += new System.EventHandler(this.RAT4_Tick);
            // 
            // RATB1
            // 
            this.RATB1.Interval = 300;
            this.RATB1.Tick += new System.EventHandler(this.RATB1_Tick);
            // 
            // RATB2
            // 
            this.RATB2.Interval = 300;
            this.RATB2.Tick += new System.EventHandler(this.RATB2_Tick);
            // 
            // RATB3
            // 
            this.RATB3.Interval = 300;
            this.RATB3.Tick += new System.EventHandler(this.RATB3_Tick);
            // 
            // RATB4
            // 
            this.RATB4.Interval = 300;
            this.RATB4.Tick += new System.EventHandler(this.RATB4_Tick);
            // 
            // BATB1
            // 
            this.BATB1.Interval = 300;
            this.BATB1.Tick += new System.EventHandler(this.BATB1_Tick);
            // 
            // BAT1
            // 
            this.BAT1.Interval = 300;
            this.BAT1.Tick += new System.EventHandler(this.BAT1_Tick);
            // 
            // BAT2
            // 
            this.BAT2.Interval = 300;
            this.BAT2.Tick += new System.EventHandler(this.BAT2_Tick);
            // 
            // BAT3
            // 
            this.BAT3.Interval = 300;
            this.BAT3.Tick += new System.EventHandler(this.BAT3_Tick);
            // 
            // BAT4
            // 
            this.BAT4.Interval = 300;
            this.BAT4.Tick += new System.EventHandler(this.BAT4_Tick);
            // 
            // BATB2
            // 
            this.BATB2.Interval = 300;
            this.BATB2.Tick += new System.EventHandler(this.BATB2_Tick);
            // 
            // BATB3
            // 
            this.BATB3.Interval = 300;
            this.BATB3.Tick += new System.EventHandler(this.BATB3_Tick);
            // 
            // BATB4
            // 
            this.BATB4.Interval = 300;
            this.BATB4.Tick += new System.EventHandler(this.BATB4_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 524);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "A = walk back";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(93, 498);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "D = walk forward";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(93, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Red Player Pontrols";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(93, 548);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "S = crouch / block";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(93, 571);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "W = punch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(696, 571);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "I = punch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(696, 548);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "K = crouch / block";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label8.Location = new System.Drawing.Point(696, 480);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "blue Player Pontrols";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(696, 498);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 24);
            this.label9.TabIndex = 11;
            this.label9.Text = "J = walk forward";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(696, 524);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "L = walk back";
            // 
            // player2HB
            // 
            this.player2HB.AutoSize = true;
            this.player2HB.BackColor = System.Drawing.Color.Black;
            this.player2HB.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2HB.ForeColor = System.Drawing.Color.White;
            this.player2HB.Location = new System.Drawing.Point(857, 31);
            this.player2HB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2HB.Name = "player2HB";
            this.player2HB.Size = new System.Drawing.Size(101, 24);
            this.player2HB.TabIndex = 15;
            this.player2HB.Text = "Loading";
            // 
            // player1HB
            // 
            this.player1HB.AutoSize = true;
            this.player1HB.BackColor = System.Drawing.Color.Black;
            this.player1HB.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1HB.ForeColor = System.Drawing.Color.White;
            this.player1HB.Location = new System.Drawing.Point(93, 31);
            this.player1HB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1HB.Name = "player1HB";
            this.player1HB.Size = new System.Drawing.Size(101, 24);
            this.player1HB.TabIndex = 16;
            this.player1HB.Text = "Loading";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(93, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(400, 37);
            this.label11.TabIndex = 17;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(572, 54);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(400, 37);
            this.label12.TabIndex = 18;
            this.label12.Text = "label12";
            // 
            // player1DHB
            // 
            this.player1DHB.BackColor = System.Drawing.Color.IndianRed;
            this.player1DHB.Location = new System.Drawing.Point(101, 60);
            this.player1DHB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1DHB.Name = "player1DHB";
            this.player1DHB.Size = new System.Drawing.Size(387, 25);
            this.player1DHB.TabIndex = 19;
            // 
            // player2DHB
            // 
            this.player2DHB.BackColor = System.Drawing.Color.RoyalBlue;
            this.player2DHB.Location = new System.Drawing.Point(579, 60);
            this.player2DHB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2DHB.Name = "player2DHB";
            this.player2DHB.Size = new System.Drawing.Size(387, 25);
            this.player2DHB.TabIndex = 20;
            // 
            // winingtext
            // 
            this.winingtext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.winingtext.Font = new System.Drawing.Font("Magneto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winingtext.Location = new System.Drawing.Point(22, 119);
            this.winingtext.Name = "winingtext";
            this.winingtext.Size = new System.Drawing.Size(1010, 63);
            this.winingtext.TabIndex = 21;
            this.winingtext.Text = " KO RED is the VICTOR";
            this.winingtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winingtext.Visible = false;
            // 
            // player2dis
            // 
            this.player2dis.BackColor = System.Drawing.Color.Transparent;
            this.player2dis.ErrorImage = null;
            this.player2dis.Location = new System.Drawing.Point(739, 162);
            this.player2dis.Margin = new System.Windows.Forms.Padding(4);
            this.player2dis.Name = "player2dis";
            this.player2dis.Size = new System.Drawing.Size(160, 222);
            this.player2dis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2dis.TabIndex = 4;
            this.player2dis.TabStop = false;
            // 
            // player1dis
            // 
            this.player1dis.BackColor = System.Drawing.Color.Transparent;
            this.player1dis.ErrorImage = null;
            this.player1dis.Location = new System.Drawing.Point(155, 162);
            this.player1dis.Margin = new System.Windows.Forms.Padding(4);
            this.player1dis.Name = "player1dis";
            this.player1dis.Size = new System.Drawing.Size(160, 222);
            this.player1dis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1dis.TabIndex = 3;
            this.player1dis.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::Pong.Properties.Resources.pixil_frame_0__22_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 462);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.Controls.Add(this.winingtext);
            this.Controls.Add(this.player2DHB);
            this.Controls.Add(this.player1DHB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.player1HB);
            this.Controls.Add(this.player2HB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player2dis);
            this.Controls.Add(this.player1dis);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player2dis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1dis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer RAT1;
        private System.Windows.Forms.Timer RAT2;
        private System.Windows.Forms.Timer RAT3;
        private System.Windows.Forms.Timer RAT4;
        private System.Windows.Forms.Timer RATB1;
        private System.Windows.Forms.Timer RATB2;
        private System.Windows.Forms.Timer RATB3;
        private System.Windows.Forms.Timer RATB4;
        private System.Windows.Forms.Timer BATB1;
        private System.Windows.Forms.Timer BAT1;
        private System.Windows.Forms.Timer BAT2;
        private System.Windows.Forms.Timer BAT3;
        private System.Windows.Forms.Timer BAT4;
        private System.Windows.Forms.Timer BATB2;
        private System.Windows.Forms.Timer BATB3;
        private System.Windows.Forms.Timer BATB4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox player2dis;
        private System.Windows.Forms.PictureBox player1dis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label player2HB;
        private System.Windows.Forms.Label player1HB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label player1DHB;
        private System.Windows.Forms.Label player2DHB;
        private System.Windows.Forms.Label winingtext;
    }
}

