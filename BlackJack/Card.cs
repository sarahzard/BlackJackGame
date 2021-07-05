using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJack
{
    public class Card
    {
        private CardId _value;
        private int _suit;
        private readonly Random _random = new Random();

        #region Constructors
        public Card()
        {
            _value = (CardId)_random.Next((int)CardId.Ace, (int)CardId.King + 1);
            AdjustCardValue();
        }
        #endregion Constructors

        #region Properties
        public int CardValue { get; set; }
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
        public enum CardId
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
            CardValue = (int)Id;
            if (Id == Card.CardId.Jack || Id == Card.CardId.Queen || Id == Card.CardId.King)
            {
                CardValue = 10;
            }
        }
    }
}