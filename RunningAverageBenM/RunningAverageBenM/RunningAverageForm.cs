/*
 * Created by: Ben M
 * Created on: 27-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #29 - Running Average
 * This program calculates a person's average
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

namespace RunningAverageBenM
{
    public partial class frmRunningAverage : Form
    {
        //sets variables
        double average=0, numbOfMarks=0, total=0;

        private void lblFinalMark_Click(object sender, EventArgs e)
        {

        }

        public frmRunningAverage()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //decalres what mark will be
            double mark;
            mark = double.Parse(txtAverage.Text);

            if (mark > 0 && mark <100)
            {
                //Creates total
                total = (double)mark + total;
               
                //Increments it
                numbOfMarks++;
               
                //Calculation for average
                average = (double)total / numbOfMarks;
                
                //Displays average
                lblFinalMark.Text = "Your average is " + average + "%";          
            }
            else if (mark == -1)
            {
                //Displays final mark
                lblFinalMark.Text = "Your final average is " +average + "%";
            }
            else
            {
                //displays message box if a non-proper value is entered
                MessageBox.Show("Please enter a prorper value");
            }

        }
    }
}
