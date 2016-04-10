using System;

public class SqaureRoot
{
    public static void Main()
    {
        try
        {
            Console.WriteLine(CalculateSqrtOfInt32(Console.ReadLine()));
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.Error.WriteLine("Good bye");
        }
    }

    public static double CalculateSqrtOfInt32(string strNumber)
    {
        uint number = uint.Parse(strNumber);
        return Math.Sqrt(number);
    }
}