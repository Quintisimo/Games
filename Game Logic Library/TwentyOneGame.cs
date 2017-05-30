using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {
    public static class TwentyOneGame {
        private static CardPile cardPile;
        private static Hand[] hands;
        private static int[] totalPoints;
        private static int[] numOfGamesWon = new int[] { 0, 0 };
        private static int numOfUserAcesWithValueOne;
        private static int addOneAce = 1;
        private static int acesInPlayersHand;
        private const int NUM_OF_PLAYERS = 2;
        private static int dealer = 0;
        private static int player = 1;

        public static void SetUpGame() {
            hands = new Hand[NUM_OF_PLAYERS];
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            hands[dealer] = new Hand(cardPile.DealCards(2));
            hands[player] = new Hand(cardPile.DealCards(2));
            ResetTotals();
        }

        public static Card DealOneCardTo(int who) {
            Card temp = cardPile.DealOneCard();
            hands[who].Add(temp);
            return temp;
        }

        public static int CalculateHandTotal(int who) {
            int result = 0;
            FaceValue temp;
            foreach (Card card in hands[who]) {
                temp = card.GetFaceValue();
                int faceCard = 10;
                int numberCard = 2;

                if (temp == FaceValue.Ten || temp == FaceValue.Jack ||
                    temp == FaceValue.Queen || temp == FaceValue.King) {
                    result += faceCard;

                } else if (temp == FaceValue.Ace) {

                    if (who == player && acesInPlayersHand > 0) {
                        result += 1;
                    } else {
                        result += 11;
                    }

                } else {
                    result += numberCard + (int)card.GetFaceValue();
                }
            }
            totalPoints[who] = result;
            return result;
        }

        public static void PlayForDealer() {
            DealOneCardTo(dealer);
        }

        public static Hand GetHand(int who) {
            return hands[who];
        }

        public static int GetTotalPoints(int who) {
            return totalPoints[who];
        }

        public static int GetNumOfGamesWon(int who) {
            return numOfGamesWon[who];
        }

        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }

        public static void IncrementNumOfUserAcesWithVAlueOne() {
            acesInPlayersHand = 0;
            numOfUserAcesWithValueOne = numOfUserAcesWithValueOne + addOneAce;
            acesInPlayersHand = addOneAce;
        }

        public static void ResetTotals() {
            totalPoints = new int[] { 0, 0 };
            numOfUserAcesWithValueOne = 0;
        }
    }
}
 
