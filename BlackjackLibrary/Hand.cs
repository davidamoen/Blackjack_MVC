using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackLibrary
{
    public class Hand
    {
        public Hand()
        {
        }

        private List<Card> _cards = new List<Card>();
        public List<Card> Cards
        {
            get
            {
                return _cards;
            }
            set
            {
                _cards = value;
            }
        }

        public int HighValue
        {
            get
            {
                var vals = from v in Values orderby v select v;
                return vals.Last();
            }
        }

        public int LowValue
        {
            get
            {
                var vals = from v in Values orderby v select v;
                return vals.First();
            }
        }

        public bool IsBust
        {
            get
            {
                bool isBust = true;
                foreach (int val in Values)
                {

                    if (val <= 21)
                    {
                        isBust = false;
                        break;
                    }
                }

                return isBust;
            }

        }
        public List<int> Values
        {
            get
            {
                List<int> vals = new List<int>();

                foreach (Card card in this.Cards)
                {
                    if (card.HighValue == card.LowValue)
                    {
                        if (vals.Count == 0)
                        {
                            vals.Add(card.HighValue);
                        }
                        else
                        {
                            for (var i = 0; i < vals.Count; i++)
                            {
                               vals[i] += card.HighValue;
                            }
                        }
                    }
                    else
                    {

                        if (vals.Count == 0)
                        {
                            vals.Add(card.HighValue);
                            vals.Add(card.LowValue);

                        }
                        else
                        {
                            List<int> newList = new List<int>();
                            for (var i = 0; i < vals.Count; i++)
                            {
                                newList.Add(vals[i] + card.LowValue);

                                vals[i] += card.HighValue;
                            }

                            vals.AddRange(newList);

                        }

                    }
                }

                return vals;
            }
        }
    }

}
