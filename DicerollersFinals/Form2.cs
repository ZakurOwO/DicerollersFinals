using DicerollersFinals.Properties;
using System;
using System.Windows.Forms;

namespace DicerollersFinals
{
    public partial class Form2 : Form
    {
        private int userBet;
        private int currentBalance;

        public Form2(int bet, int balance)
        {
            InitializeComponent();
            userBet = bet;
            currentBalance = balance;
        }

        private readonly Random randomgen = new Random();

        public int RandomNumber(int min, int max)
        {
            return randomgen.Next(min, max + 1); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            YourBetLabel.Text = $"{userBet}";
            BalanceDigits.Text = $"${currentBalance}";
        }

        private void ROLL_Click(object sender, EventArgs e)
        {
            ROLL.Enabled = false;

            int number1 = RandomNumber(1, 6);
            int number2 = RandomNumber(1, 6);
            int number3 = RandomNumber(1, 6);
            int total = number1 + number2 + number3;

            UserNumLabel.Text = total.ToString();
            ShowDice(number1, number2, number3);

            if (total >= 10)
            {
                currentBalance += userBet * 2;
                MessageBox.Show($"You WON! 🎉\nYou now have ${currentBalance}", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currentBalance = 0;
                MessageBox.Show($"You LOST! 😢\nYou now have $0", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            BalanceDigits.Text = $"${currentBalance}";
        }

        private void ShowDice(int num1, int num2, int num3)
        {
            PictureBox[] dicePics = { PicDice1, PicDice2, PicDice3 };
            int[] values = { num1, num2, num3 };

            for (int i = 0; i < 3; i++)
            {
                switch (values[i])
                {
                    case 1: dicePics[i].Image = Resources.perspective_dice_six_faces_one; break;
                    case 2: dicePics[i].Image = Resources.perspective_dice_six_faces_two; break;
                    case 3: dicePics[i].Image = Resources.perspective_dice_six_faces_three; break;
                    case 4: dicePics[i].Image = Resources.perspective_dice_six_faces_four; break;
                    case 5: dicePics[i].Image = Resources.perspective_dice_six_faces_five; break;
                    case 6: dicePics[i].Image = Resources.perspective_dice_six_faces_six; break;
                }
            }
        }

        private void BalanceDigits_Click(object sender, EventArgs e)
        {
            
        }
    }
}
