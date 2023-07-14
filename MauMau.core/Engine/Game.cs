using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauMau.core.Model;

namespace MauMau.core.Engine
{
    public class Game
    {

        public Game(Deck deck, Players players)
        {
            Deck = deck;
            Players = players;
            CheckInitValues();

        }

        internal void CheckInitValues()
        {
            if (Players.Count < 2) throw new ArgumentException("At least two players are needed");
        }

        public Players Players { get; }
        public Deck Deck { get; }

    }
}
