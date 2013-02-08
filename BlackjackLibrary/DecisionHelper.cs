using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;

namespace BlackjackLibrary
{
    public static class DecisionHelper
    {

        public static PlayerAction MakeDecision(Hand DealerHand, Hand PlayerHand)
        {

            if (PlayerHand.IsSplittable) return DecisionHelper.SplittableHand(DealerHand, PlayerHand);

            if (PlayerHand.HasAce) return DecisionHelper.HasAceHand(DealerHand, PlayerHand);

            return DecisionHelper.HasAceHand(DealerHand, PlayerHand);
        }

        private static PlayerAction StandardHand(Hand DealerHand, Hand PlayerHand)
        {

            return PlayerAction.Stand;
        }

        private static PlayerAction HasAceHand(Hand DealerHand, Hand PlayerHand)
        {

            return PlayerAction.Stand;
        }

        private static PlayerAction SplittableHand(Hand DealerHand, Hand PlayerHand)
        {

            return PlayerAction.Stand;
        }

        /*
        private static List<string> GetDecisionMatrix(string matrixType)
        {


        }
        */

    }






    public enum PlayerAction
    {
        Hit,
        Stand,
        DoubleDown,
        Split
    }
}
