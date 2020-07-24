using System;
using System.Timers;

namespace ConsoleTime
{
    public class ClockDriver
    {
        private Timer _timer;
        private DateTime CurrentTime { get; }

        public ClockDriver(DateTime initialTime)
        {
            _timer = new Timer(1000);
            _timer.Elapsed += Tick;
            _timer.AutoReset = true;
            _timer.Enabled = true;

            CurrentTime = initialTime;
        }

        public void Start()
        {
            _timer.Start();
        }

        private void Tick(Object src, ElapsedEventArgs e)
        {
            CurrentTime.NextSecond();
            // TODO: set cursor position to top right corner + add a newline after
            Console.Write($"\r{CurrentTime.ToString()}");
        }
    }
}
