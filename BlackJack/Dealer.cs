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
            Console.WriteLine($"Dealer's hand is hidden card and {CardTwo.Id} of {CardTwo.Suit}({CardTwo.Value}).\n");

            return CardTwo.Value;
        }
        public int PlayTurn()
        {
            CardOne = new Card();
            InitialSum = CardOne.Value + CardTwo.Value;
            SumOfCards = InitialSum;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Dealer's turn!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();

            Console.WriteLine($"Dealer revealed hidden card! Hidden card is: {CardOne.Id} of {CardOne.Suit}({CardOne.Value}). " +
                              $"The dealer's initial sum is: {SumOfCards}\n");
            Console.ReadKey();
            return SumOfCards;
        }
        public override int Hit()
        {
            CardN = new Card();
            
            if (SumOfCards + CardN.Value > 21)
            {
                CardN.ConvertAceValue();
            }
            SumOfCards += CardN.Value;

            Console.WriteLine($"Dealer pulled {CardN.Id} of {CardN.Suit}({CardN.Value}). Dealer's sum is now: {SumOfCards}");
            Console.ReadKey();
            return SumOfCards;
        }

    }
}