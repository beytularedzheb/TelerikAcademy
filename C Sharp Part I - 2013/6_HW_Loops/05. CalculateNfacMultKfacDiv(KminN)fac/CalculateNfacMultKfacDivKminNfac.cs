using System;
using System.Numerics;

/*
 * Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
 */

class CalculateNfacMultKfacDivKminNfac
{
    static uint n;
    static uint k;

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a positive integer number N > 1: ");

        while (!uint.TryParse(Console.ReadLine(), out n) || n < 2)
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }
         
        Console.WriteLine("Please enter a positive integer number K (1 < N < K)");

        while (!uint.TryParse(Console.ReadLine(), out k) || k < 2 || k <= n)
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        BigInteger nFact = CalculateFactorial(n);
        BigInteger kFact = CalculateFactorial(k);
        BigInteger kMinNFac = CalculateFactorial(k - n);

        Console.WriteLine("{0}! * {1}! / ({1} - {0})! = {2:N}", n, k, (nFact * kFact) / kMinNFac);
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

