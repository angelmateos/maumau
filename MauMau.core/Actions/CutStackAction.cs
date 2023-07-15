using MauMau.core.Engine;
using MauMau.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core.Actions
{
    public class CutStackAction: GameAction
    {

        public const string NAME = "Cut";
        public string Name
        {
            get
            {
                return NAME;
            }
        }
        public bool IsEnabled(Game game)
        {
            return game.Round.State == Round.eRoundState.Shuffled;
        }

        public int CardsCutted { get; set; } = 20;

        public void Execute(Game game)
        {
            var temp = game.Round.Stack.GetRange(0, CardsCutted);
            game.Round.Stack.RemoveRange(0, CardsCutted);
            game.Round.Stack.AddRange(temp);
            game.Round.State = Round.eRoundState.Cutted;
        }

    }
}
