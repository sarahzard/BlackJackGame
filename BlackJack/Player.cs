using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Player : Base
    {
        public bool isPlaying = true;

        public override int InitialCards() 
        {
            CardOne = new Card();
            CardTwo = new Card();
            Console.WriteLine($"Your hand is: {CardOne.Id}({CardOne.Value}) and {CardTwo.Id}({CardTwo.Value})\n");
            InitialSum = CardOne.Value + CardTwo.Value;
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
        public override int Hit()
        {
            CardN = new Card();
            if (SumOfCards + CardN.Value > 21)
            {
                CardN.ConvertAceValue();
            }
            SumOfCards += CardN.Value;
            Console.WriteLine($"You got {CardN.Id} ({CardN.Value}). Your sum is now {SumOfCards}.");
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