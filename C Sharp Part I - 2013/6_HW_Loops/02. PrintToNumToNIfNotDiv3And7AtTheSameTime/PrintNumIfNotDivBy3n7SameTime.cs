using System;


/*
 * Write a program that prints all the numbers from 1 to N, 
 * that are not divisible by 3 and 7 at the same time.
 */

class PrintNumIfNotDivBy3n7SameTime
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
            if (i % 3 != 0 || i % 7 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}

