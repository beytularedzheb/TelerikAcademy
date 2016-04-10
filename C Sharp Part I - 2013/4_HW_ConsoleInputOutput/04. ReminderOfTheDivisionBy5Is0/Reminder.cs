using System;

class Reminder
{
    static uint firstVar;
    static uint secondVar;

    static void Main(string[] args)
    {
        Console.Write("Please enter first positive integer number: ");
        Validate(ref firstVar);

        Console.Write("Please enter second positive integer number: ");
        Validate(ref secondVar);

        if (firstVar > secondVar)
        {
            uint swap = firstVar;
            firstVar = secondVar;
            secondVar = swap;
        }

        uint result = Find(firstVar, secondVar);

        Console.WriteLine("-Result -> p({0}, {1}) = {2}", firstVar, secondVar, result);
    }

    static uint Find(uint fVar, uint sVar)
    {
        uint counter = 0;

        for (uint i = fVar; i <= sVar; i++)
        {
            if (i % 5 == 0)
                counter++;
        }

        return counter;
    }

    static void Validate(ref uint someVar)
    {
        do
        {
            if (uint.TryParse(Console.ReadLine(), out someVar))
            {
                if (someVar > 0)
                    break;
                else
                    Console.WriteLine("Invalid number.. Please try again... ");
            }
            else
            {
                Console.WriteLine("Invalid number.. Please try again... ");
            }
        }
        while (someVar <= 0);
    }
}
