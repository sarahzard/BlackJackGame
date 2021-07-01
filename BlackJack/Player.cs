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

        public void InitialCards()
        {
            Card card1 = new Card();
            Card card2 = new Card();
            Console.WriteLine($"Your hand is: {card1.Value1} and {card2.Value1}");
            Console.WriteLine("Would you like to hit or stay? h/s\n");
            var choice = Console.ReadKey();

            if (choice.KeyChar == 'h')
            {
                Hit();
            }
            else if (choice.KeyChar == 's')
            {
                Stay();
            }
        }
        public static int Hit()
        {
            
            var newCardValue = Card.NewCard();
            int prevSum = 0; //something
            int newSum = 0;//prevSum + (int)newCardValue;


            //UpdateScore();
            return newSum;
        }

        public void Stay()
        {
            // bool settes til true; isDone = true;?
        }

        //public static int UpdateScore()
        //{
        //    //int updatedScore = Player.Hit();
        //    //_sumOfCards = score;
        //    //return updatedScore;
        //}


    }
}