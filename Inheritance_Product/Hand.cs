
using System;
using System.Collections.Generic;

namespace CardClasses
{
    public class Hand
    {
        protected List<Card> cards = new List<Card>();

        public Hand()
        {
            
        }

        public Hand(Deck d, int numCards)
        {
            for (int i = 0; i < numCards; i++)
            {
                if (!d.IsEmpty)
                {
                    cards.Add(d.Deal());
                }
            }
        }

        public int NumCards
        {
            get
            {
                return cards.Count;
            }
        }

        public Card this[int i]
        {
            get
            {
                return cards[i];
            }
        }

        public void AddCard(Card c)
        {
            cards.Add(c);
        }

        public Card Discard(int index)
        {
            if (index != -1)
            {
                Card discardedCard = cards[index];
                cards.RemoveAt(index);
                return discardedCard;
            }

            return null;
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public bool HasCard(Card c)
        {
            return IndexOf(c) != -1;
        }

        public bool HasCard(int value, int suit)
        {
            return IndexOf(value, suit) != -1;
        }

        public bool HasCard(int value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(Card c)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == c.Value && cards[i].Suit == c.Suit)
                {
                    return i;
                }
            }

            return -1;
        }

        public int IndexOf(int value, int suit)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == value && cards[i].Suit == suit)
                {
                    return i;
                }
            }

            return -1;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == value)
                {
                    return i;
                }
            }

            return -1;
        }

        public override string ToString()
        {
            string output = "";

            foreach (Card c in cards)
            {
                output += c.ToString() + "\n";
            }

            return output;
        }
    }
}