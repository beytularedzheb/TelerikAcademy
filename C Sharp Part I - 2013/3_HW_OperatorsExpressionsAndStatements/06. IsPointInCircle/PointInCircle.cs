using System;

namespace _06.IsPointInCircle
{
    class PointInCircle
    {
        static void Main(string[] args)
        {
            try
            {
                double circleCordX = 0, 
                       circleCordY = 0, 
                       circleRadius = 5;

                Console.Write("Please enter X: ");
                double cX = double.Parse(Console.ReadLine());

                Console.Write("Please enter Y: ");
                double cY = double.Parse(Console.ReadLine());

                cX = circleCordX - cX;
                cY = circleCordY - cY;

                if ((cX * cX + cY * cY) <= (circleRadius * circleRadius))
                    Console.WriteLine("The point is within the circle K(0, 0, 5).");
                else
                    Console.WriteLine("The point is NOT within the circle K(0, 0, 5).");
            }
            catch
            {
                Console.WriteLine("Invalidate data!");
            }
        }
    }
}
