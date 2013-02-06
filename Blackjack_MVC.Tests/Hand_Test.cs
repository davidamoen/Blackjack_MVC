using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BlackjackLibrary;
using System.Linq;

namespace Blackjack_MVC.Tests
{
    [TestClass]
    public class Hand_Test
    {
        [TestMethod]
        public void BuildSimpleHand_Test()
        {

            Hand hand = new Hand();

            hand.Cards.Add(new Card(Suit.Clubs, CardType.Five));
            hand.Cards.Add(new Card(Suit.Diamonds, CardType.Five));
            
            Assert.AreEqual(10, hand.HighValue);
            Assert.AreEqual(10, hand.LowValue);

        }

        [TestMethod]
        public void BuildHandWithAce_Test()
        {

            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Five));

            Assert.AreEqual(16, hand.HighValue);
            Assert.AreEqual(6, hand.LowValue);

        }

        [TestMethod]
        public void BuildHandWithAce_ThreeCards_Test()
        {
            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Five));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Three));

            Assert.AreEqual(19, hand.HighValue);
            Assert.AreEqual(9, hand.LowValue);
        }

        [TestMethod]
        public void BuildHandThreeCards_TwoAces_Test()
        {

            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Queen));

            Assert.AreEqual(32, hand.HighValue);
            Assert.AreEqual(12, hand.LowValue);

        }

        [TestMethod]
        public void IsBust_Test()
        {
            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Queen));
            hand.Cards.Add(new Card(Suit.Hearts, CardType.King));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Three));

            Assert.IsTrue(hand.IsBust);
        }

        [TestMethod]
        public void IsBust_withAces_Test()
        {
            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Hearts, CardType.King));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.King));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Deuce));

            Assert.IsTrue(hand.IsBust);
        }

        [TestMethod]
        public void IsBust_withAces_NotBust_Test()
        {
            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Hearts, CardType.King));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Four));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Deuce));

            Assert.IsFalse(hand.IsBust);
        }

        [TestMethod]
        public void IsBust_withTwoAces_NotBust_Test()
        {
            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.King));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Nine));

            Assert.IsFalse(hand.IsBust);
        }

        [TestMethod]
        public void IsBlackJack_Test()
        {
            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.King));

            Assert.IsTrue(hand.IsBlackJack);

            hand = new Hand();
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Queen));

            Assert.IsTrue(hand.IsBlackJack);

            hand = new Hand();
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Jack));

            Assert.IsTrue(hand.IsBlackJack);

            hand = new Hand();
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ten));

            Assert.IsTrue(hand.IsBlackJack);

        }

        [TestMethod]
        public void IsNotBlackJack_Test()
        {

            Hand hand = new Hand();
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Nine));

            Assert.IsFalse(hand.IsBlackJack);

            hand = new Hand();
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Ace));

            Assert.IsFalse(hand.IsBlackJack);

            hand = new Hand();
            hand.Cards.Add(new Card(Suit.Hearts, CardType.Ace));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.King));
            hand.Cards.Add(new Card(Suit.Clubs, CardType.Deuce));

            Assert.IsFalse(hand.IsBlackJack);
        }

    }
}
