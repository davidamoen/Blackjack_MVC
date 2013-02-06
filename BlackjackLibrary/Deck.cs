using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackLibrary
{
    public class Deck
    {
        public Deck() 
        {
            this.Build();
        }

        List<Card> _cards = new List<Card>();
        public List<Card> Cards
        {
            get { return _cards; }
            set { _cards = value; }

        }

        private void Build()
        {
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (CardType card_type in Enum.GetValues(typeof(CardType)))
                {
                    this.Cards.Add(new Card { CardType = card_type, Suit = suit }); ;
                }
            }

        }

    }
}
