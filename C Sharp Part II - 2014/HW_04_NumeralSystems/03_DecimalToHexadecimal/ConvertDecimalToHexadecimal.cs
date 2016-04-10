using System;


class ConvertDecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("Please enter a decimal integer number: ");
        uint decNum = uint.Parse(Console.ReadLine());

        Console.WriteLine(DecToHex(decNum));
    }

    static string DecToHex(uint decNum)
    {
        string strHexNum = "";

        char[] HexABC = { 'A', 'B', 'C', 'D', 'E', 'F' };

        do
        {
            byte remainder = (byte)(decNum & 15);
            if (remainder > 9)
            {
                strHexNum = HexABC[remainder - 10] + strHexNum;
            }
            else
            {
                strHexNum = remainder + strHexNum;
            }
            decNum >>= 4;
        }
        while (decNum > 0);

        return strHexNum;
    }
}

