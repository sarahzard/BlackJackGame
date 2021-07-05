using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        private CardValue _value;
        private int _suit;
        private Random _random = new Random();

        #region Constructors
        public Card()
        {
            _value = (CardValue)_random.Next((int)CardValue.Ace, (int)CardValue.King + 1);
            AdjustCardValue();
        }
        #endregion Constructors

        #region Properties
        public int RealCardValue { get; set; }
        public CardValue Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }

        public int Suit
        {
            get => default;
            set => _suit = value;

        }
        #endregion Properties

        public enum CardSuit
        {
            Hearts,
            Clubs,
            Diamonds,
            Spades
        }
        public enum CardValue
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
            Jack,// = 10,
            Queen,// = 10,
            King //= 10
        }
        public void AdjustCardValue()
        {
            RealCardValue = (int)Value;
            if (Value == Card.CardValue.Jack || Value == Card.CardValue.Queen || Value == Card.CardValue.King)
            {
                RealCardValue = 10;
                //return card;
            }

            //return card;
        }
    }
}