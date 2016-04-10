using System;

class Program
{
    static void Main()
    {
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        DateTime secondDate = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Days: {0}", Math.Abs((firstDate - secondDate).TotalDays));
    }
}