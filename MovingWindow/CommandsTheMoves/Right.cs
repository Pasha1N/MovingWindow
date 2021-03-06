﻿namespace MovingWindow.CommandsTheMoves
{
    internal class Right : Command
    {
        private WrapperOverPoint location;
        private int maximumScreenWidth;
        private int step;
        private int widthFrame;
        private int x;

        public Right(WrapperOverPoint location, int step, int maximumScreenWidth, int widthFrame)
        {
            this.location = location;
            this.step = step;
            this.maximumScreenWidth = maximumScreenWidth;
            this.widthFrame = widthFrame;
        }

        public override void Executive()
        {
            if (DoIIt)
            {
                x = location.X;

                if (x + (step + widthFrame) < maximumScreenWidth)
                {
                    location.X = x + step;
                }
            }
        }
    }
}