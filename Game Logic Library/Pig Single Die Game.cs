using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Low_Level_Objects_Library;

namespace Game_Logic_Library {
    public static class Pig_Single_Die_Game {
        private static Die die = new Die();
        private static int faceValue;
        private static int[] pointsTotal;
        private static string[] playersName;
        private static string currentPlayer;
        private static int player1 = 0;
        private static int player2 = 1;

        public static void SetUpGame() {
            pointsTotal = new int[] { 0, 0 };
            playersName = new string[] { "Player 1", "Player 2" };
            currentPlayer = GetFirstPlayerName();
        }

        public static bool PlayGame() {
            die.RollDie();
            faceValue = GetFaceValue();
            int noPoints = 1;

            if (faceValue == noPoints) {
                return true;
            } else {
                if (currentPlayer == playersName[player1]) {
                    pointsTotal[player1] += faceValue;
                } else if (currentPlayer == playersName[player2]) {
                    pointsTotal[player2] += faceValue;
                }
                return false;
            }
        }

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

        public static int GetFaceValue() {
            return die.GetFaceValue();
        }
    }
}
