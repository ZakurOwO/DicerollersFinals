using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DicerollersFinals
{
    public partial class FrontPage : Form
    {
        private int currentBalance;

        public FrontPage(int balance)
        {
            InitializeComponent();
            currentBalance = balance;
        }



        private void InputBet_TextChanged(object sender, EventArgs e)
        {

        }

        private void BetButton_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(InputBet.Text))
            {
                MessageBox.Show("Please input your desired bet", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (int.TryParse(InputBet.Text, out int bet))
                {
                    if (bet >= 1 && bet <= 18)
                    {
                        Form2 form2 = new Form2(bet, currentBalance);
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("1 - 18 only", "Invalid Bet", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}