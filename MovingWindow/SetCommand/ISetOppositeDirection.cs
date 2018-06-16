using MovingWindow.CommandsTheMoves;
using System.Collections.Generic;

namespace MovingWindow.SetCommand
{
    internal interface ISetOppositeDirection
    {
        void SetOppositeDirection(IEnumerable<Command> commands, ISetOppositeDirection direction, LookFor lookFor);

        bool CurrentDirection { get; }
    }
}