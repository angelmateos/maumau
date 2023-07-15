using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MauMau.core.Engine;

namespace MauMau.core.Actions
{
    public class StartRoundAction : GameAction
        {
        public const string NAME = "Start Round";
        public string Name
            {
                get
                {
                    return NAME;
                }
            }
        public bool IsEnabled(Game game) 
            {
            return game.Round == null;
            }

        public void Execute(Game game)
        {
            game.StartRound();
        }

    }
}
