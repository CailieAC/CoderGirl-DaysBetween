using System;

namespace DaysBetween
{
    public static class Program
    {
        public static void Main()
        {
            // TODO:  Get two dates from the user.
            Console.Write("Enter first date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            double numberOfDaysBetween = DaysBetween(firstDate, secondDate);

            Console.WriteLine(numberOfDaysBetween);
            Console.ReadLine();
        }

        // TODO: Create that has a method that counts the number of days between two different dates.
        public static double DaysBetween(DateTime firstDate, DateTime secondDate)
        {
            TimeSpan numberOfDaysBetween = secondDate.Subtract(firstDate);
            double timeSpan = numberOfDaysBetween.TotalDays;
            if (timeSpan < 0)
                timeSpan = timeSpan * -1;
            return timeSpan;
        }
    }
}
