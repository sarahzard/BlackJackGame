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

        public void Hit()
        {
            //Samme som player's Hit(), skjer etter player.Stay();
            //while sum <= 17
            //newCard, newCard etc
            //etter While loop, "Sum was:"
            //if sum > 21, kjør metode GameOver
            //if sum == 21 || sum >= player.sum kjør metode Winner
        }

        public void DealCard()
        {
            // kjøres 1 gang på starten av hvert game
            //2 kort dealer, 2 kort player
            hiddenCard = Card.NewCard();
            visibleCard = Card.NewCard();
            Console.WriteLine($"Dealer's hand is {hiddenCard.Value1} and {visibleCard.Value1}.");



        }
    }
}