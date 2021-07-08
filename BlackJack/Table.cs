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
        private bool _gameRunning;

        public Table()
        {
            _dealer = new Dealer();
            _player = new Player();
        }

        #region Methods

        public static void WelcomeMessage()
        {
            Console.Clear();
            string border = new('=', 51);
            string space = new string(' ', 15);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(border);
            Console.WriteLine(space + "LET'S PLAY BLACKJACK!" + space);
            Console.WriteLine(border + "\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void PlayBlackJack()
        {
            _gameRunning = true;
            while (_gameRunning)
            {
                WelcomeMessage();

                _dealer.InitialCards();
                _player.InitialCards();

                if (_player.InitialSum == 21)
                {
                    TrueBlackJack();
                    break;
                }

                while (_player.isPlaying)
                {
                    _player.PlayTurn();

                    if (_player.SumOfCards > 21)
                    {
                        GameOver();
                        Console.WriteLine($"Your total was {_player.SumOfCards}.");
                        break;
                    }
                }

                if (_player.SumOfCards <= 21)
                {
                    _dealer.PlayTurn();
                    while (_dealer.SumOfCards <= 17)
                    {
                        _dealer.Hit();
                    }
                }

                if (_dealer.SumOfCards >= _player.SumOfCards && _dealer.SumOfCards <= 21)
                {
                    GameOver();
                    Console.WriteLine(
                        $"Your total was {_player.SumOfCards}, and the dealer's total was {_dealer.SumOfCards}.\n");
                    ResetGame();

                }
                else if (_dealer.SumOfCards >= _player.SumOfCards && _dealer.SumOfCards > 21)
                {
                    PlayerWin();
                    ResetGame();
                }
                else if (_dealer.SumOfCards < _player.SumOfCards && _player.SumOfCards <= 21)
                {
                    PlayerWin();
                    ResetGame();
                }
                else if (_dealer.SumOfCards < _player.SumOfCards && _player.SumOfCards > 21)
                {
                    ResetGame();
                }
                else
                {
                    Console.WriteLine("Error. Programmer did not take this into account. Both lose.");
                    ResetGame();
                }
            }
        }

        public void TrueBlackJack()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongratulations! You got true Blackjack!");
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteEndMessage();
        }

        public void PlayerWin()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nCongratulations! You won!");
            Console.ForegroundColor = ConsoleColor.Gray;
            WriteEndMessage();
        }

        public void GameOver()
        {
            _player.isPlaying = false;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSorry! You lost.");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public void WriteEndMessage()
        {
            Console.WriteLine(
                $"Your total was {_player.SumOfCards}, and the dealer's total was {_dealer.SumOfCards}.\n");
        }

        public void ResetGame()
        {
            Console.WriteLine("\nWould you like to play again?  y/n");

            var userInput = Console.ReadKey(true).Key;
            if (userInput == ConsoleKey.Y)
            {
                _player.isPlaying = false;
                _gameRunning = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        

            #endregion Methods
        }
    }
