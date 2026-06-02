using System;
using System.Collections.Generic;

namespace CardClasses
{
    public class BJHand: Hand
    {
        //methods
        public BJHand(): base()
        {
            
        }
        
       public BJHand(Deck d, int numCards) : base(d, numCards)
        {
            
        }
        
        //Properties
        public bool HasAce
        {
            get
            {
                for (int i = 0; i < NumCards; i++)
                { 
                    if (GetCard(i).Value == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool isBusted
        {
            get
            {
                if (Score > 21)
                {
                    return true;
                }
                return false;
            }
        }

        public int Score
        {
            get
            {
                int score = 0;
                int aceCount = 0;
                for (int i = 0; i < NumCards; i++)
                {
                    if (GetCard(i).Value == 1)
                    {
                        score += 11;
                        aceCount++;
                    }
                    else if (GetCard(i).Value > 10)
                    {
                        score += 10;
                    }
                    else
                    {
                        score += GetCard(i).Value;
                    }
                    if (aceCount > 0 && score > 21) 
                    { 
                        score -= 10; 
                        aceCount--;
                    }
                }
                return score;
            }
        }
    }
}