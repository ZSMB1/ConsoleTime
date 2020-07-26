
using System;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleTime
{
    public class ConsoleClock
    {
        public ConsoleClock(string inputDate, ClockPosition pos = ClockPosition.Left)
        {
            if(!DateTimeParser.TryParse(inputDate, out var initialTime))
            {
                throw new FormatException("Invalid initial time format. Supported format: \"YYYY/MM/DD hh:mm:ss\"");
            }
            ClockDriver clock = new ClockDriver(initialTime, pos);
            clock.Start();
        }
    }
}
