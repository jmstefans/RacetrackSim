using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            /* TODO:
             * 1. Set MyLabel to my bet's description.
             * 2. Set label on MyRadioButton to show my cash.
             */
        }

        public void ClearBet()
        {
            /* TODO:
             * 1. Reset bet to 0.
             */
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            /* TODO:
             * 1. Place new bet.
             * 2. Store in MyBet field.
             * 3. Return true if Guy had enough money to bet.
             */
        }

        public void Collect(int Winner)
        {
            /* TODO:
             * 1. Call Bet object to PayOut.
             * 2. Be gangsta rich.
             */
        }
    }
}
