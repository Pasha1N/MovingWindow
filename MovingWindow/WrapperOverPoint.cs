using System.Drawing;

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
            set { value = point; }
        }

        public int X
        {
            get { return point.X; }
            set { value = point.X; }
        }

        public int Y
        {
            get { return point.Y; }
            set { value = point.Y; }
        }
    }
}