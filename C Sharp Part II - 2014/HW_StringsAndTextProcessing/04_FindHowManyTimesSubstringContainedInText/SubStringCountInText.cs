using System;
using System.Text.RegularExpressions;

public class SubStringCountInText
{
    public static void Main()
    {
        string text = Console.ReadLine();
        string subStr = Console.ReadLine();

        Console.WriteLine(Find(text, subStr));
    }

    public static int Find(string text, string subStr)
    {
        if (!string.IsNullOrEmpty(text) && !string.IsNullOrEmpty(subStr))
        {
            return Regex.Matches(text, subStr, RegexOptions.IgnoreCase).Count;
        }

        return 0;
    }
}