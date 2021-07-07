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
            Console.WriteLine($"Dealer's hand is hidden card and {CardTwo.Id} ({CardTwo.Value}).\n");

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

            Console.WriteLine($"Dealer revealed hidden card! Hidden card is: {CardOne.Id} ({CardOne.Value}). " +
                              $"The dealer's initial sum is: {SumOfCards}\n");
            return SumOfCards;
        }
        public override int Hit()
        {
            CardN = new Card();
            //if (SumOfCards + CardN.Value > 21)
            //{
            //    CardN.ConvertAceValue();
            //}
            SumOfCards += CardN.Value;
            Console.WriteLine($"Dealer pulled {CardN.Id} ({CardN.Value}). Dealer's sum is now: {SumOfCards}");
            
            return SumOfCards;
        }

    }
}