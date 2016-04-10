using System;

/*
 * Write a program that prints all the numbers from 1 to N.
 */

class PrintAllNumFrom1ToN
{
    static void Main(string[] args)
    {
        uint n;

        Console.WriteLine("Please enter a positive integer number N > 0: ");

        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        Console.WriteLine();

        for (uint i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}

