using System;

class MyBigInteger
{
    static void Main()
    {
        // по-условие на задача се иска използването на масиви, т.к string-ът
        // всъщност е масив от char-ове, избрах числата да са от тип string
        Console.WriteLine("Please enter first positive integer number: ");
        string firstBigNum = Console.ReadLine();
        Console.WriteLine("Please enter second positive integer number: ");
        string secondBigNum = Console.ReadLine();

        Console.WriteLine(SumBigIntNumbers(firstBigNum, secondBigNum));
    }

    static string SumBigIntNumbers(string firstNum, string secondNum)
    {
        string result = "";
        int buffer, carry = 0;
        if (firstNum.Length < secondNum.Length)
        {
            string swap = firstNum;
            firstNum = secondNum;
            secondNum = swap;
        }
        int j = secondNum.Length - 1;

        for (int i = firstNum.Length - 1; i >= 0; i--)
        {
            if (j > -1)
            {
                buffer = CharToInt(firstNum[i]) + CharToInt(secondNum[j]) + carry;
                j--;
            }
            else
            {
                buffer = CharToInt(firstNum[i]) + carry;
            }
            carry = (buffer > 9) ? 1 : 0;
            result = (buffer % 10) + result; 
        }
        if (carry > 0)
        {
            result = carry + result;
        }

        return result;
    }

    static int CharToInt(char ch)
    {
        return ch - '0';
    }
}

