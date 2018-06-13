using MovingWindow.CommandsTheMoves;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DirectionLeft : IDirection, ISetOppositeDirection
    {
        private Left left;
        private IList<Command> commands = new List<Command>();

        public DirectionLeft(Left left)
        {
            this.left = left;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Left)
            {
                left.DoIIt = true;
            }
        }

        public void SetOppositeDirection(IList<Command> commands)
        {
            foreach (Command command in commands)
            {
                if (command is Right)
                {
                    command.DoIIt = true;
                }

                if (command is Left)
                {
                    command.DoIIt = false;
                }
            }
        }
    }
}