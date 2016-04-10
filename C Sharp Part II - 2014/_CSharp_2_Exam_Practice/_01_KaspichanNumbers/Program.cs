using System;
using System.Text;

class Program
{
    static void Main()
    {
        ulong input = ulong.Parse(Console.ReadLine());
        StringBuilder reversedResult = new StringBuilder();

        do
        {
            ulong remainder = input % 256;

            if (remainder < 26)
            {
                reversedResult.Append((char)(remainder % 26 + 'A'));
            }
            else
            {
                reversedResult.AppendFormat("{1}{0}", (char)(remainder / 26 + 'a' - 1), 
                    (char)(remainder % 26 + 'A'));
            }

            input >>= 8;
        }
        while (input > 0);

        char[] result = reversedResult.ToString().ToCharArray();
        Array.Reverse(result);

        Console.WriteLine(result);
    }
}