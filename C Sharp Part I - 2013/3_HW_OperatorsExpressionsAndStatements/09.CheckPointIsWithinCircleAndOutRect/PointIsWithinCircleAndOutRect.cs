using System;

namespace _09.CheckPointIsWithinCircleAndOutRect
{
    class PointIsWithinCircleAndOutRect
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Please enter X: ");
                float x = float.Parse(Console.ReadLine());

                Console.Write("Please enter Y: ");
                float y = float.Parse(Console.ReadLine());

                float cX = 1,
                      cY = 1,
                      cR = 3;
                float rTop = 1,
                      rLeft = -1,
                      rWidth = 6,
                      rHeight = 2;

                bool isWithinCircle;
                bool isOutOfRect;

                isWithinCircle = (Math.Pow(cX - x, 2) + Math.Pow(cY - y, 2)) <= Math.Pow(cR, 2);

                isOutOfRect = (x >= rLeft && x <= (rLeft + rWidth) && y <= rTop && y >= (rTop - rHeight));

                if (isWithinCircle)
                    Console.WriteLine("The point is within circle K((1, 1), 3)!");
                else
                    Console.WriteLine("The point is out of circle K((1, 1), 3)!");

                if (isOutOfRect)
                    Console.WriteLine("The point is within rectangle R(t = 1, l = -1, w = 6, h = 2)!");
                else
                    Console.WriteLine("The point is out of rectangle R(t = 1, l = -1, w = 6, h = 2)!");
            }
            catch
            {
                Console.WriteLine("Incorrect data");
            }
        }
    }
}
