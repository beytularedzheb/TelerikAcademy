using System;

class ConvertFromAnyToAnyNumeralSystem
{
    static void Main()
    {
        byte fromBase, toBase;

        do
        {
            Console.WriteLine("From base: ");
        }
        while (!byte.TryParse(Console.ReadLine(), out fromBase) || fromBase < 2 || fromBase > 16);

        do
        {
            Console.WriteLine("To base: ");
        }
        while (!byte.TryParse(Console.ReadLine(), out toBase) || toBase < 2 || toBase > 16);

        Console.WriteLine("Number: ");
        string number = Console.ReadLine();

        // ако има малки букви - конвертират се до големи
        number = ToUpperCharsInNum(number);

        // проверка дали числото е в зададената бройна система
        if (IsNumberInThisBase(number, fromBase))
        {
            Console.WriteLine(ConvertNumberFromAnyToAnyNumSystem(number, fromBase, toBase));
        }
        else
        {
            Console.WriteLine("This is not ({0}) number!", fromBase);
        }
    }

    static string ConvertNumberFromAnyToAnyNumSystem(string number, byte fromBase, byte toBase)
    {
        string result = "";

        // конвертиране на числото в 10 бройна система
        result = ToDec(number, fromBase);

        // конвертиране на числото от 10 бройна система в желаната бройна система
        result = DecTo(uint.Parse(result), toBase);
        return result;
    }

    static string ToDec(string number, byte numBase)
    {
        ulong decNum = 0;

        for (int i = number.Length - 1; i > -1; i--)
        {
            if (number[i] >= 'A' && number[i] <= 'F')
            {
                decNum += (ulong)(((number[i] - 'A') + 10) * Math.Pow(numBase, number.Length - i - 1));
            }
            else
            {
                decNum += (ulong)(((number[i] - '0')) * Math.Pow(numBase, number.Length - i - 1));
            }
        }

        return decNum.ToString();
    }

    static string DecTo(uint decNum, byte numBase)
    {
        string strNum = "";

        char[] HexABC = { 'A', 'B', 'C', 'D', 'E', 'F' };

        do
        {
            byte remainder = (byte)(decNum % numBase);
            if (remainder > 9)
            {
                strNum = HexABC[remainder - 10] + strNum;
            }
            else
            {
                strNum = remainder + strNum;
            }
            decNum /= numBase;
        }
        while (decNum > 0);

        return strNum;
    }

    static bool IsNumberInThisBase(string strNum, byte numBase)
    {
        char[] inDigits = 
        { 
            '0', '1', '2', '3', '4', '5',
            '6', '7', '8', '9',
            'A', 'B', 'C', 'D', 'E', 'F' 
        };

        for (int i = 0; i < strNum.Length; i++)
        {
            if (strNum[i] < '0' || strNum[i] > inDigits[numBase - 1])
            {
                return false;
            }
        }

        return true;
    }

    static string ToUpperCharsInNum(string strNum)
    {
        string result = "";

        for (int i = 0; i < strNum.Length; i++)
        {
            result += Char.ToUpper(strNum[i]);
        }

        return result;
    }
}

