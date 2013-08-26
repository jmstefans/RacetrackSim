using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public Guy(string aName, RadioButton aRadioButton, int someCash, Label aLabel)
        {
            Name = aName;
            MyBet = new Bet(0,0,this);
            Cash = someCash;
            MyRadioButton = aRadioButton;
            MyLabel = aLabel;
            UpdateLabels();
        }

        /* 1. Set MyLabel to my bet's description.
         * 2. Set label on MyRadioButton to show my cash.
         */
        public void UpdateLabels()
        {
            MyLabel.Text = MyBet.GetDescription();
            MyRadioButton.Text = Name + " has " + Cash + " bucks";
        }

        //Reset bet to 0.
        public void ClearBet()
        {
            MyBet = null;
        }

        /* 1. Place new bet.
         * 2. Store in MyBet field.
         * 3. Return true if Guy had enough money to bet.
         */
        public bool PlaceBet(int Amount, int Dog)
        {
            if (Amount <= Cash)
            {
                MyBet = new Bet(Amount, Dog, this);
                return true;
            }
            else
                return false;
        }

        public void Collect(int Winner)
        {
            /* TODO:
             * 1. Call Bet object to PayOut.
             * 2. Be gangsta rich.
             */
            if (MyBet != null)
                MyBet.PayOut(Winner);
            else
                MessageBox.Show("MyBet is null.");
        }
    }
}
