using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    internal class Up : Command
    {
        private WrapperOverPoint locetion;
        private int step;
        private int y;

        public Up(WrapperOverPoint locetion, int step)
        {
            this.locetion = locetion;
            this.step = step;
        }

        override public void Executive()
        {
            if (Do_I_It)
            {
                y = locetion.Y;

                if (y - step > 0)
                {
                    locetion.Y = y - step;
                }
            }
        }
    }
}