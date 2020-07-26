using System;

namespace ConsoleTime
{
    public static class DateTimeParser
    {
        public static bool TryParse(string dateTimeString, out DateTime dateTime)
        {
            dateTime = null;

            var stringParts = dateTimeString.Split(" ");
            if (stringParts.Length != 2) return false;

            var dateParts = stringParts[0].Split("/");
            if (dateParts.Length != 3) return false;

            var timeParts = stringParts[1].Split(":");
            if (timeParts.Length != 3) return false;

            int[] date = new int[3];
            int[] time = new int[3];
            for (int i = 0; i < 3; i++)
            {
                if (!Int32.TryParse(dateParts[i], out date[i]) ||
                   !Int32.TryParse(timeParts[i], out time[i]))
                    return false;
            }

            dateTime = new DateTime(date[0], date[1], date[2], time[0], time[1], time[2]);
            return true;
        }
    }
}
