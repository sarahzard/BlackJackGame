using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        private CardId _value;
        private CardSuit _suit;
        private readonly Random _random = new Random();

        #region Constructors
        public Card()
        {
            _value = (CardId)_random.Next((int)CardId.Two, (int)CardId.Ace + 1);
            _suit = (CardSuit) _random.Next(1, 5);
            AdjustCardValue();
        }
        #endregion Constructors

        #region Properties
        public int Value { get; set; }
        public CardId Id
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

        public CardSuit Suit
        {
            get
            {
                return _suit;
            }
            set
            {
                _suit = value;
            }
        }

        #endregion Properties

        public enum CardSuit
        {
            Hearts = 1,
            Clubs,
            Diamonds,
            Spades
        }
        public enum CardId
        {
            Two = 2,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        public void AdjustCardValue()
        {
            Value = (int)Id;
            if (Id == CardId.Jack || Id == CardId.Queen || Id == CardId.King)
            {
                Value = 10;
            }
            if (Id == CardId.Ace)
            {
                Value = 11;
            }

        }
        public void ConvertAceValue()
        {
            if (Id == CardId.Ace)
            {
                Value = 1;
            }
        }

    }
}