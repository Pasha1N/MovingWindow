using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MovingWindow.CommandsTheMoves;
using MovingWindow.SetCommand;

namespace MovingWindow
{
    public partial class Window : Form
    {
        private IList<Command> commands = new List<Command>();
        private ICollection<IDirection> directions = new List<IDirection>();
        private Point location = new Point();
        private Rectangle screenSize = Screen.PrimaryScreen.Bounds;
        private int step = 6;
        private WrapperOverPoint wrapperOverLocetion;

        public Window()
        {
            InitializeComponent();
            wrapperOverLocetion = new WrapperOverPoint(location);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            commands.Clear();
            directions.Clear();

            location.X = Location.X;
            location.Y = Location.Y;
            wrapperOverLocetion.X = location.X;
            wrapperOverLocetion.Y = location.Y;

            Down down = new Down(wrapperOverLocetion, step, screenSize.Height, Size.Height);
            Up up = new Up(wrapperOverLocetion, step);
            Left left = new Left(wrapperOverLocetion, step);
            Right rigth = new Right(wrapperOverLocetion, step, screenSize.Width, Size.Width);
            Stop stop = new Stop(this, screenSize);

            commands.Add(down);
            commands.Add(up);
            commands.Add(left);
            commands.Add(rigth);
            commands.Add(stop);

            DirectionInRight directionInRight = new DirectionInRight(rigth);
            DirectionLeft directionLeft = new DirectionLeft(left);
            DirectionUp directionUp = new DirectionUp(up);
            DownwardDirection downwardDirection = new DownwardDirection(down);
            SetStop setStop = new SetStop(stop);

            directions.Add(directionInRight);
            directions.Add(directionLeft);
            directions.Add(directionUp);
            directions.Add(downwardDirection);
            directions.Add(setStop);

            foreach (IDirection direction in directions)
            {
                direction.Executive(e.KeyCode);
            }

            location = wrapperOverLocetion.Dot;
            intervalBetweenOperations.Start();
        }

        private void IntervalBetweenOperations(object sender, EventArgs e)
        {
            int frameSize = 30;

            if (Location.Y <= step || Location.Y > screenSize.Height - step - Size.Height - frameSize || Location.X <= step || Location.X > screenSize.Width - step - Size.Width)
            {
                foreach (IDirection direction in directions)
                {
                   
                }
            }

            foreach (Command command in commands)
            {
                command.Executive();
            }

            if (commands[commands.Count - 1].Do_I_It)
            {
                intervalBetweenOperations.Stop();
            }
            else
            {
                Location = wrapperOverLocetion.Dot;
            }
        }

        //public void SetsDirection()
        //{
        //    for (int i = 0; i < commands.Count; i++)
        //    {
        //        if (commands[i].Do_I_It && commands[i] is Down)
        //        {
        //            commands[i].Do_I_It = false;
        //            commands[i + 1].Do_I_It = true;
        //            break;
        //        }

        //        if (commands[i].Do_I_It && commands[i] is Up)
        //        {
        //            commands[i].Do_I_It = false;
        //            commands[i - 1].Do_I_It = true;
        //            break;
        //        }

        //        if (commands[i].Do_I_It && commands[i] is Left)
        //        {
        //            commands[i].Do_I_It = false;
        //            commands[i + 1].Do_I_It = true;
        //            break;
        //        }

        //        if (commands[i].Do_I_It && commands[i] is Right)
        //        {
        //            commands[i].Do_I_It = false;
        //            commands[i - 1].Do_I_It = true;
        //            break;
        //        }
        //    }
        //}
    }
}