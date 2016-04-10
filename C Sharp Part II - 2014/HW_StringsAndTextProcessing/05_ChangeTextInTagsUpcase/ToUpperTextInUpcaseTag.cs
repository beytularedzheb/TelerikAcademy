using System;
using System.Text.RegularExpressions;

class ToUpperTextInUpcaseTag
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string pattern = @"<upcase>(?<textToUpper>.*?)</upcase>";

        text = Regex.Replace(text, pattern, m => m.Groups["textToUpper"].Value.ToUpper());

        Console.WriteLine(text);
    }
}