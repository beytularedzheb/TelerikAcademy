using System;

class ConvertHexadecimalToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a hexadecimal number: ");
        string strHexNumber = Console.ReadLine();
        strHexNumber = ToUpperCharsInNum(strHexNumber);

        if (IsHexadecimalNumber(strHexNumber))
        {
            Console.WriteLine(HexToDec(strHexNumber));
        }
        else
        {
            Console.WriteLine("This is not hexadecimal number!");
        }
    }

    static string HexToDec(string hexNum)
    {
        ulong decNum = 0;

        for (int i = hexNum.Length - 1; i > -1; i--)
        {
            if (hexNum[i] >= 'A' && hexNum[i] <= 'F')
            {
                decNum += (ulong)(((hexNum[i] - 'A') + 10) * Math.Pow(16, hexNum.Length - i - 1));
            }
            else
            {
                decNum += (ulong)(((hexNum[i] - '0')) * Math.Pow(16, hexNum.Length - i - 1));
            }
        }

        return decNum.ToString();
    }

    static bool IsHexadecimalNumber(string hexNum)
    {
        for (int i = 0; i < hexNum.Length; i++)
        {
            if ((hexNum[i] < '0' || hexNum[i] > '9') && (hexNum[i] < 'A' || hexNum[i] > 'F'))
            {
                return false;
            }
        }

        return true;
    }

    static string ToUpperCharsInNum(string hexNum)
    {
        string result = "";

        for (int i = 0; i < hexNum.Length; i++)
        {
            result += Char.ToUpper(hexNum[i]);
        }

        return result;
    }
}

