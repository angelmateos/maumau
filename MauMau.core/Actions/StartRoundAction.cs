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
        public string Name
            {
                get
                {
                    return "Start Round";
                }
            }
        public bool ActionEnabled(Game game) { return true; }

        public void Action(Game game)
        {
        }

    }
}
