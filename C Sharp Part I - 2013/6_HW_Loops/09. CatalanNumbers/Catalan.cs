using System;
using System.Numerics;

/*
 * Реших да отпечатвам всички каталанови числа до n, т.к.
 * в 10-та задача се иска отпечатването само на n-тото
 * каталаново число..
 */

class Catalan
{
    static void Main(string[] args)
    {
        uint n;

        Console.WriteLine("Please enter an integer number N >= 0");

        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid number. Try again...");
        }

        for (uint i = 0; i <= n; i++)
        {
            CatalanNum(i);  
        }
    }

    static void CatalanNum(uint n)
    {
        BigInteger numerator, denumerator;

        numerator = CalculateFactorial(2 * n);
        denumerator = CalculateFactorial(n + 1) * CalculateFactorial(n);

        Console.WriteLine("Cn = {0}", numerator / denumerator);
    }

    static BigInteger CalculateFactorial(uint num)
    {
        BigInteger result = 1;

        for (uint i = num; i > 0; i--)
        {
            result *= i;
        }

        return result;
    }
}
