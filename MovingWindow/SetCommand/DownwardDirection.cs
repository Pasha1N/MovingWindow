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

        public void Executive(Keys key)
        {
            if (key == Keys.Down)
            {
                down.Do_I_It = true;
            }
        }

        public void SetOppositeDirection(IList<Command> commands)
        {
            foreach (Command command in commands)
            {
                if (command is Down)
                {
                    command.Do_I_It = false;
                }

                if (command is Right)
                {
                    command.Do_I_It = true;
                }
            }
        }
    }
}