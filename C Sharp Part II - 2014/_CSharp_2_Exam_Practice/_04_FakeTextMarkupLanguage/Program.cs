using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        ushort n = ushort.Parse(Console.ReadLine());

        string line = string.Empty;

        for (int i = 0; i < n; i++)
        {
            line = Console.ReadLine();

            Console.WriteLine(Tags(line));
        }
    }

    static string Tags(string line)
    {
        string result = line;

        while (Regex.IsMatch(result, @"<(\w)+>(.|s*)*?</(\w)+>"))
        {
            result = Regex.Replace(result, @"<del>([^<>])*?</del>", string.Empty);

            result = Regex.Replace(result, @"<upper>(?<Textt>([^<>][.\s]*?)*?)</upper>", m => m.Groups["Textt"].Value.ToUpper());

            result = Regex.Replace(result, @"<lower>(?<Textt>([^<>][.\s]*?)*?)</lower>", m => m.Groups["Textt"].Value.ToLower());

            result = Regex.Replace(result, @"<rev>(?<Textt>([^<>][.\s]*?)*?)</rev>", new MatchEvaluator(Reverse));

            result = Regex.Replace(result, @"<toggle>(?<Textt>([^<>][.\s]*?)*?)</toggle>", new MatchEvaluator(Toggle));
        }

        return result;
    }

    static string Reverse(Match m)
    {
        StringBuilder result = new StringBuilder(m.Value.Length);

        for (int i = m.Groups["Textt"].Value.Length - 1; i > -1; i--)
        {
            result.Append(m.Groups["Textt"].Value[i]);
        }

        return result.ToString();
    }

    static string Toggle(Match m)
    {
        StringBuilder result = new StringBuilder(m.Value.Length);

        for (int i = 0; i < m.Groups["Textt"].Value.Length; i++)
        {
            if (char.IsLower(m.Groups["Textt"].Value[i]))
            {
                result.Append(char.ToUpper(m.Groups["Textt"].Value[i]));
            }
            else 
            {
                result.Append(char.ToLower(m.Groups["Textt"].Value[i]));
            }
            
        }

        return result.ToString();
    }
}