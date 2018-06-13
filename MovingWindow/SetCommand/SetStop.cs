using MovingWindow.CommandsTheMoves;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    internal class SetStop : IDirection
    {
        private Stop stop;

        public SetStop(Stop stop)
        {
            this.stop = stop;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Enter)
            {
                stop.DoIIt = true;
            }
        }
    }
}