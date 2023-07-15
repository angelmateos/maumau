using MauMau.core.Engine;
using MauMau.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core.Actions
{
    public class DealAction: GameAction
    {
        public const string NAME = "Deal";
        public string Name
        {
            get
            {
                return NAME;
            }
        }
        public bool IsEnabled(Game game)
        {
            return game.Round.State == Round.eRoundState.Cutted;
        }

        public void Execute(Game game)
        {
            foreach(Player player in game.Round.Players)
            {
                player.Hand.Clear();    
            }

            for(int i=0; i<7; i++)
            {
                for(int p= 0; p < game.Players.Count(); p++)
                {
                    Card c = game.Round.Stack.GetCard();
                    int PlayerIndex = (p+game.Round.PlayerTurn+1) % game.Players.Count();
                    game.Round.Players[PlayerIndex].Hand.Add(c);
                }
            }
            game.Round.State = Round.eRoundState.CardsDealt;

        }

    }
}
