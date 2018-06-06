namespace MovingWindow.CommandsTheMoves
{
    internal class Down : Command
    {
        private WrapperOverPoint locetion;
        private int heightFrame;
        private int maximumScreenHeight;
        private int step;
        private int y;

        public Down(WrapperOverPoint locetion, int step, int maximumScreenHeight, int heightFrame)
        {
            this.locetion = locetion;
            this.step = step;
            this.maximumScreenHeight = maximumScreenHeight;
            this.heightFrame = heightFrame;
        }

        override public void Executive()
        {
            if (Do_I_It)
            {
                y = locetion.Y;

                if (y + (step + heightFrame) < maximumScreenHeight)
                {
                    locetion.Y = y + step;
                }
            }
        }
    }
}