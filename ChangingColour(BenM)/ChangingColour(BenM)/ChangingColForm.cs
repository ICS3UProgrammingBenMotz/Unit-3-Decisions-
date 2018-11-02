/*
 * Created by: Ben Motz
 * Created on: 02-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #27 - Control Objects
 * This program changes colour of objects when somthing is clicked
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

namespace ChangingColour_BenM_
{
    public partial class frmChangingCol : Form
    {
        public frmChangingCol()
        {
            InitializeComponent();
        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //Changes colour 
            foreach (Control aControlObject in this.Controls)
            {
                aControlObject.BackColor = Color.LimeGreen;
                this.BackColor = Color.Khaki;
                //if object = label chnage the colour to red
                if (aControlObject.GetType() == typeof(Label))
                {
                    aControlObject.BackColor = Color.Red;
                }
            }

            
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            foreach (Control aControlObject in this.Controls)
                aControlObject.BackColor = Color.HotPink;
            this.BackColor = Color.HotPink;
        }
    }
}
