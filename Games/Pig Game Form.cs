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

        private void DiceImage() {
            diceImage.Image = Images.GetDieImage(Pig_Single_Die_Game.GetFaceValue());
        }

        private void rollButton_Click(object sender, EventArgs e) {
            rollOrHoldLabel.Text = "roll or hold";
            Pig_Single_Die_Game.PlayGame();
            playerOneText.Text = Pig_Single_Die_Game.GetPointsTotal("Player 1").ToString();
            playerTwoText.Text = Pig_Single_Die_Game.GetPointsTotal("Player 2").ToString();
            holdButton.Enabled = true;
            DiceImage();

            if (Pig_Single_Die_Game.PlayGame() == true) {
                string completedTurn = "Sorry you have thrown a 1\nYour turn is over";
                MessageBox.Show(completedTurn, "Turn Completed", MessageBoxButtons.OKCancel);
                currentPlayer = Pig_Single_Die_Game.GetNextPlayerName();
                turnLabel.Text = currentPlayer;
            }

            if (Pig_Single_Die_Game.HasWon() == true) {
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
