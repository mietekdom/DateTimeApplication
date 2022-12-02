using System;
using System.Collections.Generic;
using System.Text;

namespace DateTimeApplication
{
    public static class Utils
    {
        public static bool IsDateBetween(DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }
        public static bool IsBetween(this DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }
    }
}
