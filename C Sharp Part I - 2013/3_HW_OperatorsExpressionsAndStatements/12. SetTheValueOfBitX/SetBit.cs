using System;

namespace _12.SetTheValueOfBitX
{
    class SetBit
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

                sbyte value;

                do
                {
                    Console.Write("Please enter the value (0 or 1): ");
                    value = sbyte.Parse(Console.ReadLine());
                }
                while (value > 1 || value < 0);

                int mask = 1 << pos;

                intVar = value == 0 ? intVar & ~mask : intVar | mask;

                Console.WriteLine(Convert.ToString(intVar, 2).PadLeft(32, '0'));
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
