using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library {

    /// <summary>
    /// Hand holds the cards currently in the user or computers hands
    /// 
    /// Author by Quintus Cardozo 
    /// Student Number: n9703578
    /// </summary>

    public class Hand: IEnumerable {
        private List<Card> hand;

        /// <summary>
        /// Creates an empty hand
        /// </summary>
        public Hand() {
            hand = new List<Card>();
        }

        /// <summary>
        /// Creates an empty hand with cards 
        /// </summary>
        /// <param name="cards">cards in hand</param>
        public Hand(List<Card> cards) {
            hand = new List<Card>();
            foreach(Card card in cards) {
                hand.Add(card);
            }
        }

        /// <summary>
        /// Counts the number of cards in hand
        /// </summary>
        /// <returns>number of cards in hand</returns>
        public int GetCount() {
            return hand.Count;
        }

        /// <summary>
        /// Returns the card at the specified position
        /// </summary>
        /// <param name="index">specified position</param>
        /// <returns>specified card</returns>
        public Card GetCard(int index) {
            return hand[index];
        }

        /// <summary>
        /// Addes card to the hand
        /// </summary>
        /// <param name="card">card to be added to hand</param>
        public void Add(Card card) {
            hand.Add(card);
        }

        /// <summary>
        /// Checks if hand contains specified card
        /// </summary>
        /// <param name="card">specified card</param>
        /// <returns>true if card is in hand otherwise false</returns>
        public bool Contains(Card card) {
            if (hand.Contains(card) == true) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes specified card from the hand if the card is in the hand
        /// </summary>
        /// <param name="card">specified card</param>
        /// <returns>true if card is removed otherwise false</returns>
        public bool Remove(Card card) {
           if (hand.Contains(card) == true) {
                hand.Remove(card);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Removes the card at a specified position
        /// </summary>
        /// <param name="index">specified position</param>
        public void RemoveAt(int index) {
            hand.Remove(hand[index]);
        }

        /// <summary>
        /// Sorts the cards in the hand
        /// </summary>
        public void Sort() {
            hand.Sort();
        }

        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }
    }
}
