﻿using System;
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
    public partial class solitaireForm : Form {
        TableLayoutPanel[] tableLayoutPanels;
        PictureBox[] suitPiles;
        Card card;
        int faceUpCards = 1;

        public solitaireForm() {
            InitializeComponent();
            tableLayoutPanels = new TableLayoutPanel[] { tableLayoutPanel1, tableLayoutPanel2,
                tableLayoutPanel3, tableLayoutPanel4, tableLayoutPanel5, tableLayoutPanel6,
                tableLayoutPanel7 };
            suitPiles = new PictureBox[] { suitPileImage1, suitPileImage2, suitPileImage3, suitPileImage4 };
            Solitare_Game.SetUpGame();

            for (int i = 0; i < tableLayoutPanels.Length; i++) {
                Hand hand = Solitare_Game.GetTableauPile(i);
                int numOfCards = hand.GetCount();
                DisplayGuiHand(hand, tableLayoutPanels[i], numOfCards);
            }
            drawPileImage.Image = Images.GetBackOfCardImage();
            discardPileImage.Image = Images.GetCardImage(Solitare_Game.DrawOneCard());
        }

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

        private void TryToPlayCard(Card clickedCard) {
            // This MessageBox.Show is for debugging purposes only.
            // comment out line, once sure you can click on a card in a tableau
            //MessageBox.Show(clickedCard.ToString(false, true), "Clicked");
            // Add code to do something with the clicked card.
            FaceValue clickedCardValue = clickedCard.GetFaceValue();
            int clickedValue = (int)clickedCardValue;
            Suit clickedCardSuit = clickedCard.GetSuit();
            Colour clickedCardColour;
            int discardPileCardValue = (int)card.GetFaceValue();
            Suit discardPileCardSuit = card.GetSuit();
            Colour discardPileCardColour;
            int one = 1;

            if (clickedCardSuit == Suit.Hearts || clickedCardSuit == Suit.Diamonds) {
                clickedCardColour = Colour.Red;
            } else {
                clickedCardColour = Colour.Black;
            }

            if (discardPileCardSuit == Suit.Hearts || discardPileCardSuit == Suit.Diamonds) {
                discardPileCardColour = Colour.Red;
            } else {
                discardPileCardColour = Colour.Black;
            }

            if (clickedCardValue == FaceValue.Ace) {
                Solitare_Game.AddToSuitPile(clickedCard);
            }

            if (clickedValue == discardPileCardValue + one && 
                discardPileCardColour != clickedCardColour) {
                Solitare_Game.AddToTableauPile(clickedCard, card);

                for (int i = 0; i < tableLayoutPanels.Length; i++) {
                    Hand hand = Solitare_Game.GetTableauPile(i);

                    if (hand.Contains(card)) {
                        int numOfCards = hand.GetCount() - faceUpCards;
                        DisplayGuiHand(hand, tableLayoutPanels[i], numOfCards);
                        faceUpCards += one;
                    }
                }
                card = Solitare_Game.DiscardPileCard();
                if (card == null) {
                    discardPileImage.Image = null;
                } else {
                    discardPileImage.Image = Images.GetCardImage(card);
                }
                
            } else {
                MessageBox.Show("Move not allowed - Cannot place card onto this card", "Error", 
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
                card = Solitare_Game.DiscardPileCard();
                FaceValue cardValue = card.GetFaceValue();

            if (cardValue == FaceValue.Ace) {
                Solitare_Game.AddToSuitPile(card);

                foreach (PictureBox picture in suitPiles) {

                    if (picture.Image == null) {
                        picture.Image = Images.GetCardImage(card);
                        break;
                    }
                }
                card = Solitare_Game.DiscardPileCard();
                discardPileImage.Image = Images.GetCardImage(card);
            }
        }
    }
}
