using System;
using System.Numerics;

/*
 * Write a program to calculate the Nth Catalan number by given N.
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

        CatalanNum(n);
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
