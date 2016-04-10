using System;

class ConvertBinaryToDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter a binary number: ");
        string strBinNumber = Console.ReadLine();

        if (IsBinaryNumber(strBinNumber))
        {
            Console.WriteLine(BinToDec(strBinNumber));
        }
        else
        {
            Console.WriteLine("This is not binary number!");
        }
    }

    // работи само с положителни двоични числа
    static string BinToDec(string binNumber)
    {
        ulong decNumber = 0;

        for (int i = 0; i < binNumber.Length; i++)
        {
            decNumber += (ulong)((binNumber[binNumber.Length - i - 1] - '0') * Math.Pow(2, i));
        }

        return decNumber.ToString();
    }

    static bool IsBinaryNumber(string binNumber)
    {
        for (int i = 0; i < binNumber.Length; i++)
        {
            if (binNumber[i] != '0' && binNumber[i] != '1')
            {
                return false;
            }
        }
        return true;
    }
}

