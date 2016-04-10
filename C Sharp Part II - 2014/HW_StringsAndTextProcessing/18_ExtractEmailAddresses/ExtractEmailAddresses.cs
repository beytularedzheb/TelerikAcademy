using System;
using System.Text.RegularExpressions;

class ExtractEmailAddresses
{
    static void Main()
    {
        string text = "opp,email@gmail.com asddsaw dsa@ sda dsa12@abv.as.oppa.com>sdao";

        foreach (var item in Regex.Matches(text, @"(\s*(\w|\d)+?@(\w|\d)+?\.\w+(\.*\w*\d*)+\s*)"))
        {
            Console.WriteLine(item.ToString().Trim());
        }
    }
}