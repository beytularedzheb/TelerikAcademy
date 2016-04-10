using System;

class ThreeIntSum
{
    static void Main(string[] args)
    {
        int firstVar;
        int secondVar;
        int thirdVar;

        string msgParseError = "This is not an integer!";

        Console.Write("Please enter first integer number: ");
        if (int.TryParse(Console.ReadLine(), out firstVar))
        {
            Console.Write("Please enter second integer number: ");
            if (int.TryParse(Console.ReadLine(), out secondVar))
            {
                Console.Write("Please enter third integer number: ");
                if (int.TryParse(Console.ReadLine(), out thirdVar))
                {
                    // Сумата е от тип long, защото резултатът може да е int 
                    // или long (ако числата са достатъчно големи).

                    long sum = firstVar + secondVar + thirdVar;
                    Console.WriteLine("{0} + {1} + {2} = {3}", firstVar, secondVar, thirdVar, sum);
                }
                else
                {
                    Console.WriteLine(msgParseError);
                }
            }
            else
            {
                Console.WriteLine(msgParseError);
            }
        }
        else
        {
            Console.WriteLine(msgParseError);
        }
    }
}

