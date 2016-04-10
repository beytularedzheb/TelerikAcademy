using System;
using System.Text.RegularExpressions;

class WordsCount
{
    static void Main()
    {
        string text = Console.ReadLine();
        // Моля въведете думите като ги разделяте с интервал
        string[] words = Console.ReadLine().Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine("{0} {1}", words[i], 
                Regex.Matches(text, "\\b" + words[i] + "\\b", RegexOptions.IgnoreCase).Count);
        }
    }
}