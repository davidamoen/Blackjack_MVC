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

            Game game = new Game(6);

            Assert.AreEqual(6, game.Players.Count);

            Assert.AreEqual("Player 1", game.Players[0].Name);

            Assert.IsNull(game.Players[0].Hand);

            Assert.IsNotNull(game.Dealer);

            Assert.AreEqual("Dealer", game.Dealer.Name);

            Assert.AreEqual(0, game.Dealer.Dollars);
        }
    }
}
