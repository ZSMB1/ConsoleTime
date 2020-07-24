using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTime
{
    public class Date
    {
        private int Year { get; set; }
        private int Month { get; set; }
        private int Day { get; set; }

        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}
