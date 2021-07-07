using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Player : Base
    {
        public bool isPlaying;

        public override int InitialCards()
        {
            isPlaying = true;
            CardOne = new Card();
            CardTwo = new Card();

            if (CardOne.Id == Card.CardId.Ace && CardTwo.Id == Card.CardId.Ace)
            {
                CardTwo.ConvertAceValue();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Your hand is: {CardOne.Id} of {CardOne.Suit}({CardOne.Value}) and {CardTwo.Id} of {CardTwo.Suit}({CardTwo.Value})\n");

            Console.ForegroundColor = ConsoleColor.Gray;

            InitialSum = CardOne.Value + CardTwo.Value;
            SumOfCards = InitialSum;

            return InitialSum;
        }

        public void PlayTurn()
        {
            Console.WriteLine("Would you like to hit or stay? h/s\n");
            var choice = Console.ReadKey(true); //How to read key but not show in console
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
        public override int Hit()
        {
            CardN = new Card();
            if (SumOfCards + CardN.Value > 21)
            {
                CardN.ConvertAceValue();
            }
            SumOfCards += CardN.Value;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"You got {CardN.Id} of {CardN.Suit}({CardN.Value})");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Your sum is now {SumOfCards}.");
                              
            return SumOfCards;
        }

        public void Stay()
        { 
            Console.WriteLine($"You chose to stay. You sum is: {SumOfCards}\n");
            Console.ReadKey();
            isPlaying = false;
        }
    }
}