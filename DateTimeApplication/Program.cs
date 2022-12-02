using System;
using System.Diagnostics;

namespace DateTimeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTimeModification();
            //DateTimeFormatting();
            //TimeMeasurement();
            DateTimeHelpers();
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
        static void TimeMeasurement()
        {
            Console.WriteLine("What is 2+2?");
            Console.WriteLine("A - 2");
            Console.WriteLine("B - 4");
            Console.WriteLine("C - 6");

            DateTime start = DateTime.Now;

            Stopwatch stopwatch = Stopwatch.StartNew();
            
            string userAnswer = Console.ReadLine();

            stopwatch.Stop();

            

            DateTime end = DateTime.Now;

            TimeSpan responseTime = end - start;

            Console.WriteLine($"Response took you {stopwatch.Elapsed.TotalSeconds} secound");
        }

        static void DateTimeHelpers() //check how many days we have in February
        {
            int daysInFeb2022 = DateTime.DaysInMonth(2022, 2);
            int daysInFeb2023 = DateTime.DaysInMonth(2023, 2);
            int daysInFeb2024 = DateTime.DaysInMonth(2024, 2);

            Console.WriteLine($"days in Feb 2022: {daysInFeb2022}, days in Feb 2023 {daysInFeb2023}, days in Feb 2024 {daysInFeb2024}");
        }
    }
}
