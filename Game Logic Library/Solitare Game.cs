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
        private const int addOne = 1;
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
                tableauPiles[i] = new Hand(drawPile.DealCards(i + addOne));
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
        /// Addes specified card to an empty suitpile
        /// </summary>
        /// <param name="card">specified card</param>
        public static void AddToSuitPile(Card card) {
            for (int i = 0; i < suitPiles.Length; i++) {

                if (suitPiles[i].GetCount() == noCards) {
                    suitPiles[i].Add(card);
                    break;
                }
            }
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
        /// Moves cards between tableau pile
        /// </summary>
        /// <param name="addCard">card to be moved</param>
        /// <param name="otherCard">where to be moved</param>
        public static void MoveTableauCard(Card addCard, Card otherCard) {
            for (int i = 0; i < tableauPiles.Length; i++) {
                if (tableauPiles[i].Contains(addCard)) {
                    tableauPiles[i].Remove(addCard);
                }

                if (tableauPiles[i].Contains(otherCard)) {
                    tableauPiles[i].Add(addCard);
                }
            }
        }
    }
}
