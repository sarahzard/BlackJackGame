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
            Console.WriteLine($"Dealer's hand is hidden card and {CardTwo.Value} ({(int)CardTwo.RealCardValue}).\n");

            return CardTwo.RealCardValue;
        }
        public int PlayTurn()
        {
            CardOne = new Card();
            SumOfCards = CardOne.RealCardValue + CardTwo.RealCardValue;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Dealer's turn!\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"Dealer revealed hidden card! Hidden card is: {CardOne.Value} ({(int)CardOne.RealCardValue}). " +
                              $"The dealer's initial sum is: {SumOfCards}\n");
            return SumOfCards;
        }
        public override int Hit()
        {
            CardN = new Card();
            SumOfCards += CardN.RealCardValue;
            Console.WriteLine($"Dealer pulled {CardN.Value} ({CardN.RealCardValue}). Dealer's sum is now: {SumOfCards}");
            
            return SumOfCards;
        }

    }
}