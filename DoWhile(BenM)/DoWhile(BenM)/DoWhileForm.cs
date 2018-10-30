/*
 * Created by: Ben Motz
 * Created on: 29-10-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
 * This program shows a progress bar increase whne a button is pressed.
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

namespace DoWhile_BenM_
{
    public partial class frmDoWhile : Form
    {
        public frmDoWhile()
        {
            InitializeComponent();
        }

        private void btnPressMe_Click(object sender, EventArgs e)
        {
            //declares constants and variable
            const int MAX_PROGRESS_VALUE = 100;
            int progressbarvalue = 0;

            //Makes progress bar increase
            do
            {
                this.prbBar.Value = progressbarvalue;
                progressbarvalue = progressbarvalue + 5;
                this.Refresh();
            } while (progressbarvalue <= MAX_PROGRESS_VALUE);
    }

    }
}

