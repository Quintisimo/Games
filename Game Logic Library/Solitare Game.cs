using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {
    public static class Solitare_Game {
        private static CardPile drawPile;
        private static CardPile discardPile;
        private static Hand[] tableauPiles;
        private const int NUM_OF_HANDS = 7;
        private static CardPile[] suitPiles;
        private const int NUM_OF_SUITS = 4;
        private const int addOne = 1;
        private const int noCards = 0;

        public static void SetUpGame() {
            drawPile = new CardPile(true);
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

        public static Hand GetTableauPile(int which) {
            return tableauPiles[which];
        }

        public static int NumOfDrawCards() {
            return drawPile.GetCount();
        }

        public static Card DrawOneCard() {
            Card card = drawPile.DealOneCard();
            discardPile.Add(card);
            return card;
        }

        public static Card DiscardPileCard() {
            Card card = null;

            if (discardPile.GetCount() > noCards) {
                card = discardPile.GetLastCardInPile();
                discardPile.RemoveLastCard();
            }
            return card;
        }

        public static CardPile RefillDrawPile() {
            int numOfCards = discardPile.GetCount();

            while (numOfCards > noCards) {
                drawPile.Add(discardPile.DealOneCard());
                numOfCards = discardPile.GetCount();
            }
            return drawPile;
        }

        public static void AddToSuitPile(Card card) {
            for (int i = 0; i < suitPiles.Length; i++) {

                if (suitPiles[i].GetCount() == noCards) {
                    suitPiles[i].Add(card);
                    break;
                }
            }
        }

        public static void AddToTableauPile(Card tableauCard, Card discardPileCard) {
            for (int i = 0; i < tableauPiles.Length; i++) {
                if (tableauPiles[i].Contains(tableauCard)) {
                    tableauPiles[i].Add(discardPileCard);
                }
            }
        }

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
