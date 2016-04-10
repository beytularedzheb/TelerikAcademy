using System;


class ShowSign
{
    static double firstVar, secondVar, thirdVar;

    static void Main(string[] args)
    {
        int signSum = 0;

        Console.WriteLine("Please enter a number 1:");
        Validate(ref firstVar);

        Console.WriteLine("Please enter a number 2:");
        Validate(ref secondVar);

        Console.WriteLine("Please enter a number 3:");
        Validate(ref thirdVar);

        if (firstVar == 0 || secondVar == 0 || thirdVar == 0)
        {
            Console.WriteLine("The product is zero");
        }
        else
        {

            if (firstVar < 0)
            {
                signSum++;
            }

            if (secondVar < 0)
            {
                signSum++;
            }

            if (thirdVar < 0)
            {
                signSum++;
            }

            if (signSum % 2 == 0)
            {
                Console.WriteLine("The sign of the product is + ");
            }
            else
            {
                Console.WriteLine("The sign of the product is - ");
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

