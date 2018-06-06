using MovingWindow.CommandsTheMoves;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class DirectionInRight : IDirection
    {
        private Right right;

        public DirectionInRight(Right right)
        {
            this.right = right;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Right)
            {
                right.Do_I_It = true;
            }
        }
    }
}