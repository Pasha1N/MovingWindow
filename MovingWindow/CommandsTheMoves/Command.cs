using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    abstract class Command
    {
        private bool thisCurrentDirection = false;
        public bool ThisCurrentDirection
        {
            get { return thisCurrentDirection; }
            set { thisCurrentDirection = value; }
        }

        abstract public void Executive();
    }
}