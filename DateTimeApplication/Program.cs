using System;

namespace DateTimeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTimeModification();
            DateTimeFormatting();
        }

        static void DateTimeModification()
        {
            DateTime now = DateTime.Now;
            DateTime openDate = new DateTime(1982, 2, 21);

            TimeSpan result = now - openDate;

            Console.WriteLine(result.Days);
            Console.WriteLine(result.TotalSeconds);

            DateTime expireDate = now.AddDays(22);

            Console.WriteLine(expireDate);
        }
        static void DateTimeFormatting()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToString("g"));
            Console.WriteLine(now.ToString("G"));
            Console.WriteLine(now.ToString("yyyy-MM-dd")); //
        }
    }
}
