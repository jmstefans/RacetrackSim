using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADayAtTheRaces
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            /* TODO:
             * 1. Initialize string.
             * 2. Add Bettor's name, how much cash was bet, and which dog was bet on to string.
             * 2a. Ex: "Joe bets $8 on dog #4."
             * 2b. If amount is 0, "Joe hasn't placed a bet."
             */
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
