using System;
using System.Numerics;
using System.Text;

class Program
{
    static void Main()
    {
        int i = 1;
        string input = Console.ReadLine();
        StringBuilder cur = new StringBuilder(input.Length);
        cur.Append(input[0]);
        StringBuilder result = new StringBuilder(input.Length);

        do
        {
            cur.Append(input[i]);

            switch (cur.ToString())
            {
                case "-!":
                    result.Append(0);
                    cur.Clear();
                    break;
                case "**":
                    result.Append(1);
                    cur.Clear();
                    break;
                case "!!!":
                    result.Append(2);
                    cur.Clear();
                    break;
                case "&&":
                    result.Append(3);
                    cur.Clear();
                    break;
                case "&-":
                    result.Append(4);
                    cur.Clear();
                    break;
                case "!-":
                    result.Append(5);
                    cur.Clear();
                    break;
                case "*!!!":
                    result.Append(6);
                    cur.Clear();
                    break;
                case "&*!":
                    result.Append(7);
                    cur.Clear();
                    break;
                case "!!**!-":
                    result.Append(8);
                    cur.Clear();
                    break;
            }

            i++;
        }
        while (i < input.Length);

        BigInteger decimalResult = 0;
        BigInteger mul = 1;

        for (i = result.Length - 1; i > -1 ; i--)
        {
            if (result[i] != '0')
            {
                decimalResult += (result[i] - '0') * mul;
            }

            mul *= 9;
        }

        Console.WriteLine(decimalResult);
    }
}