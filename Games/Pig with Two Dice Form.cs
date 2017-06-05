using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Game_Logic_Library;

namespace Games {
    public partial class pigWithTwoDiceForm : Form {
        private PictureBox[] diceImages;
        private string currentPlayer;
        private int firstDice = 0;
        private int secondDice = 1;
        private int counter;
        private Random firstDiceAnimation;
        private Random secondDiceAnimation; 

        public pigWithTwoDiceForm() {
            InitializeComponent();
            diceImages = new PictureBox[] { firstDiceImage, secondDiceImage };
            firstDiceAnimation = new Random();
            secondDiceAnimation = new Random();
            ResetForm();
        }

        /// <summary>
        /// Resets the form so user can play another game
        /// </summary>
        private void ResetForm() {
            anotherGameGroup.Enabled = false;
            holdButton.Enabled = false;
            Pig_Double_Dice_Game.SetUpGame();
            DiceImage();
            currentPlayer = Pig_Double_Dice_Game.GetFirstPlayerName();
            turnLabel.Text = currentPlayer;
            rollOrHoldLabel.Text = "roll Die";
            playerOneText.Clear();
            playerTwoText.Clear();
        }

        /// <summary>
        /// Displayes the die images in the form
        /// </summary>
        private void DiceImage() {
            diceImages[firstDice].Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(firstDice));
            diceImages[secondDice].Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(secondDice));
        }

        private void rollButton_Click(object sender, EventArgs e) {
            rollButton.Enabled = false;
            counter = 0;
            animationTimer.Start();
        }

        private void animationTimer_Tick(object sender, EventArgs e) {
            counter++;
            int animationDuration = 11;
            int firstAnimatedDice = 0;
            int secondAnimatedDice = 0;
            int minFaceValue = 1;
            int maxFaceValue = 6;

            if (counter < animationDuration) {
                firstAnimatedDice = firstDiceAnimation.Next(minFaceValue, maxFaceValue + 1);
                secondAnimatedDice = secondDiceAnimation.Next(minFaceValue, maxFaceValue + 1);
                diceImages[firstDice].Image = Images.GetDieImage(firstAnimatedDice);
                diceImages[secondDice].Image = Images.GetDieImage(secondAnimatedDice);
            } else {
                animationTimer.Stop();
                bool playGame = Pig_Double_Dice_Game.PlayGame();
                bool hasWon = Pig_Double_Dice_Game.HasWon();

                rollOrHoldLabel.Text = "roll or hold";
                playerOneText.Text = Pig_Double_Dice_Game.GetPointsTotal("Player 1").ToString();
                playerTwoText.Text = Pig_Double_Dice_Game.GetPointsTotal("Player 2").ToString();
                holdButton.Enabled = true;
                DiceImage();

                if (playGame) {
                    string completedTurn = "Sorry you have thrown a 1\nYour turn is over" +
                        "\nYour score is reverted to "
                        + Pig_Double_Dice_Game.GetPointsTotal(currentPlayer);
                    MessageBox.Show(completedTurn, "Turn Completed", MessageBoxButtons.OKCancel);
                    currentPlayer = Pig_Double_Dice_Game.GetNextPlayerName();
                    turnLabel.Text = currentPlayer;
                }

                if (hasWon) {
                    string winningPlayer = currentPlayer + " has won";
                    MessageBox.Show(winningPlayer, "Game Over", MessageBoxButtons.OKCancel);
                    anotherGameGroup.Enabled = true;
                }
                rollButton.Enabled = true;
            }
        }

        private void holdButton_Click(object sender, EventArgs e) {
            currentPlayer = Pig_Double_Dice_Game.GetNextPlayerName();
            turnLabel.Text = currentPlayer;
        }

        private void playAgain_CheckedChanged(object sender, EventArgs e) {
            if (yesButton.Checked == true) {
                ResetForm();
                yesButton.Checked = false;
            } else if (noButton.Checked == true) {
                this.Close();
            }

        }
    }
}
