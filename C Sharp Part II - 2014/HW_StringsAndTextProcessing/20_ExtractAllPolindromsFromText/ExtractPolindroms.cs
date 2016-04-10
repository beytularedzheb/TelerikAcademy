using System;
using System.Text.RegularExpressions;

class ExtractPolindroms
{
    static void Main()
    {
        string text = "ABBA, 121, lamal, bebe, exe, lastik; kabak..";
        string[] words = Regex.Split(text, @"\W\D");

        for (int i = 0; i < words.Length; i++)
        {
            bool isPolindrom = true;
            for (int j = 0; j < words[i].Length / 2; j++)
            {
                if (words[i][j] != words[i][words[i].Length - 1 - j])
                {
                    isPolindrom = false;
                    break;
                }
            }

            if (isPolindrom && words[i] != string.Empty)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}