using System;
using System.IO;
using System.Text.RegularExpressions;

class ExctarctTitleAndBodyText
{
    static void Main()
    {
        string text = File.ReadAllText("../../input.html");
        string pattern = @"(?<=>)(.|\s)*?(?=<)";
        foreach (var item in Regex.Matches(text, pattern))
        {
            if (!string.IsNullOrEmpty(item.ToString()))
            {
                Console.WriteLine(item);
            }
        }
    }
}