namespace DicerollersFinals
{
    partial class Form2
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
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ROLL = new System.Windows.Forms.Button();
            this.UserNumLabel = new System.Windows.Forms.Label();
            this.Displaynum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.YourBetLabel = new System.Windows.Forms.Label();
            this.PicDice1 = new System.Windows.Forms.PictureBox();
            this.PicDice3 = new System.Windows.Forms.PictureBox();
            this.PicDice2 = new System.Windows.Forms.PictureBox();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceDigits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice2)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = null;
            // 
            // ROLL
            // 
            this.ROLL.BackColor = System.Drawing.Color.Snow;
            this.ROLL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ROLL.Location = new System.Drawing.Point(319, 362);
            this.ROLL.Name = "ROLL";
            this.ROLL.Size = new System.Drawing.Size(133, 49);
            this.ROLL.TabIndex = 3;
            this.ROLL.Text = "ROLL";
            this.ROLL.UseVisualStyleBackColor = false;
            this.ROLL.Click += new System.EventHandler(this.ROLL_Click);
            // 
            // UserNumLabel
            // 
            this.UserNumLabel.AutoSize = true;
            this.UserNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNumLabel.Location = new System.Drawing.Point(95, 77);
            this.UserNumLabel.Name = "UserNumLabel";
            this.UserNumLabel.Size = new System.Drawing.Size(51, 55);
            this.UserNumLabel.TabIndex = 4;
            this.UserNumLabel.Text = "0";
            this.UserNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Displaynum
            // 
            this.Displaynum.AutoSize = true;
            this.Displaynum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displaynum.Location = new System.Drawing.Point(12, 38);
            this.Displaynum.Name = "Displaynum";
            this.Displaynum.Size = new System.Drawing.Size(223, 39);
            this.Displaynum.TabIndex = 5;
            this.Displaynum.Text = "Your Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Your Bet";
            // 
            // YourBetLabel
            // 
            this.YourBetLabel.AutoSize = true;
            this.YourBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YourBetLabel.Location = new System.Drawing.Point(652, 77);
            this.YourBetLabel.Name = "YourBetLabel";
            this.YourBetLabel.Size = new System.Drawing.Size(51, 55);
            this.YourBetLabel.TabIndex = 7;
            this.YourBetLabel.Text = "0";
            this.YourBetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicDice1
            // 
            this.PicDice1.Image = global::DicerollersFinals.Properties.Resources.perspective_dice_six_faces_random;
            this.PicDice1.Location = new System.Drawing.Point(76, 168);
            this.PicDice1.Name = "PicDice1";
            this.PicDice1.Size = new System.Drawing.Size(209, 188);
            this.PicDice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDice1.TabIndex = 2;
            this.PicDice1.TabStop = false;
            // 
            // PicDice3
            // 
            this.PicDice3.Image = global::DicerollersFinals.Properties.Resources.perspective_dice_six_faces_random;
            this.PicDice3.Location = new System.Drawing.Point(506, 168);
            this.PicDice3.Name = "PicDice3";
            this.PicDice3.Size = new System.Drawing.Size(209, 188);
            this.PicDice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDice3.TabIndex = 1;
            this.PicDice3.TabStop = false;
            // 
            // PicDice2
            // 
            this.PicDice2.Image = global::DicerollersFinals.Properties.Resources.perspective_dice_six_faces_random;
            this.PicDice2.Location = new System.Drawing.Point(291, 168);
            this.PicDice2.Name = "PicDice2";
            this.PicDice2.Size = new System.Drawing.Size(209, 188);
            this.PicDice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicDice2.TabIndex = 0;
            this.PicDice2.TabStop = false;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(300, 9);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(234, 39);
            this.BalanceLabel.TabIndex = 8;
            this.BalanceLabel.Text = "Your Balance:";
            // 
            // BalanceDigits
            // 
            this.BalanceDigits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BalanceDigits.AutoSize = true;
            this.BalanceDigits.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceDigits.Location = new System.Drawing.Point(357, 48);
            this.BalanceDigits.Name = "BalanceDigits";
            this.BalanceDigits.Size = new System.Drawing.Size(78, 55);
            this.BalanceDigits.TabIndex = 9;
            this.BalanceDigits.Text = "$0";
            this.BalanceDigits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BalanceDigits.Click += new System.EventHandler(this.BalanceDigits_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BalanceDigits);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.YourBetLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Displaynum);
            this.Controls.Add(this.UserNumLabel);
            this.Controls.Add(this.ROLL);
            this.Controls.Add(this.PicDice1);
            this.Controls.Add(this.PicDice3);
            this.Controls.Add(this.PicDice2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicDice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicDice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox PicDice1;
        private System.Windows.Forms.PictureBox PicDice3;
        private System.Windows.Forms.PictureBox PicDice2;
        private System.Windows.Forms.Button ROLL;
        private System.Windows.Forms.Label UserNumLabel;
        private System.Windows.Forms.Label YourBetLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Displaynum;
        private System.Windows.Forms.Label BalanceDigits;
        private System.Windows.Forms.Label BalanceLabel;


    }
}