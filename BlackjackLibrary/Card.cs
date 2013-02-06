using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackLibrary
{
    public class Card
    {
        public Card()
        {
        }

        public Card(Suit suit, CardType cardType)
        {
            this.CardType = cardType;
            this.Suit = suit;
        }

        private Suit _suit;
        public Suit Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        private CardType _cardtype;
        public CardType CardType
        {
            get { return _cardtype; }
            set { _cardtype = value; }
        }

        public int HighValue
        {
            get
            {
                this.CardValues.Sort();
                return this.CardValues.Last();
            }
        }

        public int LowValue
        {
            get
            {
                this.CardValues.Sort();
                return this.CardValues.First();
            }
        }

        private List<int> _cardValues = new List<int>();
        public List<int> CardValues
        {
            get
            {
                switch (this.CardType)
                {
                    case CardType.Deuce:
                        _cardValues.Add(2);
                        break;
                    case CardType.Three:
                        _cardValues.Add(3);
                        break;
                    case CardType.Four:
                        _cardValues.Add(4);
                        break;
                    case CardType.Five:
                        _cardValues.Add(5);
                        break;
                    case CardType.Six:
                        _cardValues.Add(6);
                        break;
                    case CardType.Seven:
                        _cardValues.Add(7);
                        break;
                    case CardType.Eight:
                        _cardValues.Add(8);
                        break;
                    case CardType.Nine:
                        _cardValues.Add(9);
                        break;
                    case CardType.Ten:
                    case CardType.Jack:
                    case CardType.Queen:
                    case CardType.King:
                        _cardValues.Add(10);
                        break;
                    case CardType.Ace:
                        _cardValues.Add(1);
                        _cardValues.Add(11);
                        break;
                }
                return _cardValues;
            }
        }

    }

    public enum Suit
    {
        Hearts,
        Spades,
        Clubs,
        Diamonds
    }

    public enum CardType
    {
        Deuce,
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
        Ace,
    }

}
