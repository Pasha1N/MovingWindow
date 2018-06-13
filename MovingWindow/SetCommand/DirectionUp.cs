using MovingWindow.CommandsTheMoves;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DirectionUp : IDirection, ISetOppositeDirection
    {
        private Up up;
        private IList<Command> commands = new List<Command>();

        public DirectionUp(Up up)
        {
            this.up = up;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Up)
            {
                up.DoIIt = true;
            }
        }

        public void SetOppositeDirection(IList<Command> commands)
        {
            foreach (Command command in commands)
            {
                if (command is Down)
                {
                    command.DoIIt = true;
                }

                if (command is Up)
                {
                    command.DoIIt = false;
                }
            }
        }
    }
}