using System;

class ConvertHexadecimalToBinaryDirectly
{
    static void Main()
    {
        Console.WriteLine("Please enter a hexadecimal number: ");
        string strHexNumber = Console.ReadLine();

        if (IsHexadecimalNumber(strHexNumber))
        {
            Console.WriteLine(HexToDecDirectly(strHexNumber));
        }
        else
        {
            Console.WriteLine("This is not hexadecimal number!");
        }
    }

    static bool IsHexadecimalNumber(string hexNum)
    {
        for (int i = 0; i < hexNum.Length; i++)
        {
            if ((hexNum[i] < '0' || hexNum[i] > '9') && 
                (Char.ToUpper(hexNum[i]) < 'A' || Char.ToUpper(hexNum[i]) > 'F'))
            {
                return false;
            }
        }

        return true;
    }

    static string HexToDecDirectly(string hexNum)
    {
        return Convert.ToString(Convert.ToInt64(hexNum, 16), 2);
    }
}

