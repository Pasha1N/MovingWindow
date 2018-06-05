using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    class Right : Command
    {
        private WrapperOverPoint locetion;
        private int x;
        private int widthFrame;
        private int maximumScreenWidth;
        private int step;


        public Right(WrapperOverPoint locetion, int step, int maximumScreenWidth, int widthFrame)
        {
            this.locetion = locetion;
            this.step = step;
            this.maximumScreenWidth = maximumScreenWidth;
            this.widthFrame = widthFrame;
        }

        override public void Executive()
        {
            if (Do_I_It)
            {
                x = locetion.X;

                if (x + (step + widthFrame) < maximumScreenWidth)
                {
                    locetion.X = x + step;
                }
            }
        }
    }
}