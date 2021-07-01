using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Player
    {
        private int _sumOfCards;
        private int _initialSum;
        public bool isPlaying = true;
        public int SumOfCards
        {
            get
            {
                return _sumOfCards;
            }
            set
            {
                _sumOfCards = value;
            }
        }
        public int InitialSum
        {
            get
            {
                return _initialSum;
            }
            set
            {
                _initialSum = value;
            }
        }

        public int InitialCards()
        {
            Card card1 = new Card();
            Card card2 = new Card();
            Console.WriteLine($"Your hand is: {card1.Value}({(int)card1.Value}) and {card2.Value}({(int)card2.Value})\n");
            InitialSum = (int)card1.Value + (int)card2.Value;
            SumOfCards = InitialSum;

            return InitialSum;
        }

        public void PlayTurn()
        {
            Console.WriteLine("Would you like to hit or stay? h/s\n");
            var choice = Console.ReadKey(); //How to read key but not show in console
            Console.WriteLine();

            if (choice.KeyChar == 'h')
            {
                Hit();
            }
            else if (choice.KeyChar == 's')
            {
                Stay();
            }
        }
        public int Hit()
        {
            var newCard = new Card();
            Console.WriteLine($"You got {newCard.Value} ({(int)newCard.Value}).");
            SumOfCards += (int)newCard.Value;
            //isPlaying = true;
            return SumOfCards;
            
        }

        public void Stay()
        { ;
            Console.WriteLine($"You chose to stay. You sum is: {SumOfCards}\n");
            isPlaying = false;
        }
    }
}