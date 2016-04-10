using System;

class Sort3RealInDesc
{
    static double firstVar, secondVar, thirdVar;

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number 1:");
        Validate(ref firstVar);

        Console.WriteLine("Please enter a number 2:");
        Validate(ref secondVar);

        Console.WriteLine("Please enter a number 3:");
        Validate(ref thirdVar);

        Console.WriteLine("Sorted in descendin order:");

        if (firstVar >= secondVar)
        {
            if (firstVar >= thirdVar)
            {
                Console.WriteLine(firstVar);
                if (secondVar >= thirdVar)
                {
                    Console.WriteLine(secondVar);
                    Console.WriteLine(thirdVar);
                }
                else
                {
                    Console.WriteLine(thirdVar);
                    Console.WriteLine(secondVar);
                }
            }
            else
            {
                Console.WriteLine(thirdVar);
                if (secondVar >= firstVar)
                {
                    Console.WriteLine(secondVar);
                    Console.WriteLine(firstVar);
                }
                else
                {
                    Console.WriteLine(firstVar);
                    Console.WriteLine(secondVar);
                }
            }
        }
        else
        {
            if (secondVar >= thirdVar)
            {
                Console.WriteLine(secondVar);
                if (firstVar >= thirdVar)
                {
                    Console.WriteLine(firstVar);
                    Console.WriteLine(thirdVar);
                }
                else
                {
                    Console.WriteLine(thirdVar);
                    Console.WriteLine(firstVar);
                }
            }
            else
            {
                Console.WriteLine(thirdVar);
                if (secondVar >= firstVar)
                {
                    Console.WriteLine(secondVar);
                    Console.WriteLine(firstVar);
                }
                else
                {
                    Console.WriteLine(firstVar);
                    Console.WriteLine(secondVar);
                }
            }
        }  
    }

    static void Validate(ref double someVar)
    {
        while (!double.TryParse(Console.ReadLine(), out someVar))
        {
            Console.WriteLine("Invalid number! Please try again..");
        }
    }
}

