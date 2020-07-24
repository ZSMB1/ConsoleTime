
namespace ConsoleTime
{
    public class DateTime
    {
        private int Year { get; set; }
        private int Month { get; set; }
        private int Day { get; set; }
        private int Hour { get; set; }
        private int Minute { get; set; }
        private int Second { get; set; }

        public DateTime(int year, int month, int day, int hour, int minute, int second)
        {
            Year = year;
            Month = month;
            Day = day;
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public void NextSecond()
        {
            Second++;
            if (Second >= 60)
            {
                Second -= 60;
                Minute++;

                if (Minute >= 60)
                {
                    Minute -= 60;
                    Hour++;

                    if(Hour >= 24)
                    {
                        Hour -= 24;
                        Day++;

                        var monthDays = GetMonthDays();
                        if (Day >= monthDays)
                        {
                            Day -= monthDays;
                            Month++;

                            if(Month >= 12)
                            {
                                Month -= 12;
                                Year++;
                            }
                        }
                    }
                }
            }
        }

        public int GetMonthDays()
        {
            switch (Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    // check if leap year
                    return (Year % 400 == 0) ? 29 : (Year % 100 == 0) ? 28 : (Year % 4 == 0) ? 29 : 28;
                default:
                    return 0;
            };
        }

        public override string ToString()
        {
            return $"{Year:D4}/{Month:D2}/{Day:D2} {Hour:D2}:{Minute:D2}:{Second:D2}";
        }
    }
}
