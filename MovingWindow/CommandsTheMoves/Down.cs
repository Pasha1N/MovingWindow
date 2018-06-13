namespace MovingWindow.CommandsTheMoves
{
    internal class Down : Command
    {
        private WrapperOverPoint location;
        private int heightFrame;
        private int maximumScreenHeight;
        private int step;
        private int y;

        public Down(WrapperOverPoint location, int step, int maximumScreenHeight, int heightFrame)
        {
            this.location = location;
            this.step = step;
            this.maximumScreenHeight = maximumScreenHeight;
            this.heightFrame = heightFrame;
        }

        override public void Executive()
        {
            if (DoIIt)
            {
                y = location.Y;

                if (y + (step + heightFrame) < maximumScreenHeight)
                {
                    location.Y = y + step;
                }
            }
        }
    }
}