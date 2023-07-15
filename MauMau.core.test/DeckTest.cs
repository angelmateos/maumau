using MauMau.core.Model;
using System.Text;
using Xunit.Abstractions;

namespace MauMau.core.test
{
    public class DeckTest
    {


        private readonly ITestOutputHelper output;

        public DeckTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void CreateDeskCorrectValues()
        {
            Assert.Throws<ArgumentException>(() => {
                Deck d = new Deck(true, -1, 1);
            });

            Assert.Throws<ArgumentException>(() => {
                Deck d = new Deck(true, 8, 2);
            });

            Assert.Throws<ArgumentException>(() => {
                Deck d = new Deck(true, -1 , 1);
            });


        }


        [Fact]
        public void CreateDeskMin()
        {
            Deck d = new Deck(false, 0, 1);
            foreach(var card in d)
            {
                output.WriteLine(card.ToString());
            }

            Assert.Equal(Deck.NUMBER_OF_SUITS * Deck.NUMBER_OF_CARDS_MIN, d.Count);

            var dg = d.Where(c => c.Suit == eSuit.Golds).ToList();

            Assert.Equal(10, dg.Count);

            dg = d.Where(c => c.CardNumber == eCardNumber.Two).ToList();

            Assert.Equal(Deck.NUMBER_OF_SUITS, dg.Count);

            dg = d.Where(c => c.CardNumber == eCardNumber.Joker).ToList();

            Assert.Empty(dg);


        }

        [Fact]
        public void CreateDeskMax()
        {
            Deck d = new Deck(true, 2, 1);
            foreach (var card in d)
            {
                output.WriteLine(card.ToString());
            }

            Assert.Equal((Deck.NUMBER_OF_SUITS * Deck.NUMBER_OF_CARDS)+2, d.Count);

            var dg = d.Where(c => c.Suit == eSuit.Golds).ToList();

            Assert.Equal(Deck.NUMBER_OF_CARDS, dg.Count);

            dg = d.Where(c => c.CardNumber == eCardNumber.Two).ToList();

            Assert.Equal(Deck.NUMBER_OF_SUITS, dg.Count);

            dg = d.Where(c => c.CardNumber == eCardNumber.Joker).ToList();

            Assert.Equal(2, dg.Count);


        }

        [Fact]
        public void Shuffle()
        {
            Deck d = new Deck(true, 2, 1);
            Deck d2 = new Deck(true, 2, 2);

            StringBuilder stringBuilder = new StringBuilder();
            string line = new string('-', 20);

            d.Shuffle();
            output.WriteLine(d.ToString());
            output.WriteLine(line);

            stringBuilder.Clear();
            d2.Shuffle();
            output.WriteLine(d2.ToString());
            output.WriteLine(line);

            stringBuilder.Clear();
            d.Shuffle();
            output.WriteLine(d.ToString());
            output.WriteLine(line);

            stringBuilder.Clear();
            d2.Shuffle();
            output.WriteLine(d2.ToString());
            output.WriteLine(line);

        }

    }
}