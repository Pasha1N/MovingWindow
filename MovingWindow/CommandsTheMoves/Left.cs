using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    class Left : Command
    {
        private WrapperOverPoint locetion;
        int x;
        private int step;


        public Left(WrapperOverPoint locetion, int step)
        {
            this.locetion = locetion;
            this.step = step;
        }

        override public void Executive()
        {
            if (ThisCurrentDirection)
            {
                x = locetion.X;

                if (x - step > 0)
                {
                    locetion.X = x - step;
                }
            }
        }
    }
}