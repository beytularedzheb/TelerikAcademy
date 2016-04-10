using System;
using System.Globalization;
using System.Threading;

public class SumOfNumbersInString
{
    public static double SumOfNumInString(string strNumber)
    {
        char[] delimiters = new char[] { ' ' };
        string[] numbers = strNumber.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        double sum = 0;
        foreach (string number in numbers)
        {
            sum += double.Parse(number);
        }

        return sum;
    }

    private static void Main()
    {
        /* Програмата работи и с дробни, и с отрицателни числа
         * (Десетичната запетая е '.', а не ',') !!!!!!!!!!!!
         * Пример: string strNumbersWithSeparator = " -43.25   68 9.44  -23   318 ";
         */

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string strNumbersWithSeparator = " 43       68 9  23   318 ";
        Console.WriteLine("Result = {0}", SumOfNumInString(strNumbersWithSeparator));
    }
}