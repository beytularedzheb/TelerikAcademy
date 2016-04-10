using System;

class BinaryRepresentationOfFloat
{
    static void Main()
    {
        float floatNumber;

        do
        {
            Console.Write("Floating-point number: ");
        }
        while (!float.TryParse(Console.ReadLine(), out floatNumber));

        ShowFloatNumberInBinary(floatNumber);
    }

    static void ShowFloatNumberInBinary(float s)
    {
        string strNum = "";
        string exponent = "";
        string mantissa = "";
        char sign = ' ';

        byte[] number = BitConverter.GetBytes(s);

        for (int i = number.Length - 1; i > -1; i--)
        {
            strNum += Convert.ToString(number[i], 2).PadLeft(8, '0');
        }

        sign = Convert.ToChar(strNum.Substring(0, 1));
        exponent = strNum.Substring(1, 8);
        mantissa = strNum.Substring(9, 23);

        Console.WriteLine("Sign: {0}", sign);
        Console.WriteLine("Exponent: {0}", exponent);
        Console.WriteLine("Mantissa: {0}", mantissa);
    }
}

