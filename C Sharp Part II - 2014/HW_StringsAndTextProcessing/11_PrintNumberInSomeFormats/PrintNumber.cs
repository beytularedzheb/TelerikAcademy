using System;

class PrintNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:d}", number);
        Console.WriteLine("{0,15:x}", number);
        Console.WriteLine("{0,15:p}", number);
        Console.WriteLine("{0,15:e}", number);
    }
}