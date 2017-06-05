using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {

    /// <summary>
    /// This class holds the game logic for the Solitare Game
    /// 
    /// Author Quintus Cardozo
    /// Student Number: n9703578
    /// </summary>
    public static class Solitare_Game {
        private static CardPile drawPile;
        private static CardPile discardPile;
        private static Hand[] tableauPiles;
        private const int NUM_OF_HANDS = 7;
        private static CardPile[] suitPiles;
        private const int NUM_OF_SUITS = 4;
        private const int one = 1;
        private const int noCards = 0;

        /// <summary>
        /// Initializes the class variables at the start of a game
        /// </summary>
        public static void SetUpGame() {
            drawPile = new CardPile(true);
            drawPile.Shuffle();
            discardPile = new CardPile();
            tableauPiles = new Hand[NUM_OF_HANDS];

            for (int i = 0; i < tableauPiles.Length; i++ ) {
                tableauPiles[i] = new Hand(drawPile.DealCards(i + one));
            }
            suitPiles = new CardPile[NUM_OF_SUITS];

            for (int i = 0; i < suitPiles.Length; i++) {
                suitPiles[i] = new CardPile();
            }
        }

        /// <summary>
        /// Get the specified hand from the array of hands
        /// </summary>
        /// <param name="which">specified hand position</param>
        /// <returns>specified hand</returns>
        public static Hand GetTableauPile(int which) {
            return tableauPiles[which];
        }

        /// <summary>
        /// Get the number of cards in the drawpile
        /// </summary>
        /// <returns>number of cards in the draw pile</returns>
        public static int NumOfDrawCards() {
            return drawPile.GetCount();
        }

        /// <summary>
        /// Deals one card from the drawpile and adds it to the discardpile
        /// </summary>
        /// <returns>card</returns>
        public static Card DrawOneCard() {
            Card card = drawPile.DealOneCard();
            discardPile.Add(card);
            return card;
        }

        /// <summary>
        /// Gets the last card in the discardpile and removes it from the pile
        /// </summary>
        /// <returns>card</returns>
        public static Card DiscardPileCard() {
            Card card = null;

            if (discardPile.GetCount() > noCards) {
                card = discardPile.GetLastCardInPile();
                discardPile.RemoveLastCard();
            }
            return card;
        }

        /// <summary>
        /// Deals all cards from the discardpile tto the drawpile
        /// </summary>
        /// <returns></returns>
        public static CardPile RefillDrawPile() {
            int numOfCards = discardPile.GetCount();

            while (numOfCards > noCards) {
                drawPile.Add(discardPile.DealOneCard());
                numOfCards = discardPile.GetCount();
            }
            return drawPile;
        }

        /// <summary>
        /// Adds specified card to an empty suitpile
        /// </summary>
        /// <param name="card">specified card</param>
        public static void AddAceToSuitPile(Card card) {
            for (int i = 0; i < suitPiles.Length; i++) {

                if (suitPiles[i].GetCount() == noCards) {
                    suitPiles[i].Add(card);
                    break;
                }
            }
        }

        /// <summary>
        /// Adds card from tableau pile to suit pile
        /// </summary>
        /// <param name="card">card to add to suit pile</param>
        /// <returns>true if card is added to suit pile otherwise false</returns>
        public static bool AddCardToSuitPile(Card card) {
            Suit cardSuit = card.GetSuit();
            FaceValue cardValue = card.GetFaceValue();
            
            if (cardValue == FaceValue.Ace) {
                AddAceToSuitPile(card);
                return true;
            }

            for (int i = 0; i < suitPiles.Length; i++) {
                foreach(var cardpile in suitPiles) {

                    if (cardpile.GetCount() >= one) {
                        Card topCard = cardpile.GetLastCardInPile();
                        Suit topCardSuit = topCard.GetSuit();
                        FaceValue topCardValue = topCard.GetFaceValue();

                        if (topCardSuit == cardSuit) {

                            if (topCardValue == FaceValue.Ace && cardValue == FaceValue.Two) {
                                suitPiles[i].Add(card);
                                return true;

                            } else if (cardValue == topCardValue + one) {
                                suitPiles[i].Add(card);
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        public static Card SuitPileCard(int which) {
            if (suitPiles[which].GetCount() > noCards) {
                return suitPiles[which].GetLastCardInPile();
            }
            return null;
        }

        /// <summary>
        /// Moves card from discardpile to specified tableaupile
        /// </summary>
        /// <param name="tableauCard">tableaupile moved to</param>
        /// <param name="discardPileCard">card to be moved</param>
        public static void AddToTableauPile(Card tableauCard, Card discardPileCard) {
            for (int i = 0; i < tableauPiles.Length; i++) {
                if (tableauPiles[i].Contains(tableauCard)) {
                    tableauPiles[i].Add(discardPileCard);
                }
            }
        }

        /// <summary>
        /// Moves card from one tableaupile to another
        /// </summary>
        /// <param name="addCard">card to be moved</param>
        /// <param name="tableauPileCard">which tableaupile card has to be moved to</param>
        /// <returns>which tableaupile card was moved to</returns>
        public static int MoveTableauCard(Card addCard, Card tableauPileCard) {
            int position = 0;

            for (int i = 0; i < tableauPiles.Length; i++) {
                if (tableauPiles[i].Contains(addCard)) {
                    tableauPiles[i].Remove(addCard);
                }

                if (tableauPiles[i].Contains(tableauPileCard)) {
                    tableauPiles[i].Add(addCard);
                    position = i;
                }
            }
            return position;
        }

        /// <summary>
        /// Checks if player has won the game
        /// </summary>
        /// <returns>true if player has won otherwise false</returns>
        public static bool HasWon() {
            int winningCount = 13;

            foreach (CardPile cardPile in suitPiles) {
                if (cardPile.GetCount() == winningCount) {
                    return true;
                }
            }
            return false;
        }
    }
}
