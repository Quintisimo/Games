using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {
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

        public static void SetUpGame() {
            dice = new Die[NUM_OF_PLAYERS];
            dice[firstDice] = new Die();
            dice[secondDice] = new Die();
            faceValue = new int[] { 0, 0 };
            pointsTotal = new int[] { 0, 0 };
            playersName = new string[] { "Player 1", "Player 2" };
            currentPlayer = GetFirstPlayerName();
        }

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

        public static string GetFirstPlayerName() {
            currentPlayer = playersName[player1];
            return currentPlayer;
        }

        public static string GetNextPlayerName() {
            if (currentPlayer == playersName[player1]) {
                currentPlayer = playersName[player2];
                return currentPlayer;
            } else {
                currentPlayer = playersName[player1];
                return currentPlayer;
            }
        }

        public static int GetPointsTotal(string nameOfPlayer) {
            if (nameOfPlayer == playersName[player1]) {
                return pointsTotal[player1];
            } else if (nameOfPlayer == playersName[player2]) {
                return pointsTotal[player2];
            }
            return 0;
        }

        public static int GetFaceValue(int whichDie) {
            return dice[whichDie].GetFaceValue();
        }
    }
}
