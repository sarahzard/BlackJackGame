using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Dealer : Base
    {
        public override int InitialCards()
        {
            CardTwo = new Card();
            Console.WriteLine($"Dealer's hand is hidden card and {CardTwo.Id} ({CardTwo.CardValue}).\n");

            return CardTwo.CardValue;
        }
        public int PlayTurn()
        {
            CardOne = new Card();
            SumOfCards = CardOne.CardValue + CardTwo.CardValue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Dealer's turn!\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"Dealer revealed hidden card! Hidden card is: {CardOne.Id} ({CardOne.CardValue}). " +
                              $"The dealer's initial sum is: {SumOfCards}\n");
            return SumOfCards;
        }
        public override int Hit()
        {
            CardN = new Card();
            SumOfCards += CardN.CardValue;
            Console.WriteLine($"Dealer pulled {CardN.Id} ({CardN.CardValue}). Dealer's sum is now: {SumOfCards}");
            
            return SumOfCards;
        }

    }
}