﻿using System.Drawing;

namespace MovingWindow
{
    internal class WrapperOverPoint
    {
        private Point point;

        public WrapperOverPoint(Point point)
        {
            this.point = point;
        }

        public Point Dot
        {
            get { return point; }
            set { point = value; }
        }

        public int X
        {
            get { return point.X; }
            set { point.X = value; }
        }

        public int Y
        {
            get { return point.Y; }
            set { point.Y = value; }
        }
    }
}