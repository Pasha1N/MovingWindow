using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    abstract class Command
    {
        private bool do_I_It = false;
        public bool Do_I_It
        {
            get { return do_I_It; }
            set { do_I_It = value; }
        }

        abstract public void Executive();
    }
}