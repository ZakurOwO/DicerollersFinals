using System.Media;
using DicerollersFinals.Properties;
using System;
using System.Threading;
using System.Windows.Forms;

namespace DicerollersFinals
{
    public partial class Form2 : Form
    {
        private int userBet;
        private int currentBalance;
        private bool isRolling = false;

        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer2;


        public Form2(int bet, int balance)
        {
            InitializeComponent();
            userBet = bet;
            currentBalance = balance;

            _soundPlayer = new SoundPlayer("ShakingDice.wav");
            _soundPlayer2 = new SoundPlayer("Dicelanded.wav");
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


        private Thread rollThread;
        private bool stopRolling = false;

        private void ROLL_Click(object sender, EventArgs e)
        {
            if (currentBalance == 0)
            {
                MessageBox.Show("You have no money left! Please restart or add balance.", "Out of Balance", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isRolling)
            {
                isRolling = true;
                stopRolling = false;
                ROLL.Text = "STOP";

                _soundPlayer.PlayLooping();

                rollThread = new Thread(() =>
                {
                    while (!stopRolling)
                    {
                        int r1 = RandomNumber(1, 6);
                        int r2 = RandomNumber(1, 6);
                        int r3 = RandomNumber(1, 6);

                        this.Invoke(new Action(() =>
                        {
                            ShowDice(r1, r2, r3);
                        }));

                        Thread.Sleep(100);
                    }
                });

                rollThread.IsBackground = true;
                rollThread.Start();
            }
            else
            {
                stopRolling = true;
                rollThread.Join();

                _soundPlayer.Stop();
                

                isRolling = false;
                ROLL.Text = "ROLL";



                int number1 = RandomNumber(1, 6);
                int number2 = RandomNumber(1, 6);
                int number3 = RandomNumber(1, 6);
                int total = number1 + number2 + number3;

                ShowDice(number1, number2, number3);
                UserNumLabel.Text = total.ToString();

                if (total == userBet)
                {
                    _soundPlayer2.Play();
                    currentBalance += userBet * 2;
                    MessageBox.Show($"You WON! 🎉\nYou now have ${currentBalance}", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _soundPlayer2.Play();
                    currentBalance = 0;
                   
                    Application.DoEvents();
                    MessageBox.Show($"You LOST! 😢\nYou now have $0", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                BalanceDigits.Text = $"${currentBalance}";
            }
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
