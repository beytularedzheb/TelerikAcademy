using System;
using System.Text.RegularExpressions;

class ReplaceHTMLTags
{
    static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        //text = Regex.Replace(text, @"<a\s+href\s*=\s*""", "[URL=");
        //text = Regex.Replace(text, @"""\s*>", "]");
        //text = Regex.Replace(text, @"</a\s*>", "[\\URL]");

        text = Regex.Replace(text, @"<a\s+href\s*=\s*""(.*?|\s*?)""\s*>(.*?|\s*?)</a\s*>", @"[URL=$1]$2[/URL]");
        Console.WriteLine(text);
    }
}