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

            factorialCounter = 0;
            //Gets the factorials
            do
            {
                factorialCounter++;
                lstFactorials.Items.Add(factorialCounter);
                factorialAns = factorialCounter * factorialAns;

            } while (factorialCounter < aNumb);

            //Displays stuff in the label
            this.lblFactorialAns.Show();
            this.lblFactorialAns.Text = this.txtNumb.Text + "! = " + Convert.ToString(factorialAns);

        }
    }
}
