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

        public static void SetUpGame() {
            pointsTotal = new int[] { 0, 0 };
            playersName = new string[] { "Player 1", "Player 2" };
        }

        private static int GetCurrentPlayerScore() {
            int noPoints = 0;

            if (pointsTotal[0] == noPoints) {
                return pointsTotal[0];
            } else {
                return pointsTotal[1];
            }
        }

        public static bool PlayGame() {
            die.RollDie();
            faceValue = GetFaceValue();
            int noPoints = 1;

            if (faceValue == noPoints) {
                return true;
            } else {
                int playersScore = GetCurrentPlayerScore();
                playersScore = playersScore + faceValue;
                return false;
            }
        }

        public static bool HasWon() {
            int winingScore = 30;
            int playersCurrentScore = GetCurrentPlayerScore();

            if (playersCurrentScore == winingScore) {
                return true;
            } else {
                return false;
            }
        }

        public static string GetFirstPlayerName() {
            return playersName[0];
        }

        public static string GetNextPlayerName() {
            return playersName[1];
        }

        public static int GetPointsTotal(string nameOfPlayer) {

            if (nameOfPlayer == playersName[0]) {
                return pointsTotal[0];
            } else if (nameOfPlayer == playersName[1]) {
                return pointsTotal[1];
            } else {
                return 0;
            }
        }

        public static int GetFaceValue() {
            return die.GetFaceValue();
        }
    }
}
