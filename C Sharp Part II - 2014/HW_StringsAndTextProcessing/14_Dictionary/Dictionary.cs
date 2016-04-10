using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StringBuilder text = new StringBuilder();
        text.Append(".NET – platform for applications from Microsoft\r\n");
        text.Append("CLR – managed execution environment for .NET\r\n");
        text.Append("namespace – hierarchical organization of classes\r\n");

        string wordSearch = Console.ReadLine();
        string pattern = @"^" + wordSearch + @" (-|–) ?.*";
        Console.WriteLine(Regex.Match(text.ToString(), pattern, RegexOptions.Multiline).Value);
    }
}