using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceLab {
    public class Guy {
        public string name;                         // the guy's name
        public Bet myBet;                           // instance of Bet that has guy's bet
        public int cash;                            // how much cash guy has
        public int guyIndex;

        public RadioButton myRadioButton;           // guy's RadioButton
        public Label myLabel;                       // guy's label
                                                    // the last two fields are the guy's GUI controls on the form

        public void UpdateLabels() {
            // set my label to my bet's description
            // and the label on my radio button to show my cash "Joe has 43 bucks"
            myRadioButton.Text = name + " has $" + cash;
            if (myBet.amount == 0) {
                myLabel.Text = name + " hasn't placed a bet";
            } else {
                myLabel.Text=name + " bets $" + myBet.amount + " on dog #" + myBet.dog;
            }
        }

        public void ClearBet() {  // reset guy's bet to zero
            myBet.amount = 0;
        }

        public bool PlaceBet(int betAmount, int dogToWin) {
            // place a new bet and store it in guy's bet field
            // return true if the guy had enough money for the bet
            myBet = new Bet() { amount = betAmount, dog = dogToWin, bettor = this };
            if (myBet.amount <= cash) {
                return true;
            }
            myBet.amount = 0;
            return false;
        }

        public void Collect(int Winner) {
            // ask my bet to pay out, clear my bet and update my labels
        }
    }
}