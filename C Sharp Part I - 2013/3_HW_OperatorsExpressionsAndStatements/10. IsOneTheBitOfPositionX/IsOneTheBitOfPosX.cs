using System;

namespace _10.IsOneTheBitOfPositionX
{
    class IsOneTheBitOfPosX
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
                    Console.Write("Please enter the position (0 - 31): ");
                    pos = sbyte.Parse(Console.ReadLine());
                }
                while (pos > 31 || pos < 0);

                int mask = 1 << pos;

                if ((intVar & mask) == mask)
                    Console.WriteLine("-The {0}-th bit of {1} is 1.", pos, intVar);
                else
                    Console.WriteLine("-The {0}-th bit of {1} is 0.", pos, intVar);
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
