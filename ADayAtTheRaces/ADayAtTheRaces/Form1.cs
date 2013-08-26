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
        public Form1()
        {
            InitializeComponent();
            //Initialize Guy objects
            Guy joe = new Guy("Joe", joeRadioButton, 50, joeBetLabel);
            Guy bob = new Guy("Bob", bobRadioButton, 75, bobBetLabel);
            Guy al = new Guy("Al", alRadioButton, 45, alBetLabel);
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
                MessageBox.Show("Joe selected.");
            }
            else if (bobRadioButton.Checked)
            {
                MessageBox.Show("Bob selected.");
            }
            else if (alRadioButton.Checked)
            {
                MessageBox.Show("Al selected.");
            }
            else
            {
                MessageBox.Show("No RadioButton is checked. Something went wrong.");
            }
        }
    }
}
