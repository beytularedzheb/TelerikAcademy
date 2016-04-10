using System;

class Factoriel
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number: ");
        byte number = byte.Parse(Console.ReadLine());
        Console.WriteLine(CalcFactoriel(number));
    }

    static string CalcFactoriel(int number)
    {
        string result = "1";
        for (int i = 1; i <= number; i++)
        {
            result = MultipliesBigIntNumber(result, i);
        }
        return result;
    }

    static string MultipliesBigIntNumber(string firstNum, int secondNum)
    {
        string result = firstNum;

        for (int i = 1; i < secondNum; i++)
        {
            result = SumBigIntNumbers(result, firstNum);
        }
        return result;
    }

    // използвам метода от 8 задача
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

