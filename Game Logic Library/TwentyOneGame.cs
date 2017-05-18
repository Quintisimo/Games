using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {
    class TwentyOneGame {
        private CardPile cardPile;
        private Hand[] hands;
        private int[] totalPoints;
        private int[] numOfGamesWon;
        private int numOfUserAcesWithValueOne;

        public void SetUpGame() { 
            hands = new Hand[2];
            totalPoints = new int[] { 0, 0 };
            numOfGamesWon = new int[] { 0, 0 };
        }

        public Card DealOneCardTo(int who) {
            hands[who] = cardPile.DealOneCard();
            return hands[who];
        }

        public int CalculateHandTotal(int who) {
            foreach (Card card in hands[who]) {
               
            }
        }

        public void PlayForDealer() {

        }

        public Hand GetHand(int who) {
            return hands[who];
        }

        public int GetTotalPoints(int who) {
            return totalPoints[who];
        }

        public int GetNumOfGamesWon(int who) {
            return numOfGamesWon[who];
        }

        public int GetNumOfUserAcesWithValueOne() {

        }

        public void IncrementNumOfUserAcesWithVAlueOne() {
            numOfUserAcesWithValueOne = numOfUserAcesWithValueOne + 1;
        } 
    }
}
