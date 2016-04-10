using System;
using System.Text.RegularExpressions;

class ExtractSentecesContainingWordX
{
    static void Main()
    {
        ExtractSentences("We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.", "in");
    }

    static void ExtractSentences(string text, string word)
    {
        string pattern = @"([^\.]*\b" + word + @"\b.*?\.)";

        MatchCollection matchCol = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (Match m in matchCol)
        {
            Console.WriteLine(m);
        }
    }
}