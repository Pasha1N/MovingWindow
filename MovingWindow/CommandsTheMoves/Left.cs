namespace MovingWindow.CommandsTheMoves
{
    internal class Left : Command
    {
        private WrapperOverPoint location;
        private int step;
        private int x;

        public Left(WrapperOverPoint location, int step)
        {
            this.location = location;
            this.step = step;
        }

        public override void Executive()
        {
            if (DoIIt)
            {
                x = location.X;

                if (x - step > 0)
                {
                    location.X = x - step;
                }
            }
        }
    }
}