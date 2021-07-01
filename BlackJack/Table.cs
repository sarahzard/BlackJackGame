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
            //Give cards to dealer, give cards to player + write to console
            _dealer.DealCard();

            //WriteLine "Your hand is: ** would you like to hit or stay"
            _player.InitialCards();

            //repeat until gameover or plays stays

            //

            //Display end message
            if (_player.Sum == 21)
            {
                if(_player.Sum == 21) //&& cardCount == 2)
                BlackJack();
                else
                {
                    TwentyOne();
                }
            }
            else if (_player.Sum > 21)
            {
                GameOver();
            }
            else if (_player.Sum < 21)
            {

            }

        }

        public void BlackJack()
        {
            Console.WriteLine("Congratulations! You got Blackjack!");
        }

        public void TwentyOne()
        {
            Console.WriteLine("Congratulations! You got TwentyOne!");
        }

        public void GameOver()
        {
            Console.WriteLine("Sorry! You lost.");
        }
    }
}