using System;
using System.Globalization;
using System.Threading;

public class Workdays
{
    private static readonly Holiday[] HoliDays = 
    {
        new Holiday() { Month = 1, Day = 1 },    // нова година
        new Holiday() { Month = 1, Day = 2 },
        new Holiday() { Month = 3, Day = 3 },    // Ден на Освобождението
        new Holiday() { Month = 5, Day = 1 },    // Ден на труда
        new Holiday() { Month = 5, Day = 6 },    // Гергьовден
        new Holiday() { Month = 5, Day = 24 },   // Ден на азбуката, културата и просветата
        new Holiday() { Month = 9, Day = 6 },    // Ден на съединението
        new Holiday() { Month = 9, Day = 22 },   // Ден на независимостта
        new Holiday() { Month = 11, Day = 1 },   // Ден на народните будители
        new Holiday() { Month = 12, Day = 24 },  // Бъдни вечер
        new Holiday() { Month = 12, Day = 25 },  // Коледа
        new Holiday() { Month = 12, Day = 26 }, 
    };

    private static DateTime ReadDate()
    {
        Console.Write("Year: ");
        ushort year = ushort.Parse(Console.ReadLine());

        Console.Write("Month: ");
        byte month = byte.Parse(Console.ReadLine());

        Console.Write("Day: ");
        byte day = byte.Parse(Console.ReadLine());

        return new DateTime(year, month, day);
    }

    private static int NumberOfWorkdaysBetween(DateTime today, DateTime endDate)
    {
        bool isHoliday = false;
        int counter = 0;

        for (DateTime date = today.Date; date <= endDate.Date; date = date.AddDays(1))
        {
            if (date.DayOfWeek.ToString() != "Saturday" && date.DayOfWeek.ToString() != "Sunday")
            {
                for (int i = 0; i < HoliDays.Length; i++)
                {
                    if (date.Day == HoliDays[i].Day && date.Month == HoliDays[i].Month)
                    {
                        isHoliday = true;
                        break;
                    }
                }

                if (!isHoliday)
                {
                    counter++;
                }
            }

            isHoliday = false;
        }

        return counter;
    }

    private static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        try
        {
            DateTime date = ReadDate();
            int numOfWorkdays;

            // може да се задава и задна дата
            if (DateTime.Today.Date > date.Date)
            {
                numOfWorkdays = NumberOfWorkdaysBetween(date, DateTime.Today);
                Console.WriteLine("The number of workdays between {0} and {1} is:", date, DateTime.Today);
            }
            else
            {
                numOfWorkdays = NumberOfWorkdaysBetween(DateTime.Today, date);
                Console.WriteLine("The number of workdays between {0} and {1} is:", DateTime.Today, date);
            }

            Console.WriteLine(numOfWorkdays);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private struct Holiday
    {
        public byte Day;
        public byte Month;
    }
}