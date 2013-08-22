using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ADayAtTheRaces
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            /*TODO:
             * 1. Move forward a random space between 1 and 4.
             * 2. Update the position of MyPictureBox on the form.
             * 3. Return true if Greyhound wins the race.
            */
        }

        //Reset location to start line.
        public void TakeStartingPosition()
        {
            this.Location = 0;
        }
    }
}
