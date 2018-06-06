namespace MovingWindow.CommandsTheMoves
{
    internal class Left : Command
    {
        private WrapperOverPoint locetion;
        private int step;
        private int x;

        public Left(WrapperOverPoint locetion, int step)
        {
            this.locetion = locetion;
            this.step = step;
        }

        override public void Executive()
        {
            if (Do_I_It)
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