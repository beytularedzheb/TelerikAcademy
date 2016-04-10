using System;

namespace _02.CheckIntDivWithoutRemainderBy7And5
{
    class DivWithoutRemainder
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter na integer number: ");
            try
            {
                int intVar = int.Parse(Console.ReadLine());
                bool bResult = false;
                if (intVar % 7 == 0 && intVar % 5 == 0)
                    bResult = true;
                Console.WriteLine("-The result is " + bResult);
            }
            catch
            {
                Console.WriteLine("This is not integer!");
            }
        }
    }
}
