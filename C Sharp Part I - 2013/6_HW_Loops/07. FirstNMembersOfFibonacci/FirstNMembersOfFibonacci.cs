using System;
using System.Numerics;

/*
 * Write a program that reads a number N and calculates the sum of the first N 
 * members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
 */

class FirstNMembersOfFibonacci
{
    static void Main(string[] args)
    {
        uint n;

        Console.WriteLine("Please enter a positive integer number N: ");

        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        Fibonacci(n);
    }

    static void Fibonacci(uint n)
    {
        BigInteger first = 0; 
        BigInteger second = 1;
        BigInteger sum = 0;

        for (uint i = 0; i < n; i++)
        {
            if (i == 0)
            {
                Console.WriteLine("[{0}] {1}", i + 1, i);
            }
            else if (i == 1)
            {
                Console.WriteLine("[{0}] {1}", i + 1, i);  
            }
            else
            {
                sum = first + second;
                first = second;
                second = sum;

                Console.WriteLine("[{0}] {1}", i + 1, sum);
            }
        }
    }
}

