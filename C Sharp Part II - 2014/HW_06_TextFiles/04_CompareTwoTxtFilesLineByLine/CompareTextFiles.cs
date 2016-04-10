using System;
using System.IO;

public class CompareTextFiles
{
    private const string FirstFilePath = @"../../first.txt";
    private const string SecondFilePath = @"../../second.txt";

    public static void Main()
    {
        try
        {
            int sameLinesNum = 0;
            int differentLinesNum = 0;
            CompareLineByLine(FirstFilePath, SecondFilePath, ref sameLinesNum, ref differentLinesNum);

            Console.WriteLine("The number of the lines that are the same: {0}", sameLinesNum);
            Console.WriteLine("The number of the lines that are the different: {0}", differentLinesNum);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void CompareLineByLine(string firstPath, string secondPath, ref int sameLinesNum, ref int diffLinesNum)
    {
        if (File.Exists(firstPath) && File.Exists(secondPath))
        {
            if (File.ReadAllLines(firstPath).Length == File.ReadAllLines(secondPath).Length)
            {
                using (StreamReader firstFile = new StreamReader(firstPath))
                {
                    using (StreamReader secondFile = new StreamReader(secondPath))
                    {
                        string firstFileLine, secondFileLine;

                        while ((firstFileLine = firstFile.ReadLine()) != null &&
                               (secondFileLine = secondFile.ReadLine()) != null)
                        {
                            if (firstFileLine.Equals(secondFileLine))
                            {
                                sameLinesNum++;
                            }
                            else
                            {
                                diffLinesNum++;
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("The files must have equal number of lines.");
            }
        }
        else
        {
            throw new FileNotFoundException();
        }
    }
}