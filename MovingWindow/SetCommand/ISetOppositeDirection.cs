using MovingWindow.CommandsTheMoves;
using System.Collections.Generic;

namespace MovingWindow.SetCommand
{
    internal interface ISetOppositeDirection
    {
        void SetOppositeDirection(IList<Command> commands);
    }
}