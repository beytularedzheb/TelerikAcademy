using System;

class CalculateSumWithAccuracyX
{
    static void Main(string[] args)
    {
        double sum = 1;
        uint n;
        Console.Write("Please enter a positive integer number: ");

        while (!uint.TryParse(Console.ReadLine(), out n) || n == 0)
        {
            Console.WriteLine("Invalid number.. Try again...");
        }

        for (int i = 2; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                sum += Math.Round(1.0 / i, 3);
            }
            else
            {
                sum -= Math.Round(1.0 / i, 3);
            }
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}
