using System;

namespace _04.CheckThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer number: ");
            try
            {
                int intVar = int.Parse(Console.ReadLine());
                int buf = (intVar % 1000) - 700;
                bool bResult = false;
                if (buf >= 0 && buf <= 99)
                    bResult = true;
                Console.WriteLine("-The third digit of {0} is 7 - {1}", intVar, bResult);
            }
            catch
            {
                Console.WriteLine("This is not integer!");
            }
        }
    }
}
