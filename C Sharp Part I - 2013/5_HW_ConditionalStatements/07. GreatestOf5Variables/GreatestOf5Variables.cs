using System;

class GreatestOf5Variables
{
    static double[] arrayNumbers = new double[5];

    static void Main(string[] args)
    {
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            Console.WriteLine("Please enter a number {0}", i + 1);
            Validate(ref arrayNumbers[i]);
        }

        double maxVar = Double.MinValue;

        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            if (maxVar < arrayNumbers[i])
            {
                maxVar = arrayNumbers[i];
            }
        }

        Console.WriteLine("The greatest variable is {0}", maxVar);
    }

    static void Validate(ref double someVar)
    {
        while (!double.TryParse(Console.ReadLine(), out someVar))
        {
            Console.WriteLine("Invalid number! Please try again..");
        }
    }
}

