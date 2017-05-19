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

        public static void SetUpGame() {
            pointsTotal = new int[] { 0, 0 };
            playersName = new string[] { "Player 1", "Player 2" };
            currentPlayer = GetFirstPlayerName();
        }

        public static bool PlayGame() {
            die.RollDie();
            faceValue = GetFaceValue();
            int noPoints = 1;
            int results = 0;

            if (faceValue == noPoints) {
                return true;
            } else {
                if (currentPlayer == playersName[0]) {
                    results = results + faceValue;
                    pointsTotal[0] = results;
                } else if (currentPlayer == playersName[1]) {
                    results = results + faceValue;
                    pointsTotal[1] = results;
                }
                return false;
            }
        }

        public static bool HasWon() {
            int winingScore = 30;
            int playersCurrentScore;

            if (currentPlayer == playersName[0]) {
                playersCurrentScore = pointsTotal[0];
            } else if (currentPlayer == playersName[1]) {
                playersCurrentScore = pointsTotal[1];
            } else {
                playersCurrentScore = 0;
            }

            if (playersCurrentScore >= winingScore) {
                return true;
            }
            return false;
        }

        public static string GetFirstPlayerName() {
            currentPlayer = playersName[0];
            return currentPlayer;
        }
     
        public static string GetNextPlayerName() {
            if (currentPlayer == playersName[0]) {
                currentPlayer = playersName[1];
                return currentPlayer;
            } else {
                currentPlayer = playersName[0];
                return currentPlayer;
            }
        }

        public static int GetPointsTotal(string nameOfPlayer) {

            if (nameOfPlayer == playersName[0]) {
                return pointsTotal[0];
            } else if (nameOfPlayer == playersName[1]) { 
                return pointsTotal[1];
            }
            return 0;
        }

        public static int GetFaceValue() {
            return die.GetFaceValue();
        }
    }
}
