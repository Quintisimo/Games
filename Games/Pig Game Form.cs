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
    public partial class pigGameForm : Form {
        private string currentPlayer;

        public pigGameForm() {
            InitializeComponent();
            ResetForm();
        }

        /// <summary>
        /// Resets the form so user can play another game
        /// </summary>
        private void ResetForm() {
            anotherGameGroup.Enabled = false;
            holdButton.Enabled = false;
            Pig_Single_Die_Game.SetUpGame();
            DiceImage();
            currentPlayer = Pig_Single_Die_Game.GetFirstPlayerName();
            turnLabel.Text = currentPlayer;
            rollOrHoldLabel.Text = "roll Die";
            playerOneText.Clear();
            playerTwoText.Clear();
        }

        /// <summary>
        /// Displayes the die image in the form
        /// </summary>
        private void DiceImage() {
            diceImage.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
        }

        private void rollButton_Click(object sender, EventArgs e) {
            bool playGame = Pig_Single_Die_Game.PlayGame();
            bool hasWon = Pig_Single_Die_Game.HasWon();

            rollOrHoldLabel.Text = "roll or hold";
            playerOneText.Text = Pig_Single_Die_Game.GetPointsTotal("Player 1").ToString();
            playerTwoText.Text = Pig_Single_Die_Game.GetPointsTotal("Player 2").ToString();
            holdButton.Enabled = true;
            DiceImage();

            if (playGame) {
                string completedTurn = "Sorry you have thrown a 1\nYour turn is over" +
                    "\nYour score is reverted to " 
                    + Pig_Single_Die_Game.GetPointsTotal(currentPlayer);
                MessageBox.Show(completedTurn, "Turn Completed", MessageBoxButtons.OKCancel);
                currentPlayer = Pig_Single_Die_Game.GetNextPlayerName();
                turnLabel.Text = currentPlayer;
            }

            if (hasWon) {
                string winningPlayer = currentPlayer + " has won";
                MessageBox.Show(winningPlayer, "Game Over", MessageBoxButtons.OKCancel);
                anotherGameGroup.Enabled = true;
            }
        }

        private void holdButton_Click(object sender, EventArgs e) {
            currentPlayer = Pig_Single_Die_Game.GetNextPlayerName();
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
