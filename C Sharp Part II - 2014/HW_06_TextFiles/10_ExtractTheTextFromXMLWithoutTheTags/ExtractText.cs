using System;
using System.Collections.Generic;
using System.IO;

public class ExtractText
{
    private const string InputFilePath = @"../../input.xml";

    public static void Main()
    {
        try
        {
            ExtractTextWithoutTags(InputFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void ExtractTextWithoutTags(string path)
    {
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                List<string> result = new List<string>();
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i].Equals('>'))
                        {
                            for (int j = i + 1; j < line.Length; j++)
                            {
                                if (line[j].Equals('<'))
                                {
                                    if (j - i > 1)
                                    {
                                        result.Add(line.Substring(i + 1, j - i - 1));
                                    }

                                    break;
                                }
                            }
                        }
                    }
                }

                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
        }
        else
        {
            throw new FileNotFoundException("Unable to find " + path);
        }
    }
}