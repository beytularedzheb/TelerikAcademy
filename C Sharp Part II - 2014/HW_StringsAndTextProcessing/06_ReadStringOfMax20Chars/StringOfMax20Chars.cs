using System;
using System.Text;

class StringOfMax20Chars
{
    static void Main()
    {
        string str = ReadString(20);

        if (str != null && str.Length < 20)
        {
            str = str.PadRight(20, '*');
        }

        Console.WriteLine(str);
    }

    static string ReadString(byte limit)
    {
        StringBuilder str = new StringBuilder(limit);
        while (true)
        {
            char c = Console.ReadKey(true).KeyChar;
            if (c == '\r' || c == '\n')
            {
                Console.WriteLine();
                break;
            }

            if (str.Length < limit)
            {
                Console.Write(c);
                str.Append(c);
            }
        }

        return str.ToString();
    }
}