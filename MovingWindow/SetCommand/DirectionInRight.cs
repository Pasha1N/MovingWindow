using MovingWindow.CommandsTheMoves;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DirectionInRight : IDirection, ISetOppositeDirection
    {
        private Right right;
        private IList<Command> commands = new List<Command>();

        public DirectionInRight(Right right)
        {
            this.right = right;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Right)
            {
                right.DoIIt = true;
            }
        }

        public void SetOppositeDirection(IList<Command> commands)
        {
            foreach (Command command in commands)
            {
                if (command is Left)
                {
                    command.DoIIt = true;
                }

                if (command is Right)
                {
                    command.DoIIt = false;
                }
            }
        }
    }
}