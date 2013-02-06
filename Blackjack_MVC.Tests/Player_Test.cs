using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BlackjackLibrary;
using System.Linq;
using System.Collections.Generic;
namespace Blackjack_MVC.Tests
{
    [TestClass]
    public class Player_Test
    {
        [TestMethod]
        public void PlayerCreate()
        {

            Player player = new Player("Jimmy", 15000);
            Assert.AreEqual("Jimmy", player.Name);
            Assert.AreEqual(15000, player.Dollars);
            Assert.IsNull(player.Hand);

            player.Hand = new List<Hand>();
            Assert.IsNotNull(player.Hand);


        }
    }
}
