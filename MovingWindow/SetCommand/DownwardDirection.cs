using MovingWindow.CommandsTheMoves;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DownwardDirection : IDirection
    {
        private Down down;

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
    }
}