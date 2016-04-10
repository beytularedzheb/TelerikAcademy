using System;

namespace _11.ExtractTheValueOfBitX
{
    class ExtractBit
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter an integer number: ");
                int intVar = int.Parse(Console.ReadLine());

                Console.WriteLine(intVar + "  =>  " + Convert.ToString(intVar, 2).PadLeft(32, '0'));

                sbyte pos;

                do
                {
                    Console.Write("Please enter the bit's number (0 - 31): ");
                    pos = sbyte.Parse(Console.ReadLine());
                }
                while (pos > 31 || pos < 0);

                int mask = 1 << pos;

                Console.WriteLine("-Value = {0}.", (intVar & mask) / mask);
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
