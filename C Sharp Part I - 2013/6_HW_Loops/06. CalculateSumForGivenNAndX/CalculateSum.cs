using System;
using System.Numerics;

/*
 * Write a program that, for a given two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
 */


class CalculateSum
{
    static uint n;
    static int x;

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive integer number N > 0: ");

        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        Console.WriteLine("Please enter an integer number X:");

        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        Console.WriteLine("Sum = {0:N}", CalculateSums(x, n));
    }

    static ulong CalculateFactorial(uint num)
    {
        ulong result = 1;

        for (uint i = num; i > 0; i--)
        {
            result *= i;
        }

        return result;
    }

    static double CalculateSums(int numX, uint nNum)
    {
        double sum = 1;
        
        for (uint i = 1; i <= nNum; i++)
        {
            sum += CalculateFactorial(i) / Math.Pow(numX, i);   
        }

        return sum;
    }
}

