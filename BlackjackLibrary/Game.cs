using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackLibrary
{
    public class Game
    {
        public Game() 
        {
        }

        public Game(int playerCount, int deckCount)
        {
            for (int i = 0; i < playerCount; i++)
            {
                _players.Add(new Player("Player " + (i+1).ToString(), 1000));
            }

            _dealer = new Player("Dealer", 0);

            //_shoe = new Shoe(deckCount);
        }

        Player _dealer;
        public Player Dealer
        {
            get { return _dealer; }
        }

        List<Player> _players = new List<Player>();
        public List<Player> Players
        {
            get { return _players; }
        }

        Shoe _shoe;
        public Shoe Shoe
        {
            get
            {
                return _shoe;
            }
            set
            {
                _shoe = value;
            }
        }

        public void PrepCards(int deckCount, int shuffleCount)
        {

            this.Shoe = new Shoe(deckCount);

            this.Shoe.Shuffle(shuffleCount);

            this.Shoe.AddRedCard();

        }

        public void Deal()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (Player player in this.Players)
                {
                    if (i == 0) {
                        player.Hand = new List<Hand>();
                        player.Hand.Add(new Hand());
                    }

                    player.Hand.First().Cards.Add(this.Shoe.Cards.Pop());
                }

                if (i == 0)
                {
                    this.Dealer.Hand = new List<Hand>();
                    this.Dealer.Hand.Add(new Hand());
                }

                this.Dealer.Hand.First().Cards.Add(this.Shoe.Cards.Pop());

            }
        }

    }
}
