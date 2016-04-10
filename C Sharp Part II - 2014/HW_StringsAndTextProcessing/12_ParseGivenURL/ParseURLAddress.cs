using System;
using System.Text.RegularExpressions;

class ParseURLAddress
{
    static void Main()
    {
        string address = @"http://www.devbg.org/forum/index.php";
        ParseURL(address);
    }

    static void ParseURL(string URL)
    {
        string pattern = @"\s*(?<protocol>.+)://(?<server>[^/]{3,})(?<resource>/?.*)";

        Match m = Regex.Match(URL, pattern);

        if (m.Groups.Count > 1)
        {
            for (int i = 1; i < m.Groups.Count; i++)
            {
                Console.WriteLine(m.Groups[i].Value);
            }
        }
        else
        {
            Console.WriteLine("Invalid URL address!");
        }
    }
}