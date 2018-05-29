using MovingWindow.CommandsTheMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.SetsDirection
{
    class DirectionLeft : IDirection
    {
        private Left left;
        public DirectionLeft(Left left)
        {
            this.left = left;
        }

         public void Executive(Keys key)
        {
            if (key == Keys.Left)
            {
                left.ThisCurrentDirection = true;
            }
        }
    }
}
