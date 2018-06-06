using MovingWindow.CommandsTheMoves;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DirectionUp : IDirection
    {
        private Up up;

        public DirectionUp(Up up)
        {
            this.up = up;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Up)
            {
                up.Do_I_It = true;
            }
        }
    }
}