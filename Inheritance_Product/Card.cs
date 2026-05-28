using System;

namespace CardClasses
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        private static Random generator = new Random();

        private int value;
        private int suit;
        // methods 1

        public Card() {}

        //overloaded constructor
        public Card (int v, int s)
        {
            value = v;
            suit = s;
        }

        public bool HasMatchingSuit(Card other)
        {
            if (other.suit == this.suit)
            {
                return true;
            }
            return false;
        }

        public bool HasMatchingValue(Card other)
        {
            if (other.value == this.value)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }
        //properties
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                if (value >= 0 && value <= 13)
                    this.value = value;
                else
                    throw new ArgumentException("Value must be between 0 and 14.");
            }
        }

        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                if (value >= 0 && value <= 4)
                    suit = value;
                else
                    throw new ArgumentException("Value must be between 0 and 5.");
            }
        }
        //methods 2
        public bool IsAce()
        {
            if (value == 1)
            {return true;}
            return false;
        }

        public bool isClub()
        {
            if (suit == 1)
            {return true;}
            return false;
        }

        public bool isDiamond()
        {
            if (suit == 2)
            {return true;}
            return false;
        }

        public bool isHeart()
        {
            if (suit == 3)
            {return true;}
            return false;
        }

        public bool isSpade()
        {
            if (suit == 4)
            {return true;}
            return false;
        }

        public bool isRed()
        {
            if (suit == 2 || suit == 3)
            {return true;}
            return false;
        }
        public bool isBlack()
        {
            if (suit == 1 || suit == 4)
            {return true;}
            return false;
        }
        public bool isFaceCard()
        {
            if (suit == 0 && value == 0)
            { return true; }
            return false;
        }
        
    }
}
