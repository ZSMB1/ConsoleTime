using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTime
{
    public class Time
    {
        private int Hour { get; set; }
        private int Minute { get; set; }
        private int Second { get; set; }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }
    }
}
