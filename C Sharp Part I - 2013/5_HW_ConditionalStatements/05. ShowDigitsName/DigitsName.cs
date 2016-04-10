using System;

class DigitsName
{
    static void Main(string[] args)
    {
        byte digit;

        Console.WriteLine("Please enter a number:");
        while (!byte.TryParse(Console.ReadLine(), out digit))
        {
            Console.WriteLine("Invalid number! Please try again..");
        }

        switch (digit)
        {
            case 0:
                Console.WriteLine("Zero");
                break;
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            case 4:
                Console.WriteLine("Four");
                break;
            case 5:
                Console.WriteLine("Five");
                break;
            case 6:
                Console.WriteLine("Six");
                break;
            case 7:
                Console.WriteLine("Seven");
                break;
            case 8:
                Console.WriteLine("Eight");
                break;
            case 9:
                Console.WriteLine("Nine");
                break;
            default:
                Console.WriteLine("This is not a digit.");
                break;
        }
    }

}

