﻿using MovingWindow.CommandsTheMoves;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingWindow.SetsDirection
{
    class DirectionInRight : IDirection
    {
        private Right right;

        public DirectionInRight(Right right)
        {
            this.right = right;
        }

        public void Executive(Keys key)
        {
            if (key == Keys.Right)
            {
                right.ThisCurrentDirection = true;
            }
        }
    }
}