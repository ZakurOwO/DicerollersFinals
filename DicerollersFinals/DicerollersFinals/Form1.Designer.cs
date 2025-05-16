namespace DicerollersFinals
{
    partial class FrontPage
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.BetButton = new System.Windows.Forms.Button();
            this.InputBet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(37, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(161, 25);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Place your bets";
            // 
            // BetButton
            // 
            this.BetButton.BackColor = System.Drawing.Color.Snow;
            this.BetButton.Location = new System.Drawing.Point(80, 85);
            this.BetButton.Name = "BetButton";
            this.BetButton.Size = new System.Drawing.Size(75, 23);
            this.BetButton.TabIndex = 1;
            this.BetButton.Text = "Bet";
            this.BetButton.UseVisualStyleBackColor = false;
            this.BetButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // InputBet
            // 
            this.InputBet.Location = new System.Drawing.Point(67, 59);
            this.InputBet.Name = "InputBet";
            this.InputBet.Size = new System.Drawing.Size(100, 20);
            this.InputBet.TabIndex = 2;
            this.InputBet.TextChanged += new System.EventHandler(this.InputBet_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "1-18";
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 169);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputBet);
            this.Controls.Add(this.BetButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "FrontPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button BetButton;
        private System.Windows.Forms.TextBox InputBet;
        private System.Windows.Forms.Label label2;

    }
}

