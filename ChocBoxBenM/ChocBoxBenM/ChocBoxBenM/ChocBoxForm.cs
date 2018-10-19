/*
 * Created by: Ben Motz
 * Created on: 18-19-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program displays what you get from delivering boxes.
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

namespace ChocBoxBenM
{
    public partial class frmChocBox : Form
    {
        public frmChocBox()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Determines Prize
            if (nudNumbOfBox.Value >20)
            {
                this.lblReward.Show();
                this.lblReward.Text = "You get a prize";
            }
            else if (nudNumbOfBox.Value < 10)
            {
                this.lblReward.Show();
                this.lblReward.Text = "You get an honorable mention";
            }
            else
            {
                this.lblReward.Show();
                this.lblReward.Text = "You get a small prize";
            }
          
        }

        private void frmChocBox_Load(object sender, EventArgs e)
        {
            //Hides Label
            this.lblReward.Hide();
        }

        private void lblReward_Click(object sender, EventArgs e)
        {

        }
    }
}
