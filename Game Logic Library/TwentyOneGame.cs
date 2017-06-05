using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {

    /// <summary>
    /// This class holds the game logic for the TwentyOneGame
    /// 
    /// Author Quintus Cardozo
    /// Student Number: n9703578
    /// </summary>
    public static class TwentyOneGame {
        private static CardPile cardPile;
        private static Hand[] hands;
        private static int[] totalPoints;
        //numOfGameWon is initlaised here so that the it is not reset when the form is hidden and shown
        //multiply times
        private static int[] numOfGamesWon = new int[] { 0, 0 };
        private static int numOfUserAcesWithValueOne;
        private static int addOneAce = 1;
        private static int acesInPlayersHand;
        private const int NUM_OF_PLAYERS = 2;
        private static int initialCards = 2;
        private static int dealer = 0;
        private static int player = 1;

        /// <summary>
        /// Initializes the class variables at the start of a new game
        /// </summary>
        public static void SetUpGame() {
            hands = new Hand[NUM_OF_PLAYERS];
            cardPile = new CardPile(true);
            cardPile.Shuffle();
            hands[dealer] = new Hand(cardPile.DealCards(initialCards));
            hands[player] = new Hand(cardPile.DealCards(initialCards));
            ResetTotals();
        }

        /// <summary>
        /// Deals one card from cardpile to the specified hand
        /// </summary>
        /// <param name="who">specified hand</param>
        /// <returns>card</returns>
        public static Card DealOneCardTo(int who) {
            Card temp = cardPile.DealOneCard();
            hands[who].Add(temp);
            return temp;
        }

        /// <summary>
        /// Adds the faceValues of all cards in the specified hand
        /// </summary>
        /// <param name="who">specified hand</param>
        /// <returns>sum of all facevalues in hand</returns>
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

        /// <summary>
        /// Plays the Dealer’s turn until the Dealer stands or goes bust
        /// </summary>
        public static void PlayForDealer() {
            DealOneCardTo(dealer);
        }

        /// <summary>
        /// Gets the specified hand
        /// </summary>
        /// <param name="who">specified hand</param>
        /// <returns>specified hand</returns>
        public static Hand GetHand(int who) {
            return hands[who];
        }

        /// <summary>
        /// Get the total points of specified player
        /// </summary>
        /// <param name="who">specofied player</param>
        /// <returns>totla points of specified player</returns>
        public static int GetTotalPoints(int who) {
            return totalPoints[who];
        }

        /// <summary>
        /// Get number of games won by the specified player
        /// </summary>
        /// <param name="who">specified player</param>
        /// <returns>games won by specified player</returns>
        public static int GetNumOfGamesWon(int who) {
            return numOfGamesWon[who];
        }

        /// <summary>
        /// Get the number of aces the user has chosen to hae a value of one
        /// </summary>
        /// <returns>number of aces with value of one</returns>
        public static int GetNumOfUserAcesWithValueOne() {
            return numOfUserAcesWithValueOne;
        }

        /// <summary>
        ///  Adds one to the numOfUserAcesWithValueOne
        /// </summary>
        public static void IncrementNumOfUserAcesWithVAlueOne() {
            acesInPlayersHand = 0;
            numOfUserAcesWithValueOne = numOfUserAcesWithValueOne + addOneAce;
            acesInPlayersHand = addOneAce;
        }

        /// <summary>
        /// Initialise the elements of the array, totalPoints to zero as well as any other
        /// class variable that needs to be reset
        /// </summary>
        public static void ResetTotals() {
            totalPoints = new int[] { 0, 0 };
            numOfUserAcesWithValueOne = 0;
        }
    }
}
 
