using System;

/*
 * Write a program that reads from the console a sequence of 
 * N integer numbers and returns the minimal and maximal of them.
 */

class MinAndMax
{
    static void Main(string[] args)
    {
        uint n;

        Console.WriteLine("Please enter a positive integer number N > 0: ");

        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        int[] arNum = new int[n];

        Console.WriteLine("Plase enter your n integer numbers:");

        for (uint i = 0; i < n; i++)
        {
            while (!int.TryParse(Console.ReadLine(), out arNum[i]))
            {
                Console.WriteLine("Invalid number.. Please try again..");
            }            
        }

        int min = int.MaxValue;
        int max = int.MinValue;

        for (uint i = 0; i < n; i++)
        {
            if (max < arNum[i])
            {
                max = arNum[i];
            }

            if (min > arNum[i])
            {
                min = arNum[i];
            }
        }

        Console.WriteLine("Max = {0}  |  Min = {1}", max, min);
    }
}

