using System;
using System.IO;

public class PrintOddLinesInFile
{
    private const string InputFilePath = @"..\..\input.txt";

    public static void Main()
    {
        PrintOddLines();
    }

    private static void PrintOddLines()
    {
        try
        {
            using (StreamReader sr = new StreamReader(InputFilePath))
            {
                string line;
                int counter = 1;
                while ((line = sr.ReadLine()) != null)
                {
                    if (counter % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
          
                    counter++;
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Unable to find the file {0}!", InputFilePath);
        }
    }
}