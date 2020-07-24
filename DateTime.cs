
namespace ConsoleTime
{
    public class DateTime
    {
        public Date Date { get; }
        public Time Time { get; }
        public DateTime(int year, int month, int day, int hour, int minute, int second)
        {
            Date = new Date(year, month, day);
            Time = new Time(hour, minute, second);
        }
        public DateTime(Date date, Time time)
        {
            Date = date;
            Time = time;
        }
    }
}
