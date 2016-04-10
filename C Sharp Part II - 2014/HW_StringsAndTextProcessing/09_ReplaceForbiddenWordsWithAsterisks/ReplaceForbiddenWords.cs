using System;
using System.Text.RegularExpressions;


class ReplaceForbiddenWords
{
    static void Main()
    {
        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        string[] words = { "PHP", "CLR", "Microsoft" };
        ReplaceWords(ref text, words);
        Console.WriteLine(text);
    }

    static void ReplaceWords(ref string text, string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            text = Regex.Replace(text, words[i], new string('*', words[i].Length));
        }
    }
}