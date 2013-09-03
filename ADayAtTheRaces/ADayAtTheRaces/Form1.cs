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
        Random Randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            //Initialize Guy objects
            guyArray[0] = new Guy("Joe", joeRadioButton, 50, joeBetLabel);
            guyArray[1] = new Guy("Bob", bobRadioButton, 75, bobBetLabel);
            guyArray[2] = new Guy("Al", alRadioButton, 45, alBetLabel);
            //Initialize Geyhound objects
            greyhoundArray[0] = new Greyhound(Dog1PictureBox, Randomizer);
            greyhoundArray[1] = new Greyhound(Dog2PictureBox, Randomizer);
            greyhoundArray[2] = new Greyhound(Dog3PictureBox, Randomizer);
            greyhoundArray[3] = new Greyhound(Dog4PictureBox, Randomizer);
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
            //Start the race.
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < greyhoundArray.Length; i++)
            {
                if (greyhoundArray[i].Run())
                {
                    timer.Stop();
                    MessageBox.Show("We have a winner - dog #" + (i+1));

                    //Notify each guy which dog won so they can collect winnings.
                    for (int j = 0; j < guyArray.Length; j++)
                    {
                        guyArray[j].Collect(i+1);
                    }
                    
                    //Reset for next race.
                    for (int j = 0; j < greyhoundArray.Length; j++)
                    {
                        greyhoundArray[j].TakeStartingPosition();
                    }

                    //Exit race.
                    break;
                }
            }
        }

    }
}
