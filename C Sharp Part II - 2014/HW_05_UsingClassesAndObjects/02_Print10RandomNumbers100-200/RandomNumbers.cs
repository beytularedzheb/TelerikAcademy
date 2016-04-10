using System;

public class RandomNumbers
{
    private static void Main()
    {
        Random rndGen = new Random();
        PrintRandomNumbers(rndGen, 10, 100, 200);
    }

    private static void PrintRandomNumbers(Random rndGen, int count, int start, int end)
    {
        for (int i = 0; i < count; i++)
        {  
            Console.WriteLine(rndGen.Next(start, end));
        }
    }
}