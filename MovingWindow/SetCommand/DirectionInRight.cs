using MovingWindow.CommandsTheMoves;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DirectionInRight : IDirection, ISetOppositeDirection
    {
        private Right right;

        public DirectionInRight(Right right)
        {
            this.right = right;
        }

        public bool CurrentDirection
        {
            get { return right.DoIIt; }
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Right)
            {
                right.DoIIt = true;
            }
        }

        public void SetOppositeDirection(IEnumerable<Command> commands, ISetOppositeDirection currrentDirection, LookFor lookFor)
        {
            if (currrentDirection.CurrentDirection)
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
                lookFor.Found = true;
            }
        }
    }
}