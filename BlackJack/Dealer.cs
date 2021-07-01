using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Dealer
    {
        private Card hiddenCard = new Card();
        private Card visibleCard = new Card();
        private int _initialSum;
        private int _sumOfCards;
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
        public Card InitialCards()
        {
            hiddenCard = new Card();
            visibleCard = new Card();
            Console.WriteLine($"Dealer's hand is hidden card and {visibleCard.Value} ({(int)visibleCard.Value}).\n");
            return hiddenCard;
        }
        public int PlayTurn()
        {
            InitialSum = (int)hiddenCard.Value + (int)visibleCard.Value;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Dealer's turn!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Dealer revealed hidden card! Hidden card is: {hiddenCard.Value} ({(int)hiddenCard.Value}). " +
                              $"The dealer's initial sum is: {InitialSum}\n");
            SumOfCards = InitialSum;
            return SumOfCards;
        }
        public int Hit()
        {
            var card = new Card();
            SumOfCards += (int)card.Value;

            Console.WriteLine($"Dealer pulled {card.Value} ({(int)card.Value}). Dealer's sum is now: {SumOfCards}");

            return SumOfCards;
            //etter While loop, "Sum was:"
            //if sum > 21, kjør metode GameOver
            //if sum == 21 || sum >= player.sum kjør metode Winner
        }

    }
}