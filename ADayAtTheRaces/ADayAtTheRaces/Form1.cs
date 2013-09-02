using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public partial class Form1 : Form
    {
        Guy[] guyArray = new Guy[3];
        Greyhound[] greyhoundArray = new Greyhound[4];
        bool raceInProgress = false;

        public Form1()
        {
            InitializeComponent();
            //Initialize Guy objects
            guyArray[0] = new Guy("Joe", joeRadioButton, 50, joeBetLabel);
            guyArray[1] = new Guy("Bob", bobRadioButton, 75, bobBetLabel);
            guyArray[2] = new Guy("Al", alRadioButton, 45, alBetLabel);
            //Initialize Geyhound objects
            greyhoundArray[0] = new Greyhound(Dog1PictureBox);
            greyhoundArray[1] = new Greyhound(Dog2PictureBox);
            greyhoundArray[2] = new Greyhound(Dog3PictureBox);
            greyhoundArray[3] = new Greyhound(Dog4PictureBox);
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Text = "Al";
        }

        private void amountUpDown_ValueChanged(object sender, EventArgs e)
        {
            minimumBetLabel.Text = "Minimum Bet: " + amountUpDown.Minimum;
        }

        private void betsButton_Click(object sender, EventArgs e)
        {
            if (joeRadioButton.Checked)
            {
                guyArray[0].PlaceBet((int)amountUpDown.Value, (int)dogNumUpDown.Value);
                guyArray[0].UpdateLabels();
            }
            else if (bobRadioButton.Checked)
            {
                guyArray[1].PlaceBet((int)amountUpDown.Value, (int)dogNumUpDown.Value);
                guyArray[1].UpdateLabels();
            }
            else if (alRadioButton.Checked)
            {
                guyArray[2].PlaceBet((int)amountUpDown.Value, (int)dogNumUpDown.Value);
                guyArray[2].UpdateLabels();
            }
            else
            {
                MessageBox.Show("No RadioButton is checked. Something went wrong.");
            }
        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            if (!raceInProgress) {
                raceInProgress = true;
                int winner = -1;
                while (raceInProgress) 
                {
                    for (int i = 0; i < greyhoundArray.Length; i++)
                    {
                        //Run one pace and exit if we have a winner.
                        if (greyhoundArray[i].Run()) //Returns true if Greyhound wins the race.
                        {
                            raceInProgress = false; //This dog just won the race, so stop the race.
                            winner = i+1;
                            break;
                        }
                    }
                }
                //Notify each guy which dog won so they can collect winnings.
                for (int i = 0; i < guyArray.Length; i++)
                {
                    guyArray[i].Collect(winner);
                }
            }
        }

    }
}
