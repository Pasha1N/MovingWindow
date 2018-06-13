using System.Drawing;

namespace MovingWindow.CommandsTheMoves
{
    internal class Stop : Command
    {
        private Window form;
        private Rectangle screenSize;

        public Stop(Window form, Rectangle screenSize)
        {
            this.form = form;
            this.screenSize = screenSize;
        }

        public override void Executive()
        {
            if (Do_I_It)
            {
                Point location = new Point();
                location.X = screenSize.Width / 2 - form.Width / 2;
                location.Y = screenSize.Height / 2 - form.Height / 2;
                form.Location = location;
            }
        }
    }
}