using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauMau.core
{
    internal class Game
    {

        public Game(Deck deck, Players players) 
        { 
            this.Deck = deck;
            this.Players = players;
            this.CheckInitValues();

        }

        internal void CheckInitValues()
        {
            if (this.Players.Count < 2) throw new ArgumentException("At least two players are needed");
        }

        public Players Players { get; }
        public Deck Deck { get; }

    }
}
