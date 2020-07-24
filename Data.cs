
namespace ConsoleTime
{
    public static class Data
    {
        public enum Months
        {
            January = 1, February, March, April, May, June, July, August, September, October, November, December
        }

        public static int GetMonthDays(int year, int month)
        {
            switch(month)
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
                    return (year % 400 == 0) ? 29 : (year % 100 == 0) ? 28 : (year % 4 == 0) ? 29 : 28;
                default:
                    return 0;
            };
        }
    }
    
}
