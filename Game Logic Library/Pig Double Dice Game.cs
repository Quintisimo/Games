using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {

    /// <summary>
    /// This class holds the game logic for the Pig Double Die Game
    /// 
    /// Author Quintus Cardozo
    /// Student Number: n9703578
    /// </summary>
    public static class Pig_Double_Dice_Game {
        private static Die[] dice;
        private static int[] faceValue;
        private static int[] pointsTotal; 
        private static string[] playersName;
        private static int firstDice = 0;
        private static int secondDice = 1;
        private const int NUM_OF_PLAYERS = 2;
        private static string currentPlayer;
        private static int player1 = 0;
        private static int player2 = 1;

        /// <summary>
        /// Initializes the class variables at the start of a game
        /// </summary>
        public static void SetUpGame() {
            dice = new Die[NUM_OF_PLAYERS];
            dice[firstDice] = new Die();
            dice[secondDice] = new Die();
            faceValue = new int[] { 0, 0 };
            pointsTotal = new int[] { 0, 0 };
            playersName = new string[] { "Player 1", "Player 2" };
            currentPlayer = GetFirstPlayerName();
        }

        /// <summary>
        /// Rolls the dice once for the current player, updating the player’s score 
        /// appropriately according to the facevalues of the dice just rolled
        /// </summary>
        /// <returns>true if the player has rolled a single one, otherwise false</returns>
        public static bool PlayGame() {
            dice[firstDice].RollDie();
            dice[secondDice].RollDie();
            faceValue[firstDice] = GetFaceValue(firstDice);
            faceValue[secondDice] = GetFaceValue(secondDice);
            int noPoints = 1;
            int maxPoints = 25;
            int pointsMultiplier = 2;
            int points;

            if (faceValue[firstDice] == noPoints || faceValue[secondDice] == noPoints) {
                return true;
            } else if (faceValue[firstDice] == noPoints && faceValue[secondDice] == noPoints) {
                points = maxPoints;
            } else if (faceValue[firstDice] == faceValue[secondDice]) {
                points = (faceValue[firstDice] + faceValue[secondDice]) * pointsMultiplier;
            } else {
                points = faceValue[firstDice] + faceValue[secondDice];
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
            int winingScore = 100;
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
        /// Gets the facevalue of the specified dice
        /// </summary>
        /// <param name="whichDie">specified dice</param>
        /// <returns>facevalue of specified dice</returns>
        public static int GetFaceValue(int whichDie) {
            return dice[whichDie].GetFaceValue();
        }
    }
}
