using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackLibrary
{
    public class Shoe
    {

        public Shoe(int decks)
        {
            this.Build(decks);
        }

        private List<Deck> _decks = new List<Deck>();
        public List<Deck> Decks
        {
            get { return _decks; }
            set { _decks = value; }
        }

        private List<Card> _cards = new List<Card>();
        public List<Card> Cards
        {
            get
            {
                if (_cards.Count == 0)
                {
                    foreach (Deck d in Decks)
                    {
                        _cards.AddRange(d.Cards);
                    }
                }

                return _cards;

            }

            set { _cards = value; }

        }



        public void Shuffle(int shuffleCount)
        {
            for (int i = 0; i < shuffleCount; i++)
            {

                List<Card> newShoe = new List<Card>();
                Random r = new Random();
                int midPoint = this.Cards.Count() / 2;
                int spread = 10;

                int cut = r.Next(midPoint - spread, midPoint + spread);

                var cutA = this.Cards.GetRange(0, cut);
                cutA.Reverse();

                var cutB = this.Cards.GetRange(cut, this.Cards.Count() - cut);
                cutB.Reverse();

                while (cutA.Count() > 0 && cutB.Count() > 0)
                {
                    int riffleA = r.Next(1,5);
                    newShoe.AddRange(cutA.Take(riffleA));
                    cutA.RemoveRange(0, riffleA > cutA.Count() ? cutA.Count() : riffleA);

                    int riffleB = r.Next(1, 5);
                    newShoe.AddRange(cutB.Take(riffleB));
                    cutB.RemoveRange(0, riffleB > cutB.Count() ? cutB.Count() : riffleB);

                }

                if (cutA.Count() == 0)
                {
                    newShoe.AddRange(cutB);
                }

                if (cutB.Count() == 0)
                {
                    newShoe.AddRange(cutA);
                }

                this.Cards = newShoe;

            }
        }

        public void AddRedCard()
        {

            Random r = new Random();
            int low = this.Cards.Count - (int)(this.Cards.Count * .20);
            int high = this.Cards.Count;
            int cardPosition = r.Next(low, high);
            this.Cards.RemoveRange(cardPosition, high - cardPosition);

        }

        private void Build(int decks)
        {
            for (int i = 0; i < decks; i++)
            {
                this.Decks.Add(new Deck());
            }

        }

    }
}
