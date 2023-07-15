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
            players.Add(new Player("Player3"));
            game = new Game(deck, players);

            Assert.Equal(players, game.Players);
            Assert.Equal(deck, game.Deck);


        }

        [Fact] 
        public void CreateRoundTest()
        {
            Players players = new Players() { new Player("Player1"), new Player("Player2") , new Player("Player3") };
            Deck deck = new Deck(true, 0, 1);
            Game game = new Game(deck, players);

            game.ExecuteAction(Actions.StartRoundAction.NAME);
            Assert.Equal(0, game.Round.PlayerTurn);

            Assert.Throws<InvalidOperationException>(() =>
            {
                game.ExecuteAction(Actions.StartRoundAction.NAME);
            });

            game.ExecuteAction(Actions.ShuffleAction.NAME);
            game.ExecuteAction(Actions.ShuffleAction.NAME);

            output.WriteLine(game.Round.Stack.ToString());
            game.ExecuteAction(Actions.CutStackAction.NAME);
            output.WriteLine(game.Round.Stack.ToString());

            game.ExecuteAction(Actions.DealAction.NAME);
            foreach(Player player in game.Players)
            {
                output.WriteLine(player.Hand.ToString());
            }
            output.WriteLine(game.Round.Stack.ToString() );


        }
    }
}
