using System;

class Scores
{
    static void Main(string[] args)
    {
        uint score;

        Console.WriteLine("Please enter a number (1..9):");
        while (!uint.TryParse(Console.ReadLine(), out score))
        {
            Console.WriteLine("Invalid number. Try again...");
        }

        switch (score)
        {
            case 1:
                score *= 10;
                Console.WriteLine("Score: {0}", score);
                break;
            case 2:
                goto case 1;
            case 3:
                goto case 1;
            case 4:
                score *= 100;
                Console.WriteLine("Score: {0}", score);
                break;
            case 5:
                goto case 4;
            case 6:
                goto case 4;
            case 7:
                score *= 1000;
                Console.WriteLine("Score: {0}", score);
                break;
            case 8:
                goto case 7;
            case 9:
                goto case 7;
            default:
                Console.WriteLine("Invalid number!");
                break;
        }
    }
}

