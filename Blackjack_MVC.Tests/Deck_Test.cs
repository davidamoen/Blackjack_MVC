using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BlackjackLibrary;
using System.Linq;

namespace Blackjack_MVC.Tests
{
    [TestClass]
    public class Deck_Test
    {
        [TestMethod]
        public void Build_Test()
        {

            Deck deck = new Deck();

            Assert.AreEqual(52, deck.Cards.Count);

            var QueenOfSpades = from card in deck.Cards
                                 where card.Suit == Suit.Spades && card.CardType == CardType.Queen
                                 select card;

            Assert.AreEqual(1, QueenOfSpades.Count());

            Assert.AreEqual(Suit.Spades, QueenOfSpades.First().Suit);
            Assert.AreEqual(CardType.Queen, QueenOfSpades.First().CardType);



            var DeuceOfHearts = from card in deck.Cards
                                where card.Suit == Suit.Hearts && card.CardType == CardType.Deuce
                                select card;

            Assert.AreEqual(1, DeuceOfHearts.Count());

            Assert.AreEqual(Suit.Hearts, DeuceOfHearts.First().Suit);
            Assert.AreEqual(CardType.Deuce, DeuceOfHearts.First().CardType);


        }
    }
}
