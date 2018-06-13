namespace MovingWindow.CommandsTheMoves
{
    internal abstract class Command
    {
        private bool doIIt = false;

        public bool DoIIt
        {
            get { return doIIt; }
            set { doIIt = value; }
        }

        abstract public void Executive();
    }
}