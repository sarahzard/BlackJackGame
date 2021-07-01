using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Table
    {
        private Dealer _dealer;
        private Player _player;

        public Table()
        {
            _dealer = new Dealer();
            _player = new Player();
        }
        public void PlayBlackJack()
        {
            //Skal til classen "table"?
            //start med å dele ut 2 kort hver

            //Hello-text

            //Give cards to dealer, give cards to player

            //
            _dealer.DealCard();

        }

        public void BlackJack()
        {
            Console.WriteLine("Congratulations! You got Blackjack!");
        }

        public void TwentyOne()
        {
            throw new System.NotImplementedException();
        }

        public void GameOver()
        {
            throw new System.NotImplementedException();
        }
    }
}