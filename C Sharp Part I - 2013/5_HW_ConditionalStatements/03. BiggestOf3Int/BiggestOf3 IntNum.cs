using System;

class BiggestOf3IntNum
{
    static int firstVar, secondVar, thirdVar;

    static void Main(string[] args)
    {
        int biggest = 0;

        Console.WriteLine("Please enter an integer number 1:");
        Validate(ref firstVar);

        Console.WriteLine("Please enter an integer number 2:");
        Validate(ref secondVar);

        Console.WriteLine("Please enter an integer number 3:");
        Validate(ref thirdVar);

        if (firstVar > secondVar)
        {
            biggest = firstVar;

            if (thirdVar > biggest)
            {
                biggest = thirdVar;
            }
        }
        else
        {
            biggest = secondVar;

            if (thirdVar > biggest)
            {
                biggest = thirdVar;
            }
        }

        Console.WriteLine("The biggest number is {0}", biggest);

        
    }

    static void Validate(ref int someVar)
    {
        while (!int.TryParse(Console.ReadLine(), out someVar))
        {
            Console.WriteLine("Invalid number! Please try again..");
        }
    }
}

