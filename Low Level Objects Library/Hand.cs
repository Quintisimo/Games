using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Objects_Library {
    public class Hand: IEnumerable {
        private List<Card> hand;

        public Hand() {
            hand = new List<Card>();
        }

        public Hand(List<Card> cards) {
            hand = new List<Card>();
            foreach(Card card in cards) {
                hand.Add(card);
            }
        }

        public int GetCount() {
            return hand.Count;
        }

        public Card GetCard(int index) {
            return hand[index];
        }

        public void Add(Card card) {
            hand.Add(card);
        }

        public bool Contains(Card card) {
            if (hand.Contains(card) == true) {
                return true;
            }
            return false;
        }

        public bool Remove(Card card) {
           if (hand.Contains(card) == true) {
                hand.Remove(card);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index) {
            hand.Remove(hand[index]);
        }

        public void Sort() {
            hand.Sort();
        }

        public IEnumerator GetEnumerator() {
            return hand.GetEnumerator();
        }
    }
}
