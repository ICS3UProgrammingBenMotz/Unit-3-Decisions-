/*
 * Created by: Ben M
 * Created on: 05-11-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Alphabet Nested Loops
 * This program displays letters from A to Z with their lowercase letter beside them
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

namespace NestedLoops_BenM_
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Creates Variables
            int secondLetcounter,firstLetcounter;
            string firstLet, secondLet;

            //Clears listbox
            this.lstLetters.Items.Clear();

            //Creates loop
            for (firstLetcounter = 65; firstLetcounter <= 90; firstLetcounter++)
            {
                firstLet = char.ConvertFromUtf32(firstLetcounter);
                //Creates loop for second letter
                for (secondLetcounter=97; secondLetcounter<=122;secondLetcounter++)
                {
                    secondLet = char.ConvertFromUtf32(secondLetcounter);
                    this.lstLetters.Items.Add(firstLet + " -> " + secondLet);

                }
                
            }
        }
    }
}
