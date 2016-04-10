using System;

public class SurfaceOfTriangle
{
    // Две страни и ъгъл между тях
    public static double SurfaceTwoSidesAndAngleBtwThem(double sideX, double sideY, double angleXY)
    {
        // превръщане на градусите в радиани, т.к Math.Sin() работи с радиани
        double degreesToRadians = angleXY * (Math.PI / 180.0);
        double surface = (sideX * sideY * Math.Sin(degreesToRadians)) / 2.0;
        
        return surface;
    }

    // Една страна и височина към нея
    public static double SurfaceSideAndAltitude(double sideX, double altitudeX)
    {
        return (sideX * altitudeX) / 2.0;
    }

    // Три страни
    public static double SurfaceThreeSides(double sideA, double sideB, double sideC)
    {
        double surface = 0d;
        double semiPerimeter = (sideA + sideB + sideC) / 2.0;

        // Херонова формула
        surface = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * 
                                            (semiPerimeter - sideB) * 
                                            (semiPerimeter - sideC));
        return surface;
    }

    // Проверка дали трите страни могат да образуват триъгълник
    public static bool IsTriangle(double sideA, double sideB, double sideC)
    {
        if ((sideA < sideB + sideC) && 
            (sideB < sideA + sideC) && 
            (sideC < sideA + sideB))
        {
            return true;
        }

        return false;
    }

    // Проверка дали дадено число е положително
    public static bool IsPositive(double number)
    {
        if (number > 0)
        {
            return true;
        }

        return false;
    }

    // Меню
    private static void Menu()
    {
        int choice;
        do
        {
            Console.WriteLine("Calculate the surface of a triangle by given:");
            Console.WriteLine(new string(' ', 20) + "1. Side and an altitude to it;");
            Console.WriteLine(new string(' ', 20) + "2. Three sides;");
            Console.WriteLine(new string(' ', 20) + "3. Two sides and an angle between them;");
            Console.WriteLine(new string(' ', 20) + "0. Exit.");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Write("Side: ");
                    double side = double.Parse(Console.ReadLine());

                    if (!IsPositive(side))
                    {
                        break;
                    }

                    Console.Write("Alritude: ");
                    double alritude = double.Parse(Console.ReadLine());

                    if (!IsPositive(alritude))
                    {
                        break;
                    }

                    Console.WriteLine(SurfaceSideAndAltitude(side, alritude));

                    break;
                case 2:
                    bool flag1 = false;
                    Console.WriteLine("3 sides:");
                    double[] sides = new double[3];

                    for (int i = 0; i < 3; i++)
                    {
                        sides[i] = double.Parse(Console.ReadLine());
                        if (!IsPositive(sides[i]))
                        {
                            flag1 = true;
                            break;
                        }
                    }

                    if (!flag1 && IsTriangle(sides[0], sides[1], sides[2]))
                    {
                        Console.WriteLine(SurfaceThreeSides(sides[0], sides[1], sides[2]));
                    }

                    break;
                case 3:
                    bool flag2 = false;
                    Console.WriteLine("Two sides and an angle between them:");
                    double[] twoSides = new double[2];

                    for (int i = 0; i < 2; i++)
                    {
                        twoSides[i] = double.Parse(Console.ReadLine());
                        if (!IsPositive(twoSides[i]))
                        {
                            flag2 = true;
                            break;
                        }
                    }

                    double angle = double.Parse(Console.ReadLine());
                    if (!flag2 && IsPositive(angle) && angle < 180)
                    {
                        Console.WriteLine(SurfaceTwoSidesAndAngleBtwThem(twoSides[0], twoSides[1], angle));
                    }

                    break;
            }
        }
        while (choice != 0);
    }

    // Main
    private static void Main()
    {
        Menu();
    }
}