using System;

class PerimeterAndAreaOfCircle
{
    static void Main(string[] args)
    {
        double radius;
 
        do
        {
            Console.Write("Radius: ");
            if (double.TryParse(Console.ReadLine(), out radius))
            {
                // Радиусът не може да бъде отрицателен или с нулева стойност

                if (radius > 0)
                {
                    Console.WriteLine("Perimeter = {0:F4}", 2 * Math.PI * radius);
                    Console.WriteLine("Area = {0:F4}", Math.PI * Math.Pow(radius, 2));
                }
            }

            // При невалидна стойност TryParse функцията задава нула на радиуса
            // и благодарение на това след проверката в while се дава възможност за въвеждане на
            //нова стойност, докато не се въведе валидна..
        }
        while (radius <= 0);
    }
}

