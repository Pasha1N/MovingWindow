using MovingWindow.CommandsTheMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.SetsDirection
{
    class DownwardDirection : IDirection
    {
        private Down down;

        public DownwardDirection(Down down)
        {
            this.down = down;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Down)
            {
                down.ThisCurrentDirection = true;

            }
        }
    }
}