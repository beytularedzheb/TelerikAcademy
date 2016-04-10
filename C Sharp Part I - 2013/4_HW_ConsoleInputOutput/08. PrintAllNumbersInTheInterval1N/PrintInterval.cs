using System;

class PrintInterval
{
    static void Main(string[] args)
    {
        uint n;

        Console.Write("Please enter N: ");

        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.WriteLine("Invalid number.. Try again...");
        }

        Console.WriteLine("Interval [1..{0}]", n);

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);   
        }
    }
}

