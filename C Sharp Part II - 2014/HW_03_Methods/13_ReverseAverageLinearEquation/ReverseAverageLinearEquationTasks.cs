using System;


class ReverseAverageLinearEquationTasks
{
    static void Main()
    {
        Menu();
    }

    static void Menu()
    {
        int choice;
        do
        {
            Console.WriteLine(new String(' ', 35) + "MENU");
            Console.WriteLine(new String(' ', 20) + "1. Reverse the digit of a number");
            Console.WriteLine(new String(' ', 20) + "2. Calculate the average of a sequence of integers");
            Console.WriteLine(new String(' ', 20) + "3. Solve a linear equation a * x + b = 0");
            Console.WriteLine(new String(' ', 20) + "0. Exit");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter a positive integer number: ");
                    int num = int.Parse(Console.ReadLine());
                    if (IsNonNegative(num))
                    {
                        Console.WriteLine(ReverseNumber(num));
                    }
                    break;
                case 2:
                    Console.Write("Array size: ");
                    int size = int.Parse(Console.ReadLine());
                    if (IsNonNegative(size) && IsNotEqualToZero(size))
                    {
                        int[] arr = new int[size];
                        SetArray(arr);
                        Console.WriteLine(CalculateAverageOfInt(arr));
                    }
                    break;
                case 3:
                    Console.Write("Please enter a (a != 0): ");
                    double a = double.Parse(Console.ReadLine());
                    if (IsNotEqualToZero(a))
                    {
                        Console.Write("Please enter b: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine(LinearEquation(a, b));
                    }
                    break;
            }
        }
        while (choice != 0);
    }

    static void SetArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    static string ReverseNumber(int number)
    {
        string result = "";
        string strNumber = Math.Abs(number).ToString();

        for (int i = 0; i < strNumber.Length; i++)
        {
            result = strNumber[i] + result;
        }

        return number > 0 ? result : "-" + result;
    }

    static double CalculateAverageOfInt(int[] sequnce)
    {
        double sum = 0d;
        for (int i = 0; i < sequnce.Length; i++)
        {
            sum += sequnce[i];
        }
        return sum / sequnce.Length;
    }

    static double LinearEquation(double a, double b)
    {
        if (IsNotEqualToZero(a))
        {
            return -b / a;
        }
        throw new DivideByZeroException();
    }

    static bool IsNotEqualToZero(double number)
    {
        return number != 0 ? true : false;
    }

    static bool IsNonNegative(double number)
    {
        return number >= 0 ? true : false;
    }
}

