using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class DeleteWordsWhitPrefixX
{
    private const string InputFilePath = @"../../input.txt";

    public static void Main()
    {
        try
        {
            DeleteWords(InputFilePath, "test");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void DeleteWords(string path, string prefix)
    {
        if (File.Exists(path))
        {
            string pattern = @"\b" + prefix + @"\w*\b";
            List<string> result = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = Regex.Replace(line, pattern, string.Empty);
                    result.Add(line);
                }
            }

            SaveToFile(path, result);
        }
        else
        {
            throw new FileNotFoundException("Unable to find " + path);
        }
    }

    private static void SaveToFile(string path, List<string> strList)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (string line in strList)
            {
                writer.WriteLine(line);
            }
        }
    }
}