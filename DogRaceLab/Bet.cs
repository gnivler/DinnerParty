using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceLab {
    public class Bet {
        public int amount; // the amount of cash that was bet
        public int dog; // the number of the dog the bet is placed on
        public Guy bettor; // the guy who placed the bet

        public int PayOut (int winner, int handicap) {
            // the parameter is the winner of the race.  if the dog won, return the amount of the bet
            // otherwise, return the negative amount of bet
            // handicap is a growing percentage and is reset on a win

            if ((dog - 1) == winner) {
                return (amount * handicap) / 100;
            } else {
                return -amount;
            }
        }
    }
}