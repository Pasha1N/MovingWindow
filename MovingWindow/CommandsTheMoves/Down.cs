using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    class Down : Command
    {
        private WrapperOverPoint locetion;
        private int y;
        private int heightFrame;
        private int maximumScreenHeight;
        private int step;

        public Down(WrapperOverPoint locetion, int step, int maximumScreenHeight, int heightFrame)
        {
            this.locetion = locetion;
            this.step = step;
            this.maximumScreenHeight = maximumScreenHeight;
            this.heightFrame = heightFrame;
            y = locetion.Y;
        }

        override public void Executive()
        {
            if (ThisCurrentDirection)
            {
                if (y + (step + heightFrame) < maximumScreenHeight)
                {
                    locetion.Y = y + step;
                }
            }
        }
    }
}