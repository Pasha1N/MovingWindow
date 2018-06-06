using MovingWindow.CommandsTheMoves;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DirectionLeft : IDirection
    {
        private Left left;

        public DirectionLeft(Left left)
        {
            this.left = left;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Left)
            {
                left.Do_I_It = true;
            }
        }
    }
}