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
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void EnterBalanceBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterBalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void SubmitBalanceButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(EnterBalanceBox.Text, out int balance) && balance >= 0)
            {
                FrontPage frontPage = new FrontPage(balance);
                frontPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter a valid non-negative balance.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
    }
    

