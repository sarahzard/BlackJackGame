using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public abstract class Base
    {
        //private int _initialSum;
        //private int _sumOfCards;
        //private Card _cardOne;
        //private Card _cardTwo;

        public int InitialSum { get; set; }
        public int SumOfCards { get; set; }
        public Card CardOne { get; set; }
        public Card CardTwo { get; set; }
        public Card CardN { get; set; }

        public abstract int InitialCards();

        public abstract int Hit();

        //public abstract void PlayTurn();
        //Se på denne til slutt, 2 forskjellige returns (void og int). Kan gjøre om?
    }
}
