using System;
using System.Globalization;

class DateTimeBulgaria
{
    static void Main()
    {
        DateTime dateAndTime = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
        dateAndTime = dateAndTime.AddHours(6.50d);
        Console.WriteLine("{0} {1}", dateAndTime.ToString("dddd", new CultureInfo("BG")), dateAndTime);
    }
}