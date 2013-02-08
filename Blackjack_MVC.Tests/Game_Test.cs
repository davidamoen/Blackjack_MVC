using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BlackjackLibrary;
using System.Linq;

namespace Blackjack_MVC.Tests
{
    [TestClass]
    public class Game_Test
    {
        [TestMethod]
        public void CreateGame_Test()
        {

            Game game = new Game(6, 6);

            game.PrepCards(6, 7);

            Assert.AreEqual(6, game.Players.Count);

            Assert.AreEqual("Player 1", game.Players[0].Name);

            Assert.IsNull(game.Players[0].Hand);

            Assert.IsNotNull(game.Dealer);

            Assert.AreEqual("Dealer", game.Dealer.Name);

            Assert.AreEqual(0, game.Dealer.Dollars);


        }


        [TestMethod]
        public void Deal_test()
        {
            Game game = new Game(6, 6);

            game.PrepCards(6, 7);

            var originalCardCount = game.Shoe.Cards.Count;

            var firstCard = game.Shoe.Cards.Pop();

            Assert.AreEqual(originalCardCount - 1, game.Shoe.Cards.Count);

            game.Deal();

            Assert.AreEqual(2, game.Dealer.Hand.First().Cards.Count);

        }


        [TestMethod]
        public void Decision_Test()
        {

            Hand dealerHand = new Hand();
            dealerHand.Cards.Add(new Card(Suit.Hearts, CardType.Ten));
            dealerHand.Cards.Add(new Card(Suit.Hearts, CardType.Seven));

            Hand playerHand = new Hand();
            playerHand.Cards.Add(new Card(Suit.Hearts, CardType.Ten));
            playerHand.Cards.Add(new Card(Suit.Hearts, CardType.Eight));

            Assert.AreEqual(PlayerAction.Stand, DecisionHelper.MakeDecision(dealerHand, playerHand));

        }

    }
}
