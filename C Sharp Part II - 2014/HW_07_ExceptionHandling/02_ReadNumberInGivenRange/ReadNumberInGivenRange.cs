using System;

public class ReadNumberInGivenRange
{
    public static void Main()
    {
        try
        {
            int start = 1;
            int end = 100;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter an integer number > {0} and < {1}", start, end);
                start = ReadNumber(start, end);
            }
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.Error.WriteLine(e.ParamName);
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number! This is not an integer number.");
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Invalid number! This is not an integer numer!");
        }
        catch (OverflowException oe)
        {
            Console.Error.WriteLine(oe.Message);
        }
    }

    public static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (number <= start || number >= end)
        {
            throw new ArgumentOutOfRangeException(
                "The integer number should be bigger than " + start + " and less than " + end);
        }

        return number;
    }
}