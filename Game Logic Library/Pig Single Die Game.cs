using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {

    /// <summary>
    /// This class holds the game logic for the Pig Single Die Game
    /// 
    /// Author Quintus Cardozo
    /// Student Number: n9703578
    /// </summary>
    public static class Pig_Single_Die_Game {
        private static Die die;
        private static int faceValue;
        private static int[] pointsTotal;
        private static string[] playersName;
        private static string currentPlayer;
        private static int player1 = 0;
        private static int player2 = 1;

        /// <summary>
        /// Initializes the class variables at the start of a new game
        /// </summary>
        public static void SetUpGame() {
            die = new Die();
            faceValue = 0;
            pointsTotal = new int[] { 0, 0 };
            playersName = new string[] { "Player 1", "Player 2" };
            currentPlayer = GetFirstPlayerName();
        }

        /// <summary>
        /// Rolls the die once for the current player, updating the player’s score 
        /// appropriately according to the faceValue just rolled
        /// </summary>
        /// <returns>true if the player has rolled a one, otherwise false.</returns>
        public static bool PlayGame() {
            die.RollDie();
            faceValue = GetFaceValue();
            int noPoints = 1;
            int points;

            if (faceValue == noPoints) {
                return true;
            } else {
                points = faceValue;
            }

            if (currentPlayer == playersName[player1]) {
                pointsTotal[player1] += points;
            } else if (currentPlayer == playersName[player2]) {
                pointsTotal[player2] += points;
            }
            return false;
        }

        /// <summary>
        /// Checks if current player has won the game
        /// </summary>
        /// <returns>ture if player has won otherwise false</returns>
        public static bool HasWon() {
            int winingScore = 30;
            int playersCurrentScore;

            if (currentPlayer == playersName[player1]) {
                playersCurrentScore = pointsTotal[player1];
            } else if (currentPlayer == playersName[player2]) {
                playersCurrentScore = pointsTotal[player2];
            } else {
                playersCurrentScore = 0;
            }

            if (playersCurrentScore >= winingScore) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the name of the player going first
        /// </summary>
        /// <returns>name of player going first</returns>
        public static string GetFirstPlayerName() {
            currentPlayer = playersName[player1];
            return currentPlayer;
        }

        /// <summary>
        /// Get the name of the next player
        /// </summary>
        /// <returns>name of the next player</returns>
        public static string GetNextPlayerName() {
            if (currentPlayer == playersName[player1]) {
                currentPlayer = playersName[player2];
                return currentPlayer;
            } else {
                currentPlayer = playersName[player1];
                return currentPlayer;
            }
        }

        /// <summary>
        /// Get the specified player’s current points total
        /// </summary>
        /// <param name="nameOfPlayer">specified player name</param>
        /// <returns> specified players total points if name matches otherwise zero</returns>
        public static int GetPointsTotal(string nameOfPlayer) {
            int points = 0;

            if (nameOfPlayer == playersName[player1]) {
                points = pointsTotal[player1];
            } else if (nameOfPlayer == playersName[player2]) { 
                points = pointsTotal[player2];
            }
            return points;
        }

        /// <summary>
        /// Gets the facevalue of the die
        /// </summary>
        /// <returns>facevalue of the die</returns>
        public static int GetFaceValue() {
            return die.GetFaceValue();
        }
    }
}
