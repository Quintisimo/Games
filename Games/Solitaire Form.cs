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

    /// <summary>
    /// Form that is used to play Solitare Game
    /// 
    /// Author Quintus Cardozo
    /// Student Number: n9703578
    /// </summary>
    public partial class solitaireForm : Form {
        TableLayoutPanel[] tableLayoutPanels;
        PictureBox[] suitPiles;
        Card card;
        Card previousClickedCard;
        int[] tableFaceUpCards;
        int discardPileCardValue;
        Suit discardPileCardSuit;
        Colour discardPileCardColour;
        List<Card>[] faceCardsListArray;

        public solitaireForm() {
            InitializeComponent();
            tableLayoutPanels = new TableLayoutPanel[] { tableLayoutPanel1, tableLayoutPanel2,
                tableLayoutPanel3, tableLayoutPanel4, tableLayoutPanel5, tableLayoutPanel6,
                tableLayoutPanel7 };
            suitPiles = new PictureBox[] { suitPileImage1, suitPileImage2, suitPileImage3, suitPileImage4 };
            tableFaceUpCards = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            faceCardsListArray = new List<Card>[] { new List<Card>(), new List<Card>(), new List<Card>(),
                new List<Card>(), new List<Card>(), new List<Card>(), new List<Card>() };
            Solitare_Game.SetUpGame();

            for (int i = 0; i < tableLayoutPanels.Length; i++) {
                Hand hand = Solitare_Game.GetTableauPile(i);
                int numOfCards = hand.GetCount();
                DisplayGuiHand(hand, tableLayoutPanels[i], numOfCards);
            }
            drawPileImage.Image = Images.GetBackOfCardImage();
            discardPileImage.Image = Images.GetCardImage(Solitare_Game.DrawOneCard());
        }

        /// <summary>
        /// Dsiplays cards in the specified hand in the specified table in the form
        /// </summary>
        /// <param name="hand">specified hand</param>
        /// <param name="tableLayoutPanel">specified table</param>
        /// <param name="lastCard">card that needs to be faceup</param>
        private void DisplayGuiHand(Hand hand, TableLayoutPanel tableLayoutPanel, int lastCard) {
            tableLayoutPanel.Controls.Clear(); // Remove any cards already being shown.
            int cardNumber = 0;

            foreach (Card card in hand) {
                cardNumber++;
                // Construct a PictureBox object.
                PictureBox pictureBox = new PictureBox();
                // Set the PictureBox to use all of its space
                pictureBox.Dock = DockStyle.Fill;
                // Remove spacing around the PictureBox. (Default is 3 pixels.)
                pictureBox.Margin = new Padding(0);

                if (cardNumber >= lastCard) {
                    pictureBox.Image = Images.GetCardImage(card);
                    // set event-handler for Click on this PictureBox.
                    pictureBox.Click += new EventHandler(pictureBox_Click);
                    pictureBox.DoubleClick += new EventHandler(pictureBox_DoubleClick);
                    // tell the PictureBox which Card object it has the picture of.
                    pictureBox.Tag = card;
                } else {
                    pictureBox.Image = Images.GetBackOfCardImage();
                    pictureBox.Tag = card;
                }
                // Add the PictureBox object to the tableLayoutPanel.
                tableLayoutPanel.Controls.Add(pictureBox);
            }
        }// End DisplayGuiHand

        private void pictureBox_Click(object sender, EventArgs e) {
            // which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            // get a reference to the card
            Card clickedCard = (Card)clickedPictureBox.Tag;
            TryToPlayCard(clickedCard);
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e) {
            // which card was clicked?
            PictureBox clickedPictureBox = (PictureBox)sender;
            // get a reference to the card
            Card clickedCard = (Card)clickedPictureBox.Tag;
            MoveToAcePile(clickedCard);
        }

        private void TryToPlayCard(Card clickedCard) {
            // This MessageBox.Show is for debugging purposes only.
            // comment out line, once sure you can click on a card in a tableau
            //MessageBox.Show(clickedCard.ToString(false, true), "Clicked");
            // Add code to do something with the clicked card.
            bool hasWon = Solitare_Game.HasWon();
            FaceValue clickedCardValue = clickedCard.GetFaceValue();
            int clickedValue = (int)clickedCardValue;
            Suit clickedCardSuit = clickedCard.GetSuit();
            Colour clickedCardColour;
            int oneCard = 1;
            int noCards = 0;


            if (clickedCardSuit == Suit.Hearts || clickedCardSuit == Suit.Diamonds) {
                clickedCardColour = Colour.Red;
            } else {
                clickedCardColour = Colour.Black;
            }

            if (card != null) {

                if (discardPileCardSuit == Suit.Hearts || discardPileCardSuit == Suit.Diamonds) {
                    discardPileCardColour = Colour.Red;
                } else {
                    discardPileCardColour = Colour.Black;
                }

                if (clickedCardValue == FaceValue.Ace) {
                    Solitare_Game.AddAceToSuitPile(clickedCard);
                }

                if (clickedValue == discardPileCardValue + oneCard &&
                    discardPileCardColour != clickedCardColour) {
                    Solitare_Game.AddToTableauPile(clickedCard, card);

                    for (int i = 0; i < tableLayoutPanels.Length; i++) {
                        Hand hand = Solitare_Game.GetTableauPile(i);

                        if (hand.Contains(card)) {
                            tableFaceUpCards[i] += oneCard;
                            int numOfCards = hand.GetCount() - tableFaceUpCards[i];
                            DisplayGuiHand(hand, tableLayoutPanels[i], numOfCards);
                        }
                    }
                    card = Solitare_Game.DiscardPileCard();
                    if (card == null) {
                        discardPileImage.Image = null;
                    } else {
                        discardPileImage.Image = Images.GetCardImage(card);
                    }
                    card = null;

                } else {
                    MessageBox.Show("Move not allowed - Cannot place card onto this card", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                if (previousClickedCard != null) {
                    int prevoiusClickedCardValue = (int)previousClickedCard.GetFaceValue();
                    Suit previousClickedCardSuit = previousClickedCard.GetSuit();
                    Colour prevoiusClickedCardColour;

                    if (previousClickedCardSuit == Suit.Hearts || previousClickedCardSuit == Suit.Diamonds) {
                        prevoiusClickedCardColour = Colour.Red;
                    } else {
                        prevoiusClickedCardColour = Colour.Black;
                    }

                    if (clickedValue == prevoiusClickedCardValue + oneCard &&
                        prevoiusClickedCardColour != clickedCardColour) {
                        int position = Solitare_Game.MoveTableauCard(previousClickedCard, clickedCard);
                        faceCardsListArray[position].Add(clickedCard);
                        faceCardsListArray[position].Add(previousClickedCard);

                        for (int i = 0; i < tableFaceUpCards.Length; i++) {
                            Hand hand = Solitare_Game.GetTableauPile(i);

                            if (tableFaceUpCards[i] > 0 && faceCardsListArray[i].Count() > noCards) {

                                foreach (var card in faceCardsListArray[i]) {
                                    Solitare_Game.MoveTableauCard(card, clickedCard);
                                }
                                tableFaceUpCards[i] = noCards;
                            }
                        }

                        for (int i = 0; i < faceCardsListArray.Length; i++) {
                            foreach (var card in faceCardsListArray[i]) {
                                for (int j = 0; j < tableLayoutPanels.Length; j++) {
                                    Hand hand = Solitare_Game.GetTableauPile(j);

                                    if (hand.Contains(card)) {
                                        tableFaceUpCards[j] += oneCard;
                                        break;
                                    }
                                }
                                break;
                            }
                        }

                        for (int i = 0; i < tableLayoutPanels.Length; i++) {
                            Hand hand = Solitare_Game.GetTableauPile(i);
                            int numOfCards = hand.GetCount() - tableFaceUpCards[i];
                            DisplayGuiHand(hand, tableLayoutPanels[i], numOfCards);
                        }
                    }
                }
                previousClickedCard = clickedCard;
                if (hasWon) {
                    MessageBox.Show("Congrates! You have won", "Winner", MessageBoxButtons.OK);
                }
            }
        }

        /// <summary>
        /// Moves card from tableau pile to ace pile
        /// </summary>
        /// <param name="clickedCard">card to be moved</param>
        private void MoveToAcePile(Card clickedCard) {
            bool addCard = Solitare_Game.AddCardToSuitPile(clickedCard);

            for (int i = 0; i < suitPiles.Length; i++) {
                card = Solitare_Game.SuitPileCard(i);

                if (card != null) {
                    suitPiles[i].Image = Images.GetCardImage(card);
                }
            }

            for (int i = 0; i < tableLayoutPanels.Length; i++) {
                Hand hand = Solitare_Game.GetTableauPile(i);

                if (hand.Contains(clickedCard)) {
                    hand.Remove(clickedCard);
                }

                int numOfCards = hand.GetCount() - tableFaceUpCards[i];
                DisplayGuiHand(hand, tableLayoutPanels[i], numOfCards);
            }

            if (!addCard) {
                MessageBox.Show("Cannot move card to suit pile", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void drawPileImage_Click(object sender, EventArgs e) {
            int numOfCards = Solitare_Game.NumOfDrawCards();
            int noCards = 0;

            if (drawPileImage.Image == null) {
                Solitare_Game.RefillDrawPile();
                drawPileImage.Image = Images.GetBackOfCardImage();
                discardPileImage.Image = Images.GetCardImage(Solitare_Game.DrawOneCard());
            } else if (numOfCards > noCards) {
                discardPileImage.Image = Images.GetCardImage(Solitare_Game.DrawOneCard());
            } else {
                drawPileImage.Image = null;
            }
        }

        private void discardPileImage_Click(object sender, EventArgs e) {
            bool hasWon = Solitare_Game.HasWon();

            if (card != null && card == previousClickedCard) {
                MessageBox.Show("Cannot place card onto discard pile", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                previousClickedCard = null;
            } else {
                card = Solitare_Game.DiscardPileCard();
                FaceValue cardValue = card.GetFaceValue();
                discardPileCardValue = (int)card.GetFaceValue();
                discardPileCardSuit = card.GetSuit();

                if (cardValue == FaceValue.Ace) {
                    Solitare_Game.AddAceToSuitPile(card);

                    foreach (PictureBox picture in suitPiles) {

                        if (picture.Image == null) {
                            picture.Image = Images.GetCardImage(card);
                            break;
                        }
                    }
                } else {
                    bool addCard = Solitare_Game.AddCardToSuitPile(card);

                    for (int i = 0; i < suitPiles.Length; i++) {
                        card = Solitare_Game.SuitPileCard(i);

                        if (card != null) {
                            suitPiles[i].Image = Images.GetCardImage(card);
                        }
                    }

                    if (!addCard) {
                        MessageBox.Show("Cannot move card to suit pile", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                card = Solitare_Game.DiscardPileCard();

                if (card != null) {
                    discardPileImage.Image = Images.GetCardImage(card);
                }
                previousClickedCard = card;
                card = null;
            }

            if (hasWon) {
                MessageBox.Show("Congrates! You have won", "Winner", MessageBoxButtons.OK);
            }
        }
    }
}
