using System;

class ConvertBinaryToHexadecimalDirectly
{
    static void Main()
    {
        Console.WriteLine("Please enter a binary number: ");
        string strBinNumber = Console.ReadLine();

        if (IsBinaryNumber(strBinNumber))
        {
            Console.WriteLine(BinToDecDirectly(strBinNumber));
        }
        else
        {
            Console.WriteLine("This is not binary number!");
        }
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

    static string BinToDecDirectly(string binNum)
    {
        return Convert.ToString(Convert.ToInt64(binNum, 2), 16);
    }
}

