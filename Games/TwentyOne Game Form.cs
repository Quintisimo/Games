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
        TableLayoutPanel[] tableLayoutPanel;
        Label[] bustedLabels;
        Label[] pointsLabels;
        TextBox[] gamesWonTexts;
        int dealer = 0;
        int dealerPoints = 0;
        int player = 1;
        int playerPoints = 0;
        int addOnePoint = 1;

        const int NUM_OF_PLAYERS = 2;
        const int WINNING_POINTS = 21;

        public twentyOneGameForm() {
            InitializeComponent();
            int initialValue = 0;

            tableLayoutPanel = new TableLayoutPanel[NUM_OF_PLAYERS] { dealerTable, playerTable };
            bustedLabels = new Label[NUM_OF_PLAYERS] { dealerBustedLabel, playerBustedLabel };
            pointsLabels = new Label[NUM_OF_PLAYERS] { dealerPointsLabel, playerPointsLabel };
            gamesWonTexts = new TextBox[NUM_OF_PLAYERS] { dealerGamesWonText, playerGamesWonText };
            testButton.Visible = false;
            hitButton.Enabled = false;
            standButton.Enabled = false;

            acesValuedOneText.Text = initialValue.ToString();
            bustedLabels[dealer].Visible = false;
            pointsLabels[dealer].Visible = false;
            gamesWonTexts[dealer].Text = initialValue.ToString();

            bustedLabels[player].Visible = false;
            pointsLabels[player].Visible = false;
            gamesWonTexts[player].Text = initialValue.ToString();

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

            Hand dealerHand = TwentyOneGame.GetHand(dealer);
            DisplayGuiHand(dealerHand, dealerTable);
            pointsLabels[dealer].Visible = true;
            TwentyOneGame.CalculateHandTotal(dealer);
            dealerPoints = TwentyOneGame.GetTotalPoints(dealer);
            pointsLabels[dealer].Text = dealerPoints.ToString();

            if (dealerPoints > WINNING_POINTS) {
                dealerBustedLabel.Visible = true;
                playerPoints = TwentyOneGame.GetNumOfGamesWon(player);
                playerPoints += addOnePoint;
                playerGamesWonText.Text = playerPoints.ToString();
                MessageBox.Show("You won! Well Done", "Game Over");
            }

            Hand playerHand = TwentyOneGame.GetHand(player);
            DisplayGuiHand(playerHand, playerTable);
            pointsLabels[player].Visible = true;
            TwentyOneGame.CalculateHandTotal(player);
            playerPoints = TwentyOneGame.GetTotalPoints(player);
            pointsLabels[player].Text = playerPoints.ToString();

            if (playerPoints > WINNING_POINTS) {
                playerBustedLabel.Visible = true;
                dealerPoints = TwentyOneGame.GetNumOfGamesWon(dealer);
                dealerPoints += addOnePoint;
                dealerGamesWonText.Text = dealerPoints.ToString();
                MessageBox.Show("House won! Better luck next time", "Game Over");
            }

            if (playerPoints == dealerPoints) {
                MessageBox.Show("It was a draw", "Game Over");
            }
        }

        private void standButton_Click(object sender, EventArgs e) {
            int standPoints = 17;
            dealerPoints = TwentyOneGame.GetTotalPoints(dealer);

            while (dealerPoints < standPoints) {
                TwentyOneGame.PlayForDealer();
                dealerPoints = TwentyOneGame.CalculateHandTotal(dealer);
                pointsLabels[dealer].Text = TwentyOneGame.GetTotalPoints(dealer).ToString();
                Hand dealerHand = TwentyOneGame.GetHand(dealer);
                DisplayGuiHand(dealerHand, dealerTable);
            }

            if (dealerPoints > WINNING_POINTS) {
                dealerBustedLabel.Visible = true;
            }
        }
    }
}