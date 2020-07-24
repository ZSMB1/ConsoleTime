using System;

namespace ConsoleTime
{
    public class ClockDriver
    {
        private DateTime CurrentTime { get; }

        public ClockDriver(DateTime initialTime)
        {
            CurrentTime = initialTime;
        }
    }
}
