/*
 * Created by: Ben Motz
 * Created on: 1-11-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day 24# - Unicode
 * This program display the character's number in unicode
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

namespace Unicode_BenM_
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declares varaibles
            int counter;
            const int MAXNUMB = 90, MINNUMB = 65;
            string character;

            //Clears lstNumbs
            this.lstNumbs.Items.Clear();

            //Diplays stuff in listbox
            for (counter = MINNUMB; counter <= MAXNUMB; counter++)
            {
                character = char.ConvertFromUtf32(counter);
                lstNumbs.Items.Add(character + "->" + counter);

            }
        }
    }
}
