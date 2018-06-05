using MovingWindow.CommandsTheMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
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
                left.Do_I_It = true;
            }
        }
    }
}
