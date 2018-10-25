/*
 * Created by: Ben Motz
 * Created on: 10-Oct-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #16 - Guessing Game
 * This program is a  game where a user guesses a generated number
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGameBenM
{
    public partial class frmGuessGame : Form
    {
        public frmGuessGame()
        {
            InitializeComponent();
        }

        private void frmGuessGame_Load(object sender, EventArgs e)
        {
            //Hides lblRightWrong and picbox
            this.lblRightWrong.Hide();
            this.picRightWrong.Hide();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
           //Creates variables, Random generated number was found on cplusplus.com. It generates a random number.
            Random rnd = new Random();
            double ans = rnd.Next(1, 11);
            double guess=(double)(nudGuessN.Value);

            //Is user's guess right,
            if (guess == ans)
            {
                this.lblRightWrong.Show();
                this.picRightWrong.Show();
                this.lblRightWrong.Text = "Great job! That is right.";
                this.picRightWrong.Image = Properties.Resources.checkmark;
            }
            //If user is wrong 
            else
            {
                this.lblRightWrong.Show();
                this.picRightWrong.Show();
                this.lblRightWrong.Text = "Wrong, try again.";
                this.picRightWrong.Image = Properties.Resources.red_x;
                
                
            }

        }
    }
}
