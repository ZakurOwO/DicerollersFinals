namespace DicerollersFinals
{
    partial class Form3
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
            this.EnterBalanceLabel = new System.Windows.Forms.Label();
            this.EnterBalanceBox = new System.Windows.Forms.TextBox();
            this.SubmitBalanceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterBalanceLabel
            // 
            this.EnterBalanceLabel.AutoSize = true;
            this.EnterBalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.EnterBalanceLabel.Location = new System.Drawing.Point(13, 60);
            this.EnterBalanceLabel.Name = "EnterBalanceLabel";
            this.EnterBalanceLabel.Size = new System.Drawing.Size(234, 30);
            this.EnterBalanceLabel.TabIndex = 3;
            this.EnterBalanceLabel.Text = "Enter your balance:";
            this.EnterBalanceLabel.Click += new System.EventHandler(this.EnterBalanceLabel_Click);
            // 
            // EnterBalanceBox
            // 
            this.EnterBalanceBox.Location = new System.Drawing.Point(41, 93);
            this.EnterBalanceBox.Name = "EnterBalanceBox";
            this.EnterBalanceBox.Size = new System.Drawing.Size(178, 20);
            this.EnterBalanceBox.TabIndex = 4;
            this.EnterBalanceBox.TextChanged += new System.EventHandler(this.EnterBalanceBox_TextChanged);
            // 
            // SubmitBalanceButton
            // 
            this.SubmitBalanceButton.Location = new System.Drawing.Point(91, 119);
            this.SubmitBalanceButton.Name = "SubmitBalanceButton";
            this.SubmitBalanceButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitBalanceButton.TabIndex = 5;
            this.SubmitBalanceButton.Text = "Submit";
            this.SubmitBalanceButton.UseVisualStyleBackColor = true;
            this.SubmitBalanceButton.Click += new System.EventHandler(this.SubmitBalanceButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 196);
            this.Controls.Add(this.SubmitBalanceButton);
            this.Controls.Add(this.EnterBalanceBox);
            this.Controls.Add(this.EnterBalanceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label EnterBalanceLabel;
        private System.Windows.Forms.TextBox EnterBalanceBox;
        private System.Windows.Forms.Button SubmitBalanceButton;
    }
}