using System;
using System.Numerics;

class TrailingZeros
{
    static void Main(string[] args)
    {
        uint n, counter = 0;

        Console.WriteLine("Please enter a positive integer number:");

        while (!uint.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Invalid number.. Try again..");
        }

        for (uint i = 5; i <= n; i *= 5)
        {
            counter += (n / i);
        }

        Console.WriteLine("Trailing zeros of {0}! = {1}", n, counter);
        Console.WriteLine("{0}! = {1}", n, CalculateFactorial(n));
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

