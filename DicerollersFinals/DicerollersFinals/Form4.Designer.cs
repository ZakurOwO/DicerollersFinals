namespace DicerollersFinals
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.DiceRoll = new System.Windows.Forms.Label();
            this.PicDice3 = new System.Windows.Forms.PictureBox();
            this.PicDice2 = new System.Windows.Forms.PictureBox();
            this.PicDice1 = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.bALANCE = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice1)).BeginInit();
            this.SuspendLayout();
            // 
            // DiceRoll
            // 
            this.DiceRoll.AutoSize = true;
            this.DiceRoll.BackColor = System.Drawing.Color.Black;
            this.DiceRoll.Font = new System.Drawing.Font("Bowlby One SC", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiceRoll.ForeColor = System.Drawing.Color.White;
            this.DiceRoll.Location = new System.Drawing.Point(392, 66);
            this.DiceRoll.Name = "DiceRoll";
            this.DiceRoll.Size = new System.Drawing.Size(170, 42);
            this.DiceRoll.TabIndex = 0;
            this.DiceRoll.Text = "Dice Roll";
            this.DiceRoll.Click += new System.EventHandler(this.label1_Click);
            // 
            // PicDice3
            // 
            this.PicDice3.BackColor = System.Drawing.Color.Black;
            this.PicDice3.Image = global::DicerollersFinals.Properties.Resources.perspective_dice_six_faces_random;
            this.PicDice3.Location = new System.Drawing.Point(548, 160);
            this.PicDice3.Name = "PicDice3";
            this.PicDice3.Size = new System.Drawing.Size(134, 123);
            this.PicDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDice3.TabIndex = 2;
            this.PicDice3.TabStop = false;
            this.PicDice3.Click += new System.EventHandler(this.PicDice3_Click);
            // 
            // PicDice2
            // 
            this.PicDice2.BackColor = System.Drawing.Color.Black;
            this.PicDice2.Image = global::DicerollersFinals.Properties.Resources.perspective_dice_six_faces_random;
            this.PicDice2.Location = new System.Drawing.Point(403, 160);
            this.PicDice2.Name = "PicDice2";
            this.PicDice2.Size = new System.Drawing.Size(139, 123);
            this.PicDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDice2.TabIndex = 3;
            this.PicDice2.TabStop = false;
            // 
            // PicDice1
            // 
            this.PicDice1.BackColor = System.Drawing.Color.Black;
            this.PicDice1.Image = global::DicerollersFinals.Properties.Resources.perspective_dice_six_faces_random;
            this.PicDice1.Location = new System.Drawing.Point(253, 160);
            this.PicDice1.Name = "PicDice1";
            this.PicDice1.Size = new System.Drawing.Size(144, 123);
            this.PicDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDice1.TabIndex = 4;
            this.PicDice1.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.AllowDrop = true;
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(867, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(58, 27);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(788, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "MULTIPLIER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(802, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "0.30";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Location = new System.Drawing.Point(802, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "0.25";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(802, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "0.20\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Location = new System.Drawing.Point(802, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "0.15";
            // 
            // betAmount
            // 
            this.betAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.betAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.betAmount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.betAmount.Location = new System.Drawing.Point(95, 261);
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(92, 33);
            this.betAmount.TabIndex = 15;
            this.betAmount.Text = "50";
            this.betAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.betAmount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.betAmount_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(102, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "BET AMOUNT:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(798, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "PAYOUT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.HotPink;
            this.label8.Location = new System.Drawing.Point(789, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 33);
            this.label8.TabIndex = 18;
            this.label8.Text = "1000";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // rollButton
            // 
            this.rollButton.BackColor = System.Drawing.Color.Purple;
            this.rollButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rollButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rollButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rollButton.Location = new System.Drawing.Point(414, 348);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(122, 41);
            this.rollButton.TabIndex = 19;
            this.rollButton.Text = "ROLL DICE";
            this.rollButton.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(92, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "WALLET BALANCE";
            // 
            // bALANCE
            // 
            this.bALANCE.AutoSize = true;
            this.bALANCE.BackColor = System.Drawing.Color.Black;
            this.bALANCE.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bALANCE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bALANCE.Location = new System.Drawing.Point(109, 136);
            this.bALANCE.Name = "bALANCE";
            this.bALANCE.Size = new System.Drawing.Size(71, 33);
            this.bALANCE.TabIndex = 21;
            this.bALANCE.Text = "5000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(119, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "CREDITS";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(83, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "PREDICTION NUMBER:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.maskedTextBox1.Location = new System.Drawing.Point(97, 368);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(90, 33);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.Text = "1-6";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(965, 578);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bALANCE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.PicDice1);
            this.Controls.Add(this.PicDice2);
            this.Controls.Add(this.PicDice3);
            this.Controls.Add(this.DiceRoll);
            this.DoubleBuffered = true;
            this.Name = "Form4";
            this.Text = "JAJA";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DiceRoll;
        private System.Windows.Forms.PictureBox PicDice3;
        private System.Windows.Forms.PictureBox PicDice2;
        private System.Windows.Forms.PictureBox PicDice1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox betAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bALANCE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}