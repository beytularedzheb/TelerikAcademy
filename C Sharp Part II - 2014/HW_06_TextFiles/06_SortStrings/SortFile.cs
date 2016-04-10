using System;
using System.Collections.Generic;
using System.IO;

public class SortFile
{
    private const string InputFilePath = @"../../input.txt";
    private const string OutputFilePath = @"../../output.txt";

    public static void Main()
    {
        try
        {
            List<string> stringList = ReadInputFile(InputFilePath);
            stringList.Sort();
            SaveToFile(OutputFilePath, stringList);
            Console.WriteLine("OK");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void SaveToFile(string path, List<string> stringList)
    {
        using (var sw = new StreamWriter(path))
        {
            foreach (var word in stringList)
            {
                sw.WriteLine(word);
            }
        }
    }

    private static List<string> ReadInputFile(string path)
    {
        List<string> result = new List<string>();

        if (File.Exists(path))
        {
            string line;

            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    char[] delimiter = { ' ', '\t' };
                    string[] lineItems = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < lineItems.Length; i++)
                    {
                        result.Add(lineItems[i]);
                    }
                }
            }
        }
        else
        {
            throw new FileNotFoundException("Unable to find " + path);
        }

        return result;
    }
}