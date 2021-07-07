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

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Dealer's hand is [HIDDEN CARD] and {CardTwo.Id} of {CardTwo.Suit}({CardTwo.Value}).\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            return CardTwo.Value;
        }
        public int PlayTurn()
        {
            CardOne = new Card();

            InitialSum = CardOne.Value + CardTwo.Value;
            SumOfCards = InitialSum;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Dealer's turn!\n");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Dealer revealed hidden card! Hidden card is: {CardOne.Id} of {CardOne.Suit}({CardOne.Value})");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"The dealer's initial sum is: {SumOfCards}\n");
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

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Dealer pulled {CardN.Id} of {CardN.Suit}({CardN.Value}). Dealer's sum is now: {SumOfCards}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();

            return SumOfCards;
        }

    }
}