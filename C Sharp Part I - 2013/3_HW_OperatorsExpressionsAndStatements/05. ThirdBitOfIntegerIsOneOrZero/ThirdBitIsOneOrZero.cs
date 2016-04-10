using System;

namespace _05.ThirdBitOfIntegerIsOneOrZero
{
    class ThirdBitIsOneOrZero
    {
        static void Main(string[] args)
        {
            // 4 => 0100

            Console.Write("Please enter an integer number: ");
            try
            {
                int intVar = int.Parse(Console.ReadLine());
                if ((intVar & 8) == 8)                          
                    Console.WriteLine("-The third bit of {0} is 1.", intVar);
                else
                    Console.WriteLine("-The third bit of {0} is 0.", intVar);
                Console.WriteLine(intVar + "  =>  " + Convert.ToString(intVar, 2));
            }
            catch
            {
                Console.WriteLine("This is not integer!");
            }
        }
    }
}
