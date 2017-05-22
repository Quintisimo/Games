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
        private int dealer = 0;
        private int player = 1;

        public void SetUpGame() {
            hands = new Hand[2];
            cardPile = new CardPile(true);
            hands[dealer] = new Hand(cardPile.DealCards(2));
            hands[player] = new Hand(cardPile.DealCards(2));
            totalPoints = new int[] { 0, 0 };
            numOfGamesWon = new int[] { 0, 0 };
            numOfUserAcesWithValueOne = 0;
        }
        
        public Card DealOneCardTo(int who) {
            Card temp = cardPile.DealOneCard();
            hands[who].Add(temp);
            return temp;
        }

        public int CalculateHandTotal(int who) {
            int result = 0;
            FaceValue temp;
            foreach (Card card in hands[who]) {
                temp = card.GetFaceValue();
                int faceCard = 10;
                int numberCard = 2;

                if (temp == FaceValue.Ten || temp == FaceValue.Jack || 
                    temp == FaceValue.Queen || temp == FaceValue.King) {
                    result += faceCard;

                } else if(temp == FaceValue.Ace) {

                    if (who == player && GetNumOfUserAcesWithValueOne() > 0) {
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

        public void PlayForDealer() {
            int minimumPoints = 17;

            while (totalPoints[dealer] < minimumPoints) {
                DealOneCardTo(dealer);
            }
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
            return numOfUserAcesWithValueOne;
        }

        public void IncrementNumOfUserAcesWithVAlueOne() {
            numOfUserAcesWithValueOne = numOfUserAcesWithValueOne + 1;
        } 
    }
}
