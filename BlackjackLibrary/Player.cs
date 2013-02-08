using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackLibrary
{
    public class Player
    {

        public Player(string name, int dollars)
        {
            this.Name = name;
            this.Dollars = dollars;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _dollars;
        public int Dollars
        {
            get { return _dollars; }
            set { _dollars = value; }
        }

        private List<Hand> _hand;
        public List<Hand> Hand
        {
            get{ return _hand;}
            set { _hand = value; }
        }

        private int _bet;
        public int Bet
        {
            get { return _bet; }
            set { _bet = value; }
        }

        public PlayerAction TakeTurn(Hand DealerHand)
        {
            return DecisionHelper.MakeDecision(DealerHand, this.Hand.First());
        }



    }
}
