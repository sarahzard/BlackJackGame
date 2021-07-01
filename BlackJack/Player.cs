using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Player
    {
        private int _sumOfCards;

        public int Sum
        {
            get => default;
            set
            {
                if (_sumOfCards > 21)
                {

                }
            }
        }

        public static int Hit()
        {
            Console.WriteLine("");
            var newCardValue = Card.NewCard();
            int prevSum = 0; //something
            int newSum = prevSum + (int)newCardValue;
            
            UpdateScore();
            return newSum;
        }

        public void Stay()
        {
            throw new System.NotImplementedException();
        }

        public static int UpdateScore()
        {
            int updatedScore = Player.Hit();
            //_sumOfCards = score;
            return updatedScore;
        }


    }
}