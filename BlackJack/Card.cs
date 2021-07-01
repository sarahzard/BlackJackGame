using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        private int _value;
        private int _suit;
        
        #region Constructors
        public Card(int value = 1)
        {
           // _suit = suit;
            _value = value;
        }
        #endregion Constructors

        #region Properties
        public int Value1
        {
            get => default;
            set => _value = value;
        }

        public int Suit1
        {
            get => default;
            set => _suit = value;

        }
        #endregion Properties

        public enum Suit
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades
        }
        public enum Value
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack = 10,
            Queen = 10,
            King = 10
        }
        public static Card NewCard()
        {
            Random random = new Random();
            int cardValue = random.Next((int) Card.Value.Ace, (int) Card.Value.King+1);
            var card = new Card(cardValue);
            //Console.WriteLine(card);
            return card;
        }

        public string AsString()
        {
            return $"{Value1}";
        }
    }
}