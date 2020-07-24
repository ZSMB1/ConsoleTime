
using System;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleTime
{
    public class ConsoleClock
    {
        public ConsoleClock(string input)
        {
            if(!DateTimeParser.TryParse(input, out var initialTime))
            {
                throw new FormatException("Invalid initial time format. Supported format: \"YYYY/MM/DD hh:mm:ss\"");
            }
            ClockDriver clock = new ClockDriver(initialTime);
            clock.Start();
        }
    }
}
