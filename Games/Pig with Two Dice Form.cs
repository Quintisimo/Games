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
        private string currentPlayer;
        private int firstDice = 0;
        private int secondDice = 1;

        public pigWithTwoDiceForm() {
            InitializeComponent();
            ResetForm();
        }

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

        private void DiceImage() {
            firstDiceImage.Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(firstDice));
            secondDiceImage.Image = Images.GetDieImage(Pig_Double_Dice_Game.GetFaceValue(secondDice));
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
