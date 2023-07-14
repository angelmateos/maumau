using MauMau.core.Model;
using MauMau.core.Engine;
using System.Text;
using Xunit.Abstractions;

namespace MauMau.core.test
{
    public class GameTest
    {


        private readonly ITestOutputHelper output;

        public GameTest(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void CreateGameTest() 
        { 
        
            Players players = new Players();
            Deck deck = new Deck(true, 0,1);

            Game game;

            Assert.Throws<ArgumentException>(() => {
                game = new Game(deck, players);
            });


            players.Add(new Player("Player1"));
            Assert.Throws<ArgumentException>(() => {
                game = new Game(deck, players);
            });


            players.Add(new Player("Player2"));
            game = new Game(deck, players);

            Assert.Equal(players, game.Players);
            Assert.Equal(deck, game.Deck);

        }

    }
}
