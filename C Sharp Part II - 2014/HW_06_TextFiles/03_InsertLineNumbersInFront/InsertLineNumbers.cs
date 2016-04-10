using System;
using System.IO;

public class InsertLineNumbers
{
    private const string InputFilePath = @"../../input.txt";
    private const string OutputFilePath = @"../../output.txt";

    public static void Main()
    {
        try
        {
            InsertLineNumbersInFront(InputFilePath, OutputFilePath);
            Console.WriteLine("Inserted!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void InsertLineNumbersInFront(string inPath, string outPath)
    {
        if (File.Exists(inPath))
        {
            using (var outFile = new StreamWriter(outPath))
            {
                using (var inFile = new StreamReader(inPath))
                {
                    int lineNumber = 1;
                    string line;
                    while ((line = inFile.ReadLine()) != null)
                    {
                        outFile.WriteLine("{0,-3}{1}", lineNumber, line);
                        lineNumber++;
                    }
                }
            }
        }
        else
        {
            throw new FileNotFoundException("Unable to find " + inPath);
        }
    }
}