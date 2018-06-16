using MovingWindow.CommandsTheMoves;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DownwardDirection : IDirection, ISetOppositeDirection
    {
        private Down down;
        private IList<Command> commands = new List<Command>();

        public DownwardDirection(Down down)
        {
            this.down = down;
        }

        public bool CurrentDirection
        {
            get { return down.DoIIt; }
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Down)
            {
                down.DoIIt = true;
            }
        }

        public void SetOppositeDirection(IEnumerable<Command> commands, ISetOppositeDirection currrentDirection, LookFor lookFor)
        {
            if (currrentDirection.CurrentDirection)
            {
                foreach (Command command in commands)
                {
                    if (currrentDirection is DownwardDirection)
                    {
                        if (command is Down)
                        {
                            command.DoIIt = false;
                        }

                        if (command is Up)
                        {
                            command.DoIIt = true;
                        }
                    }
                }
                lookFor.Found = true;
            }
        }
    }
}