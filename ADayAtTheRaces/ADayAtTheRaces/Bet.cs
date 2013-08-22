using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;
        
        public Bet(int anAmount, int aDog, Guy aGuy)
        {
            Amount = anAmount;
            Dog = aDog;
            Bettor = aGuy;
        }

        //Return a string representing the Bet.
        public string GetDescription()
        {
            if (Amount > 0)
                return Bettor.Name + " bets $" + Amount + " on dog #" + Dog;
            else if (Amount == 0)
                return Bettor.Name + " hasn't placed a bet.";
            else 
                MessageBox.Show("You can't make a bet with a negative amount.");
        }

        public int PayOut(int Winner)
        {
            /* TODO:
             * 1. If the dog won, return the amount bet. 
             *    Else return the negative of the amount bet.
             */
        }
    }
}
