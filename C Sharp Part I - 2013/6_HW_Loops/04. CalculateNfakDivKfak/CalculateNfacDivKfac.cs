using System;
using System.Numerics;

/*
 * Write a program that calculates N!/K! for given N and K (1<K<N).
 */

class CalculateNfacDivKfac
{
    static void Main(string[] args)
    {
        uint n, k;

        Console.WriteLine("Please enter a positive integer number N > 1: ");

        while (!uint.TryParse(Console.ReadLine(), out n) || n < 2)
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        Console.WriteLine("Please enter a positive integer number K (1 < K < N): ");

        while (!uint.TryParse(Console.ReadLine(), out k) || k < 2 || k >= n)
        {
            Console.WriteLine("Invalid number (1 < K < N).. Please try again..");
        }

        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;

        for (uint i = n; i > 0; i--)
        {
            nFactorial *= i;
        }

        for (uint i = k; i > 0; i--)
        {
            kFactorial *= i;
        }

        Console.WriteLine("{0}! / {1}! = {2:N}", n, k, nFactorial / kFactorial);
    }
}

