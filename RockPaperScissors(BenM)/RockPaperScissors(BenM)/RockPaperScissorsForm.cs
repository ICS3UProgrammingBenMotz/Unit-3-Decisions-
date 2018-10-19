/*
 * Created by: Ben M
 * Created on: 17-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock Paper Scissors
 * This program plays rock paper scissors with the user
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

namespace RockPaperScissors_BenM_
{
    public partial class frmRockPaperScissors : Form
    {


        //Get Random Number
        const int MIN_NUM = 1;
        const int MAX_NUM = 3;
        Random randomNumberGenerator;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            lblWhoWins.Hide();

            //Creates random number generator
            randomNumberGenerator = new Random();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {


        }

        private void btnCheckAns_Click(object sender, EventArgs e)
        {
            //Declare constant and Variables
            const int ROCK = 1, PAPER = 2, SCISSORS = 3;
            int playerchoice, computerchoice;

            //Gets the user's selection
            if (radUserRock.Checked == true)
            {
                playerchoice = ROCK;
            }
            else if (radUserPaper.Checked == true)
            {
                playerchoice = PAPER;
            }
            else if (radUserScissors.Checked == true)
            {
                playerchoice = SCISSORS;
            }
            else
            {
                playerchoice = 0;
            }

            //Generates random number between 1 and 3
            computerchoice = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //Set the radio button for the computer for the computer's choice          
            if (computerchoice == ROCK)
            {
                this.radComputerRock.Checked = true;
            }
            else if (computerchoice == PAPER)
            {
                this.radComputerPaper.Checked = true;
            }
            else if (computerchoice == SCISSORS)
            {
                this.radComputerScissors.Checked = true;
            }

            //Checks who wins

            if (computerchoice == ROCK)
            {
                if (playerchoice == ROCK)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "Tie";
                }
                else if (playerchoice == PAPER)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "You Win!";

                }
                else if (playerchoice == SCISSORS)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "You Lose";
                }
            }
            if (computerchoice == PAPER)
            {
                if (playerchoice == ROCK)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "You Lose";
                }
                else if (playerchoice == PAPER)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "Tie";

                }
                else if (playerchoice == SCISSORS)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "You Win!";
                }
            }
            if (computerchoice == SCISSORS)
            {
                if (playerchoice == ROCK)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "You Win!";
                }
                else if (playerchoice == PAPER)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "You Lose";

                }
                else if (playerchoice == SCISSORS)
                {
                    this.lblWhoWins.Show();
                    this.lblWhoWins.Text = "Tie";
                }
            }
        }
    }
}
