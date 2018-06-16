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

        public override void Executive()
        {
            if (DoIIt)
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