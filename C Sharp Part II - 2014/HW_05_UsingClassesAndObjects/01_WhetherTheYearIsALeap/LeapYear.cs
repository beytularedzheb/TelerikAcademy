/*
 *                              P.S.
 * Причината да пиша "всички" функции/класове/променливи с private/public
 * е, че ползвам StyleCop, за да се науча да пиша "по-качествен" код
*/

using System;

public class LeapYear
{
    /*годините, кратни на 4 са високосни, останалите не са;
    изключение 1: годините, кратни на 100 не са високосни;
    изключение 2: годините, кратни на 400 са високосни.*/
    public static bool IsLeapYear(int year)
    {
        if ((year % 100 == 0 && year % 400 != 0) || year % 4 != 0)
        {
            return false;
        }

        return true;
    }

    private static void Main()
    {
        Console.Write("Year: ");
        int year = int.Parse(Console.ReadLine());

        // Вграден метод
        Console.WriteLine(DateTime.IsLeapYear(year));

        // Моят метод
        Console.WriteLine(IsLeapYear(year));
    }
}