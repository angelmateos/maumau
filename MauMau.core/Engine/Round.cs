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

        public Round(Game game)
        {

            Stack = new Cards();
            Stack.AddRange(game.Deck);
            StackIsShuffled = false;
            Discarded = new Cards();
            Players = game.Players;
            PlayerTurn = Players.Count() % game.RoundNumber;
            State = eRoundState.Created;

        }


        public Cards Stack { get; }
        public bool StackIsShuffled { get; internal set; }
        public Cards Discarded { get; }
        public Players Players { get; }

        public int PlayerTurn { get; private set; }


        public eRoundState State { get; set; }
        public enum eRoundState
        {
            Created,
            Shuffled,
            Cutted,
            CardsDealt,
            Playing,
            Close,
        }

    }
}
