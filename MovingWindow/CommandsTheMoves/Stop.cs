using System.Windows.Forms;

namespace MovingWindow.CommandsTheMoves
{
    internal class Stop : Command
    {
        private bool stop = false;
        private Form1 form;

        public Stop(Form1 form)
        {
            this.form = form;
        }

        public bool ToStop
        {
            get { return stop; }
            set { stop = value; }
        }

        public override void Executive()
        {
            if (stop)
            {
                form.StartPosition = FormStartPosition.CenterScreen;
            }
        }
    }
}