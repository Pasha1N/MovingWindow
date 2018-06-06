namespace MovingWindow.CommandsTheMoves
{
    internal class Right : Command
    {
        private WrapperOverPoint locetion;
        private int maximumScreenWidth;
        private int step;
        private int widthFrame;
        private int x;

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