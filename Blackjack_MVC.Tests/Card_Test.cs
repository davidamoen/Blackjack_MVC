using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BlackjackLibrary;
using System.Linq;

namespace Blackjack_MVC.Tests
{
    [TestClass]
    public class Card_Test
    {
        [TestMethod]
        public void AceOfHearts()
        {
            Card c = new Card(Suit.Hearts, CardType.Ace);

            Assert.AreEqual(c.Suit, Suit.Hearts);

            Assert.AreEqual(c.CardType, CardType.Ace);
        }

        [TestMethod]
        public void CardValueTest()
        {
            Card c = new Card(Suit.Hearts, CardType.Deuce);
            Assert.AreEqual(2, c.HighValue);
            Assert.AreEqual(2, c.LowValue);

            c = new Card(Suit.Hearts, CardType.Seven);
            Assert.AreEqual(7, c.HighValue);
            Assert.AreEqual(7, c.LowValue);

            c = new Card(Suit.Hearts, CardType.Ten);
            Assert.AreEqual(10, c.HighValue);
            Assert.AreEqual(10, c.LowValue);

            c = new Card(Suit.Hearts, CardType.Queen);
            Assert.AreEqual(10, c.HighValue);
            Assert.AreEqual(10, c.LowValue);

            c = new Card(Suit.Hearts, CardType.King);
            Assert.AreEqual(10, c.HighValue);
            Assert.AreEqual(10, c.LowValue);

            c = new Card(Suit.Hearts, CardType.Ace);
            Assert.AreEqual(11, c.HighValue);
            Assert.AreEqual(1, c.LowValue);
        }
    }
}
