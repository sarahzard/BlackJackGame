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
            Console.WriteLine($"Dealer's hand is hidden card and {CardTwo.Value} ({(int)CardTwo.Value}).\n");
            //return InitialSum and later remove cardOne's value?
            //InitialSum = (int)CardOne.Value + (int)CardTwo.Value;
            //SumOfCards = InitialSum;
            //return (int)CardOne.Value + (int)CardTwo.Value;
            return (int)CardTwo.Value;
        }
        public int PlayTurn()
        {
            CardOne = new Card();
            SumOfCards = (int)CardOne.Value + (int)CardTwo.Value;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Dealer's turn!\n");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine($"Dealer revealed hidden card! Hidden card is: {CardOne.Value} ({(int)CardOne.Value}). " +
                              $"The dealer's initial sum is: {SumOfCards}\n");
            return SumOfCards;
        }
        public override int Hit()
        {
            CardN = new Card();
            SumOfCards += (int)CardN.Value;
            Console.WriteLine($"Dealer pulled {CardN.Value} ({(int)CardN.Value}). Dealer's sum is now: {SumOfCards}");
            
            return SumOfCards;
        }

    }
}