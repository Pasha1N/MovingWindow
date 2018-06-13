using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    internal class Up : Command
    {
        private WrapperOverPoint location;
        private int step;
        private int y;

        public Up(WrapperOverPoint location, int step)
        {
            this.location = location;
            this.step = step;
        }

        override public void Executive()
        {
            if (Do_I_It)
            {
                y = location.Y;

                if (y - step > 0)
                {
                    location.Y = y - step;
                }
            }
        }
    }
}