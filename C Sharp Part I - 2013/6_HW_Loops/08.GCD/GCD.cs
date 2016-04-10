using System;

/*
 * Write a program that calculates GCD of given two numbers.
 * Use the Euclidean algorithm (find it in Internet).
 */

class GCD
{
    static void Main(string[] args)
    {
        int firstNum;
        int secondNum;

        Console.WriteLine("Please enter first integer number: ");

        while (!int.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        Console.WriteLine("Please enter second integer number: ");

        while (!int.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.WriteLine("Invalid number.. Please try again..");
        }

        Console.WriteLine("The greatest common divisor of {0} and {1} is {2}.", 
            firstNum, secondNum, gcd(firstNum, secondNum));
    }

    static int gcd(int x, int y)
    {
        if (y == 0)
            return x;
        else
            return gcd(y, x % y);
    }
}

