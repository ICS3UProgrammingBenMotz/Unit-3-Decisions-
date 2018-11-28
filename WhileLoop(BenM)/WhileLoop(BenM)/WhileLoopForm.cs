/*
 * Created by: Ben M
 * Created on: 27-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22- WhileLoop
 * This program calculates the perfect square of a certain numb
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

namespace WhileLoop_BenM_
{
    public partial class frmWhileLoop : Form
    {
        public frmWhileLoop()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Creates varaibles
            int endVal;
            int val;
            Double squareRAsDoub;
            int squareRAsInt;

            //Makes val = 1
            val = 1;

            //Clears items for lst box
            this.lstPerfectSquares.Items.Clear();

            //gets user's entry
            endVal = Convert.ToInt32(nudNumber.Value);

            //creates while loop
            while (val<=endVal)
            {
                //square roots val
                squareRAsDoub = Math.Sqrt(val);

                //converts to a int32
                squareRAsInt = Convert.ToInt32(squareRAsDoub);

                if (squareRAsDoub==squareRAsInt)
                {
                    //adds it ot lst box
                    this.lstPerfectSquares.Items.Add(val + " is a perfect square");

                    //refresh form
                    this.Refresh();
                }
                //increments val by 1
                val++;

            }
        }
    }
}
