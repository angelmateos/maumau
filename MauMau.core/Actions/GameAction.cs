using MauMau.core.Engine;

namespace MauMau.core.Actions
{
    public interface GameAction
    {
        string Name { get; }

        bool ActionEnabled(Game game);

        void Action(Game game);

    }
}
