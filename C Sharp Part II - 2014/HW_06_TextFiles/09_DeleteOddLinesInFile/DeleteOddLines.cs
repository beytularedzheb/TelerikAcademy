using System;
using System.Collections.Generic;
using System.IO;

public class DeleteOddLines
{
    private const string InputFilePath = @"../../input.txt";

    public static void Main()
    {
        try
        {
            SaveToFile(InputFilePath, GetEvenLines(InputFilePath));
            Console.WriteLine("OK");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static List<string> GetEvenLines(string path)
    {
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int lineNumber = 1;
                List<string> result = new List<string>();

                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        result.Add(line);
                    }

                    lineNumber++;
                }

                return result;
            }
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