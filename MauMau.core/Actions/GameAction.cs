using MauMau.core.Engine;

namespace MauMau.core.Actions
{
    public interface GameAction
    {
        string Name { get; }

        bool IsEnabled(Game game);

        void Execute(Game game);

    }
}
