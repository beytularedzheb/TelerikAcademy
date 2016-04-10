using System;

namespace _03.RectanglesArea
{
    class RectArea
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter the width: ");
                double dWidth = double.Parse(Console.ReadLine());

                Console.Write("Please enter the height: ");
                double dHeight = double.Parse(Console.ReadLine());

                Console.WriteLine("-The rectangle's area is " + (dWidth * dHeight));
            }
            catch
            {
                Console.WriteLine("Incorrect data!");
            }
        }
    }
}
