using System;
using System.Drawing;
using System.Timers;

namespace ConsoleTime
{
    public class ClockDriver
    {
        private Timer _timer;
        private ClockPosition ClockPosition { get; }
        private DateTime CurrentTime { get; }

        public ClockDriver(DateTime initialTime, ClockPosition clockPosition)
        {
            _timer = new Timer(1000);
            _timer.Elapsed += Tick;
            _timer.AutoReset = true;
            _timer.Enabled = true;

            CurrentTime = initialTime;
            ClockPosition = clockPosition;
        }

        public void Start()
        {
            // reserve first row for the clock
            Console.WriteLine();

            _timer.Start();
        }

        private void Tick(Object src, ElapsedEventArgs e)
        {
            // add 1 second
            CurrentTime.NextSecond();

            string time = CurrentTime.ToString();
            int cursorLeft = Console.CursorLeft,
                cursorTop = Console.CursorTop,
                width = Console.WindowWidth;

            // clean line (useful when window gets resized)
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', width) + '\n');

            if (ClockPosition == ClockPosition.Left)
            {
                Console.SetCursorPosition(0, 0);
            }
            else if (ClockPosition == ClockPosition.Right)
            {
                Console.SetCursorPosition(width - time.Length, 0);
            }
            else if (ClockPosition == ClockPosition.Center)
            {
                Console.SetCursorPosition(width / 2 - time.Length / 2, 0);
            }
            Console.Write($"{time}");

            // reset cursor to original location
            Console.SetCursorPosition(cursorLeft, cursorTop);
        }
    }
}
