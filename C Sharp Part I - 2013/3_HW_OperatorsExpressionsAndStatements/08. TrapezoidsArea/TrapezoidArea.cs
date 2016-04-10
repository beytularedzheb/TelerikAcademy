using System;

namespace _08.TrapezoidsArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter a: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Please enter b: ");
                double b = double.Parse(Console.ReadLine());

                Console.Write("Please enter h: ");
                double h = double.Parse(Console.ReadLine());

                if (a <= 0 || b <= 0 || h <= 0)
                {
                    Console.WriteLine("-You have entered a negative number!");
                }
                else
                {
                    double trArea = ((a + b) / 2) * h;
                    Console.WriteLine("-Trapezoid's areas is {0}", trArea);
                }
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
