using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovingWindow.CommandsTheMoves;
using MovingWindow.SetsDirection;

namespace MovingWindow
{
    public partial class Form1 : Form
    {
       private ICollection<Command> commands = new List<Command>();
        private ICollection<IDirection> directions = new List<IDirection>();
        private Point location = new Point();

        private Rectangle screenSize = Screen.PrimaryScreen.Bounds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          //  commands.Clear();
          //  directions.Clear();
            int step = 6;
            location.X = Location.X;
            location.Y = Location.Y;
            WrapperOverPoint wrapperOverLocetion = new WrapperOverPoint(location);

            Down down = new Down(wrapperOverLocetion, step, screenSize.Height,Size.Height);
            Up up = new Up(wrapperOverLocetion, step);
            Left left = new Left(wrapperOverLocetion, step);
            Right rigth = new Right(wrapperOverLocetion, step, screenSize.Width, Size.Width);

            commands.Add(down);
            commands.Add(up);
            commands.Add(left);
            commands.Add(rigth);

            DirectionInRight directionInRight = new DirectionInRight(rigth);
            DirectionLeft directionLeft = new DirectionLeft(left);
            DirectionUp directionUp = new DirectionUp(up);
            DownwardDirection downwardDirection = new DownwardDirection(down);

            directions.Add(directionInRight);
            directions.Add(directionLeft);
            directions.Add(directionUp);
            directions.Add(downwardDirection);

            foreach (IDirection direction in directions)
            {
                direction.Executive(e.KeyCode);
            }

            location = wrapperOverLocetion.Dot;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Command command in commands)
            {
                command.Executive();
            }

            Location = location;
        }
    }
}