using System;

class LastDigitsName
{
    static void Main()
    {
        Console.Write("Please enter your integer number: ");
        Console.WriteLine(GetLastDigitsName(int.Parse(Console.ReadLine())));
    }

    static string GetLastDigitsName(int number)
    {
        string[] digitsNames = 
        {
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine"
        };

        // числото може да е отрицателно и затова използвам Math.Abs();
        return digitsNames[Math.Abs(number % 10)];
    }
}

