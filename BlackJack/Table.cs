using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Table
    {
        private readonly Dealer _dealer;
        private readonly Player _player;


        public Table()
        {
            _dealer = new Dealer();
            _player = new Player();
        }
        public void PlayBlackJack()
        {
            _dealer.InitialCards();
            _player.InitialCards();
            if (_player.InitialSum == 21)
            {
                BlackJack();
                Environment.Exit(0);
            }

            while (_player.isPlaying)
            {
                _player.PlayTurn();

                if (_player.SumOfCards > 21)
                {
                    GameOver();
                    _player.isPlaying = false;
                    Console.WriteLine($"Your total was {_player.SumOfCards}.");
                    Environment.Exit(0);
                }

            }

            _dealer.PlayTurn();

            while (_dealer.SumOfCards <= 17)// && _dealer.CardN.Id != Card.CardId.Ace
            {
                _dealer.Hit();
                if (_dealer.SumOfCards + _dealer.CardN.Value > 21)
                {
                    _dealer.CardN.ConvertAceValue();
                }
            }

            if (_dealer.SumOfCards >= _player.SumOfCards && _dealer.SumOfCards <= 21)
            {
                GameOver();
                Console.WriteLine($"Your total was {_player.SumOfCards}, and the dealer's total was {_dealer.SumOfCards}.\n");

            }
            else if (_dealer.SumOfCards >= _player.SumOfCards && _dealer.SumOfCards > 21)
            {
                BlackJack();
            }
            else if (_dealer.SumOfCards < _player.SumOfCards && _player.SumOfCards <= 21)
            {
                BlackJack();
            }
            else
            {
                Console.WriteLine("Error. Programmer did not take this into account. Both lose. Big sorry.");
            }

        }

        public void BlackJack()
        {
            Console.WriteLine("\nCongratulations! You got true Blackjack!");
            WriteEndMessage();
        }

        public void TwentyOne()
        {
            Console.WriteLine("\nCongratulations! You won!");
            WriteEndMessage();
        }

        public void GameOver()
        {
            Console.WriteLine("\nSorry! You lost.");
        }

        public void WriteEndMessage()
        {
            Console.WriteLine($"Your total was {_player.SumOfCards}, and the dealer's total was {_dealer.SumOfCards}.\n");
        }
    }
}