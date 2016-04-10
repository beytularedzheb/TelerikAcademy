using System;

namespace _13.ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter an unsigned integer number: ");
                uint uintVar = uint.Parse(Console.ReadLine());

                byte pos1 = 3;
                byte pos2 = 24;
                uint value1, value2, mask;

                Console.WriteLine( Convert.ToString(uintVar, 2).PadLeft(32, '0'));

                while (pos1 <= 5)
                {
                    mask = (uint)(1 << pos1);
                    value1 = (uintVar & mask) / mask;

                    mask = (uint)(1 << pos2);
                    value2 = (uintVar & mask) / mask;

                    mask = (uint)(1 << pos2);
                    uintVar = value1 == 0 ? uintVar & ~mask : uintVar | mask;

                    mask = (uint)(1 << pos1);
                    uintVar = value2 == 0 ? uintVar & ~mask : uintVar | mask;

                    pos1++;
                    pos2++;                    
                }

                Console.WriteLine(Convert.ToString(uintVar, 2).PadLeft(32, '0'));
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
