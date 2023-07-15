
using MauMau.core.Model;
using MauMau.core.Actions;

namespace MauMau.core.Engine
{
    public class Game
    {

        public Game(Deck deck, Players players)
        {
            Deck = deck;
            Players = players;
            CheckInitValues();
            AddActions();
        }

        internal void CheckInitValues()
        {
            if (Players.Count < 2) throw new ArgumentException("At least two players are needed");
        }

        public Players Players { get; }
        public Deck Deck { get; }

        private List<GameAction> Actions = new();

        public int RoundNumber { get; private set; } = 0;
        public Round Round { get; private set; }

        internal void AddActions()
        {
            this.Actions.Add(new StartRoundAction());
            this.Actions.Add(new ShuffleAction());
            this.Actions.Add(new CutStackAction());
            this.Actions.Add(new DealAction());

        }

        public void ExecuteAction(string actionName)
        {

            GameAction? action = this.Actions.FirstOrDefault(x => x.Name == actionName);
            if (action != null && action.IsEnabled(this))
                action.Execute(this);
            else
                throw new InvalidOperationException($"Not allowed to execute{actionName}");

        }

        public GameAction GetAction(string actionName)
        {
             GameAction? action = this.Actions.FirstOrDefault(x => x.Name == actionName);
            if (action != null)
                return action;
            else 
                throw new InvalidOperationException($"Not exists action {actionName}");
        }

        public void StartRound()
        {
            this.RoundNumber++;
            this.Round = new Engine.Round(this);
        }
    }
 }

