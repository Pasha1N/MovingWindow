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

        public bool CurrentDirection
        {
            get { return left.DoIIt; }
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Left)
            {
                left.DoIIt = true;
            }
        }

        public void SetOppositeDirection(IEnumerable<Command> commands, ISetOppositeDirection currrentDirection, LookFor lookFor)
        {
            if (currrentDirection.CurrentDirection)
            {
                foreach (Command command in commands)
                {
                    if (currrentDirection is DirectionLeft)
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
                lookFor.Found = true;
            }
        }
    }
}