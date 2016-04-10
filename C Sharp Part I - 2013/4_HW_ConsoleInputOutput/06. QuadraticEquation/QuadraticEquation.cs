using System;

class QuadraticEquation
{
    static double a;
    static double b;
    static double c;

    static void Main(string[] args)
    {
        Console.Write("a = ");
        Validate(ref a);

        Console.Write("b = ");
        Validate(ref b);

        Console.Write("c = ");
        Validate(ref c);

        double d = Discriminant(a, b, c);

        FindX(a, b, d);
    }

    static void FindX(double aVar, double bVar, double d)
    {
        if (d < 0)
        {
            Console.WriteLine("The equation has no real roots!");
        }
        else if (d == 0)
        {
            Console.WriteLine("X1 = X2 = {0}", (-b / (2 * aVar)));
        }
        else
        {
            Console.WriteLine("X1 =  {0}", ((-b + Math.Sqrt(d)) / (2 * aVar)));
            Console.WriteLine("X2 =  {0}", ((-b - Math.Sqrt(d)) / (2 * aVar)));
        }
    }

    static void Validate(ref double someVar)
    {
        while (!double.TryParse(Console.ReadLine(), out someVar))
        {
            Console.WriteLine("Invalid number.. Please try again...");
        }
    }

    static double Discriminant(double aVar, double bVar, double cVar)
    {
        return (Math.Pow(bVar, 2) - 4 * aVar * cVar);
    }
}

