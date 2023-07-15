using MauMau.core.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core.Actions
{
    public class ShuffleAction: GameAction
    {
        public const string NAME = "Shuffle";
        public string Name
        {
            get
            {
                return NAME;
            }
        }
        public bool IsEnabled(Game game)
        {
            return game.Round.State == Round.eRoundState.Created || game.Round.State == Round.eRoundState.Shuffled;
        }

        public void Execute(Game game)
        {
            game.Round.Stack.Shuffle();
            game.Round.StackIsShuffled = true;
            game.Round.State = Round.eRoundState.Shuffled;
        }

    }

}

