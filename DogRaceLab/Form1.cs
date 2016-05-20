using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRaceLab {
    public partial class Form1 : Form {

        Guy[] guys = new Guy[3];
        Greyhound[] dogs = new Greyhound[4];
        
        public Form1() {
            InitializeComponent();

            minimumBetLabel.Text = "Minimum Bet: $" + betUpDown.Minimum;
            bettorNameLabel.Text = "Joe";

            // initialize the guys array
            guys[0] = new Guy() { name = "Joe", cash = 50, myLabel = joeBetLabel, myRadioButton = joeRadioButton, myBet = new Bet() };
            guys[1] = new Guy() { name = "Bob", cash = 50, myLabel = bobBetLabel, myRadioButton = bobRadioButton, myBet = new Bet() };
            guys[2] = new Guy() { name = "Al", cash = 15, myLabel = halBetLabel, myRadioButton = halRadioButton, myBet = new Bet() };

            // and update their labels
            for (int i = 0; i < guys.Length; i++) {
                guys[i].ClearBet();
                guys[i].UpdateLabels();
            }

            // initialize the RNG and the dogs array
            Random MyRandomizer = new Random();
            dogs[0] = new Greyhound() { myPictureBox = dog1Picture, racetrackLength = raceTrackPicture.Width - dog1Picture.Width, startingPosition = dog1Picture.Left, Randomizer = MyRandomizer, handicap = 100 };
            dogs[1] = new Greyhound() { myPictureBox = dog2Picture, racetrackLength = raceTrackPicture.Width - dog2Picture.Width, startingPosition = dog2Picture.Left, Randomizer = MyRandomizer, handicap = 100 };
            dogs[2] = new Greyhound() { myPictureBox = dog3Picture, racetrackLength = raceTrackPicture.Width - dog3Picture.Width, startingPosition = dog3Picture.Left, Randomizer = MyRandomizer, handicap = 100 };
            dogs[3] = new Greyhound() { myPictureBox = dog4Picture, racetrackLength = raceTrackPicture.Width - dog4Picture.Width, startingPosition = dog4Picture.Left, Randomizer = MyRandomizer, handicap = 100 };
        }

        private void betButton_Click(object sender, EventArgs e) {
            int index = 0;
            if (joeRadioButton.Checked) { index = 0; };
            if (bobRadioButton.Checked) { index = 1; };
            if (halRadioButton.Checked) { index = 2; };
            if (guys[index].cash == 0) {
                MessageBox.Show("You're broke, go home!", "You may have a gambling problem...");
            } else {
                if (!guys[index].PlaceBet((int)betUpDown.Value, (int)dogUpDown.Value)) {
                    if (MessageBox.Show("Not enough cash, bet all remaining cash instead?", "Go for broke?", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        guys[index].PlaceBet(guys[index].cash, (int)dogUpDown.Value);
                        guys[index].UpdateLabels();
                    }
                } else {
                    guys[index].UpdateLabels();
                }
            }
        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e) {
            bettorNameLabel.Text = "Joe";
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e) {
            bettorNameLabel.Text = "Bob";
        }

        private void alRadioButton_CheckedChanged(object sender, EventArgs e) {
            bettorNameLabel.Text = "Hal";
        }

        private void raceButton_Click(object sender, EventArgs e) {
            bool anyBettors = false;                                                // sets flag to false then checks each guy object for a bet
            for (int i = 0; i < guys.Length; i++) {                                 // as soon as one is found the race is allowed to proceed
                if (guys[i].myBet.amount > 0) {                                     // all of the guys will have their bets polled (including $0) after the race
                    anyBettors = true;
                    break;
                }
            }
            if (anyBettors) {
                for (int i = 0; i < dogs.Length; i++) {
                    dogs[i].TakeStartingPosition();
                }
                timer1.Start();
            } else {
                MessageBox.Show("Nobody has placed bets, not starting a race!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            for (int i = 0; i < dogs.Length; i++) {
                if (dogs[i].Run()) {           // the loop runs until true when there is a winner, so index i is the winner               
                    timer1.Stop();

                    // process the myBet object of each guy
                    // call myBet.Payout(int dog) which will determine if they won or lost any money
                    // display a message box with details about the race and winners

                    string title = "Dog #" + (i + 1) + " has won the race with a handicap of " + dogs[i].handicap;
                    string outcome = "";
                    string winners = "";
                    string losers = "";

                    for (int k = 0; k < guys.Length; k++) {  // go through the guys array
                        if (guys[k].myBet.amount > 0) {  // bet?
                            int payout = guys[k].myBet.PayOut(i, dogs[i].handicap);
                            guys[k].cash += payout;  // their cash is adjusted by either 0 for not betting or a signed int
                            if (payout > 0) {  // won
                                winners += "*** " + guys[k].name + " WON $" + payout + " *** from a $" + guys[k].myBet.amount + " bet on dog #" + guys[k].myBet.dog + " and now has $" + guys[k].cash + "\n";
                            } else {  // lost
                                payout *= -1;
                                losers += guys[k].name + " lost $" + payout + " on dog #" + guys[k].myBet.dog + " and now has $" + guys[k].cash + ".\n";
                            }
                        }
                    }

                    if (winners == "") winners = "No winners!\n";
                    // winners on top!
                    outcome = winners + "\n" + losers;
                    // show the outcome and optionally reset the bets
                    outcome += "\nReset the bets?";
                    if (MessageBox.Show(outcome, title, MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        for (int j = 0; j < guys.Length; j++) {
                            guys[j].ClearBet();
                            guys[j].UpdateLabels();
                        }
                    } else {
                        for (int j = 0; j < guys.Length; j++) {
                            if (guys[j].cash < guys[j].myBet.amount) { // logic to prevent a rebet when there's insufficient cash
                                MessageBox.Show(guys[j].name + " doesn't have enough cash to repeat the bet, removing it!");  // going to "go for broke" would be better here...
                                guys[j].ClearBet();
                            }
                            guys[j].UpdateLabels();                  
                        }
                    }

                    // adjust handicaps
                        for (int q = 0; q < dogs.Length; q++) {
                        if (q == i) { // winner?
                            dogs[q].handicap = 100;
                        } else {
                            dogs[q].handicap += 50;  // loser
                        }
                    }
                    break;  // can't have more than one dog winning next tick!
                }
            }
        }

        private void joeBetLabel_Click(object sender, EventArgs e) {
            guys[0].ClearBet();
            guys[0].UpdateLabels();
        }

        private void bobBetLabel_Click(object sender, EventArgs e) {
            guys[1].ClearBet();
            guys[0].UpdateLabels();
        }

        private void halBetLabel_Click(object sender, EventArgs e) {
            guys[2].ClearBet();
            guys[0].UpdateLabels();
        }
    }
}