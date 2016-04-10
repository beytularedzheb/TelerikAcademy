using System;

namespace _07.IsPrime
{
    class IsPrime
    {
        static void Main(string[] args)
        {
            try
            {
                byte posNum = 101;
                bool bResult = true;
                do
                {
                    Console.Write("Please enter a positive integer number (<=100): ");
                    posNum = byte.Parse(Console.ReadLine());
                }
                while (posNum > 100);

                for (int i = 2; i < posNum; i++)
                {
                    if (posNum % i == 0)
                    {
                        bResult = false;
                        break;
                    }
                }
                Console.WriteLine("{0} is prime - {1}", posNum, bResult);
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
