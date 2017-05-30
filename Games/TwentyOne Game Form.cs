using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Low_Level_Objects_Library;
using Game_Logic_Library;

namespace Games { 
    public partial class twentyOneGameForm : Form {
        const int WINNING_POINTS = 21;

        TableLayoutPanel[] tableLayoutPanel;
        Label[] bustedLabels;
        Label[] pointsLabels;
        TextBox[] gamesWonTexts;
        int dealer = 0;
        int dealerPoints;
        int dealerGamesWon;

        int player = 1;
        int playerPoints;
        int playerGamesWon;

        DialogResult result;
        int addOnePoint = 1;

        public twentyOneGameForm() {
            InitializeComponent();

            int initialValue = 0;

            tableLayoutPanel = new TableLayoutPanel[] { dealerTable, playerTable };
            bustedLabels = new Label[] { dealerBustedLabel, playerBustedLabel };
            pointsLabels = new Label[] { dealerPointsLabel, playerPointsLabel };
            gamesWonTexts = new TextBox[] { dealerGamesWonText, playerGamesWonText };
            gamesWonTexts[dealer].Text = initialValue.ToString();
            gamesWonTexts[player].Text = initialValue.ToString();
            dealerGamesWon = TwentyOneGame.GetNumOfGamesWon(dealer);
            playerGamesWon = TwentyOneGame.GetNumOfGamesWon(player);

            ResetForm();
        }

        private void ResetForm() {
            testButton.Visible = false;
            hitButton.Enabled = false;
            standButton.Enabled = false;
            playerTable.Controls.Clear();
            dealerTable.Controls.Clear();

            TwentyOneGame.ResetTotals();
            acesValuedOneText.Text = TwentyOneGame.GetNumOfUserAcesWithValueOne().ToString();
            bustedLabels[dealer].Visible = false;
            pointsLabels[dealer].Visible = false;
            bustedLabels[player].Visible = false;
            pointsLabels[player].Visible = false;
        }

        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            foreach (Card card in hand) {
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);
                pictureBox.Image = Images.GetCardImage(card);
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private bool ScoreMessage() {
            dealerPoints = TwentyOneGame.GetTotalPoints(dealer);
            playerPoints = TwentyOneGame.GetTotalPoints(player);

            if (dealerPoints > WINNING_POINTS) {
                dealerBustedLabel.Visible = true;
                playerGamesWon += addOnePoint;
                gamesWonTexts[player].Text = playerGamesWon.ToString();
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
                result = MessageBox.Show("You won! Well Done", "Game Over");
                return true;
            }

            if (playerPoints > WINNING_POINTS) {
                playerBustedLabel.Visible = true;
                dealerGamesWon += addOnePoint;
                gamesWonTexts[dealer].Text = dealerGamesWon.ToString();
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
                result = MessageBox.Show("House won! Better luck next time", "Game Over");
                return true;
            }

            if (playerPoints == dealerPoints) {
                hitButton.Enabled = false;
                standButton.Enabled = false;
                dealButton.Enabled = true;
                result = MessageBox.Show("It was a draw", "Game Over");
                return true;
            }
            return false;
        }

        private void DetermineWinner(string close = "no") {
            bool score = ScoreMessage();

            if (score == false) {
                if (playerPoints > dealerPoints) {

                    if (close == "no") {
                        playerGamesWon += addOnePoint;
                        gamesWonTexts[player].Text = playerGamesWon.ToString();
                    }
                    hitButton.Enabled = false;
                    standButton.Enabled = false;
                    dealButton.Enabled = true;
                    result = MessageBox.Show("You won! Well Done", "Game Over");
                } else {

                    if (close == "no") {
                        dealerGamesWon += addOnePoint;
                        gamesWonTexts[dealer].Text = dealerGamesWon.ToString();
                    }
                    hitButton.Enabled = false;
                    standButton.Enabled = false;
                    dealButton.Enabled = true;
                    result = MessageBox.Show("House won! Better luck next time", "Game Over");
                }
            }
        }

        private void PlayerAceValue(Hand hand) {
            FaceValue cardValue;
            foreach (Card card in hand) {
                cardValue = card.GetFaceValue();

                if (cardValue == FaceValue.Ace) {
                    result = MessageBox.Show("Count Ace as One?", "You got an ace!", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes) {
                        TwentyOneGame.IncrementNumOfUserAcesWithVAlueOne();
                        acesValuedOneText.Text = TwentyOneGame.GetNumOfUserAcesWithValueOne().ToString();
                    }
                }
            }
        }

        private void testButton_Click(object sender, EventArgs e) {
            const int testNumOfCardsForDealer = 2;
            const int testNumOfCardsForPlayer = 8;
            CardPile testCardPile = new CardPile(true);
            testCardPile.Shuffle();
            Hand testHandForDealer = new Hand(testCardPile.DealCards(testNumOfCardsForDealer));
            Hand testHandForPlayer = new Hand(testCardPile.DealCards(testNumOfCardsForPlayer));
            DisplayGuiHand(testHandForDealer, dealerTable);
            DisplayGuiHand(testHandForPlayer, playerTable);
        }

        private void dealButton_Click(object sender, EventArgs e) {
            TwentyOneGame.SetUpGame();

            hitButton.Enabled = true;
            standButton.Enabled = true;
            dealButton.Enabled = false;
            bustedLabels[dealer].Visible = false;
            bustedLabels[player].Visible = false;

            Hand dealerHand = TwentyOneGame.GetHand(dealer);
            DisplayGuiHand(dealerHand, dealerTable);
            pointsLabels[dealer].Visible = true;
            TwentyOneGame.CalculateHandTotal(dealer);
            pointsLabels[dealer].Text = TwentyOneGame.GetTotalPoints(dealer).ToString();


            Hand playerHand = TwentyOneGame.GetHand(player);
            PlayerAceValue(playerHand);
            DisplayGuiHand(playerHand, playerTable);
            pointsLabels[player].Visible = true;
            TwentyOneGame.CalculateHandTotal(player);
            pointsLabels[player].Text = TwentyOneGame.GetTotalPoints(player).ToString();

            ScoreMessage();
        }

        private void hitButton_Click(object sender, EventArgs e) {
            TwentyOneGame.DealOneCardTo(player);
            TwentyOneGame.CalculateHandTotal(player);
            pointsLabels[player].Text = TwentyOneGame.GetTotalPoints(player).ToString();
            Hand playerHand = TwentyOneGame.GetHand(player);
            PlayerAceValue(playerHand);
            DisplayGuiHand(playerHand, playerTable);

            ScoreMessage();
        }

        private void standButton_Click(object sender, EventArgs e) {
            int standPoints = 17;
            dealerPoints = TwentyOneGame.GetTotalPoints(dealer);
            hitButton.Enabled = false;

            while (dealerPoints < standPoints) {
                TwentyOneGame.PlayForDealer();
                TwentyOneGame.CalculateHandTotal(dealer);
                dealerPoints = TwentyOneGame.GetTotalPoints(dealer);
                pointsLabels[dealer].Text = dealerPoints.ToString();
                Hand dealerHand = TwentyOneGame.GetHand(dealer);
                DisplayGuiHand(dealerHand, dealerTable);
            }

            DetermineWinner();
        }

        private void cancelGameButton_Click(object sender, EventArgs e) {
            DetermineWinner("yes");
            TwentyOneGame.ResetTotals();
            ResetForm();

            if (result == DialogResult.OK) {
                this.Hide();
            }
        }
    }
}