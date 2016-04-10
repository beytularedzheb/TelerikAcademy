using System;

public class Reverse
{
    public static void Main()
    {
        string text = Console.ReadLine();

        try
        {
            // using built-in method (.NET)
            Console.WriteLine(ReverseStringDotNet(text));

            Console.WriteLine(ReverseString(text));
        }
        catch (NullReferenceException)
        {
            Console.Error.WriteLine("Invalid input! Please enter non null string!");
        }
    }

    public static string ReverseStringDotNet(string text)
    {
        char[] charArr = text.ToCharArray();
        Array.Reverse(charArr);
        return new string(charArr);
    }
    
    public static string ReverseString(string text)
    {
        char[] charArr = text.ToCharArray();
        for (int i = 0; i < charArr.Length / 2; i++)
        {
            charArr[i] ^= charArr[charArr.Length - 1 - i];
            charArr[charArr.Length - 1 - i] ^= charArr[i];
            charArr[i] ^= charArr[charArr.Length - 1 - i];
        }

        return new string(charArr);
    }
}