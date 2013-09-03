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

        public Greyhound(PictureBox picBox, Random ran)
        {
            StartingPosition = 0;
            RacetrackLength = 780;  //Figure out what this value should be.
            MyPictureBox = picBox;
            TakeStartingPosition();
            Randomizer = ran;
        }

        /* 1. Move forward a random space between 1 and 4.
         * 2. Update the position of MyPictureBox on the form.
         * 3. Return true if Greyhound wins the race.
         */
        public bool Run()
        {
            int distance = Randomizer.Next(4) + 1;
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            if (MyPictureBox.Location.X >= RacetrackLength)
                return true;
            else
                return false;
        }

        //Reset location to start line.
        public void TakeStartingPosition()
        {
            Location = 0;
            Point p = MyPictureBox.Location;
            p.X = 0;
            MyPictureBox.Location = p;
        }
    }
}
