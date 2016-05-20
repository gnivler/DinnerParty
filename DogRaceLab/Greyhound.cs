using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceLab {
    public class Greyhound {                    // this class moves the dogs

        public PictureBox myPictureBox = null;  // My PictureBox object
        public int startingPosition;            // where dog's picturebox starts
        public int racetrackLength;             // how long the racetrack is
        public Random Randomizer;               // an instance of Random
        public int handicap;

        public bool Run() {

            // move forward a random number of pixels
            // update the position of dog's PictureBox
            // return true if dog won the race
            myPictureBox.Left += Randomizer.Next(1, 20);
            if (myPictureBox.Left >= racetrackLength) {
                myPictureBox.Left = racetrackLength;  // move the picture to the end of the track and not past
                return true; // winner
            } else {
                return false; // no winner
            }
        }

        public void TakeStartingPosition() {
            myPictureBox.Left = 0;
        }
    }
}