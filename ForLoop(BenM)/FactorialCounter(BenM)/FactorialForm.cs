/*
 * Created by: Ben M
 * Created on: 27-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #23-Factorial counter
 * This program calculates the factorials of an entered number
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

namespace FactorialCounter_BenM_
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
            this.lblFactorialAns.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Declares variables
            double aNumb, factorialAns;
            int factorialCounter;

            //Clears list box
            this.lstFactorials.Items.Clear();

            //Get numb from user
            aNumb = Convert.ToDouble(txtNumb.Text);

            factorialAns = 1;
            //Gets the factorials
            for (factorialCounter=1;factorialCounter  <= aNumb; factorialCounter++)
            {
                lstFactorials.Items.Add(factorialCounter);
                factorialAns = factorialAns * factorialCounter;

            }

            //Displays stuff in the label
            this.lblFactorialAns.Show();
            this.lblFactorialAns.Text = this.txtNumb.Text + "! = " + Convert.ToString(factorialAns);

        }
    }
}
