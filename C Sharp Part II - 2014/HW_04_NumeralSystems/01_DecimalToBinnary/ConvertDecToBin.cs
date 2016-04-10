using System;

class ConvertDecToBin
{
    static void Main()
    {
        Console.Write("Please enter a decimal integer number: ");
        int decNum = int.Parse(Console.ReadLine());

        Console.WriteLine(DecToBin(decNum));
    }

    static string DecToBin(int decNumber)
    {
        string strBinNumber = "";
        bool isNegative = false;
        // проверка дали числото е отрицателно
        if (decNumber < 0)
        {
            decNumber += int.MaxValue;
            decNumber++;
            isNegative = true;
        }

        do
        {
            strBinNumber = (decNumber & 1) + strBinNumber;
            decNumber >>= 1;
        }
        while (decNumber > 0);

        if (isNegative)
        {
            strBinNumber = strBinNumber.PadLeft(32, '1');
        }

        return strBinNumber;
    }
}