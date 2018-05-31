using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    class Up : Command
    {
        private WrapperOverPoint locetion;
        int y;
        private int step;


        public Up(WrapperOverPoint locetion, int step)
        {
            this.locetion = locetion;
            this.step = step;
        }

        override public void Executive()
        {
            if (ThisCurrentDirection)
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