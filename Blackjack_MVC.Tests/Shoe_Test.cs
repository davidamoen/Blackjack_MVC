using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BlackjackLibrary;
using System.Linq;

namespace Blackjack_MVC.Tests
{
    [TestClass]
    public class Shoe_Test
    {
        [TestMethod]
        public void BuildShoe_Test()
        {
            int deckCount = 6;
            Shoe shoe = new Shoe(deckCount);

            Assert.AreEqual(deckCount, shoe.Decks.Count);

            Assert.AreEqual(52, shoe.Decks[1].Cards.Count);

            Assert.AreEqual(deckCount * 52, shoe.Cards.Count);

        }

        [TestMethod]
        public void Shuffle_Test()
        {

            int deckCount = 6;
            Shoe shoe = new Shoe(deckCount);

            var QueenOfSpades = from card in shoe.Cards
                                where card.Suit == Suit.Spades && card.CardType == CardType.Queen
                                select card;

            Assert.AreEqual(deckCount, QueenOfSpades.Count());

            shoe.Shuffle(7);

            Assert.AreEqual(deckCount * 52, shoe.Cards.Count);

            int originalCount = shoe.Cards.Count;

            shoe.AddRedCard();

            Assert.AreNotEqual(originalCount, shoe.Cards.Count);

        }


    }
}
