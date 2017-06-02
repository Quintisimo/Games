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
        private static int addOne = 1;

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

        public static Hand GetHand(int which) {
            return tableauPiles[which];
        }
    }
}
