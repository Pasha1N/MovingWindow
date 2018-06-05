using MovingWindow.CommandsTheMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.SetCommand
{
    class DirectionUp : IDirection
    {
        private Up up;

        public DirectionUp(Up up)
        {
            this.up = up;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Up)
            {
                up.Do_I_It = true;

            }
        }
    }
}