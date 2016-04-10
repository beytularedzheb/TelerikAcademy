using System;

class ShowBinaryRepresentationOfShort
{
    static void Main()
    {
        short number;

        do
        {
            Console.Write("Number: ");
        }
        while (!short.TryParse(Console.ReadLine(), out number));
        
        Console.WriteLine(ConvertShortNumberToBinary(number));
    }

    static string ConvertShortNumberToBinary(short number)
    {
        string result = "";

        for (int i = 15; i > -1; i--)
        {
            result += (number & (1 << i)) != 0 ? 1 : 0;
        }

        return result;
    }
}
