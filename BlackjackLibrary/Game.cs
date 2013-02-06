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

        public Game(int playerCount)
        {
            for (int i = 0; i < playerCount; i++)
            {
                _players.Add(new Player("Player " + (i+1).ToString(), 1000));
            }

            _dealer = new Player("Dealer", 0);
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

    }
}
