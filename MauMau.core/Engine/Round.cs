using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauMau.core.Model;

namespace MauMau.core.Engine
{
    public class Round
    {

        public Round(Deck d, Players players, int roundNumber)
        {

            Stack = new Cards();
            Stack.AddRange(d);
            Discarded = new Cards();
            Players = players;

        }

        public Cards Stack { get; }
        public Cards Discarded { get; }
        public Players Players { get; }


    }
}
