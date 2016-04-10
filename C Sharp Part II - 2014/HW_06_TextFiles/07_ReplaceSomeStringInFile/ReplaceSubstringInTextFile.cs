using System;
using System.IO;

public class ReplaceSubstringInTextFile
{
    private const string InputFilePath = @"../../input.txt";
    private const string OutputFilePath = @"../../output.txt";

    private const string StrForReplacing = "start";
    private const string StrReplace = "finish";

    public static void Main()
    {
        try
        {
            Replace(InputFilePath, OutputFilePath, StrForReplacing, StrReplace);
            Console.WriteLine("OK");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void Replace(string inPath, string outPath, string replaceStr, string replaceStrWith)
    {
        if (File.Exists(inPath))
        {
            using (StreamReader inFile = new StreamReader(inPath))
            {
                using (StreamWriter outFile = new StreamWriter(outPath))
                {
                    string line;
                    int startPos;
                    while ((line = inFile.ReadLine()) != null)
                    {
                        while ((startPos = line.IndexOf(replaceStr)) != -1)
                        {         
                            line = line.Remove(startPos, replaceStr.Length);
                            line = line.Insert(startPos, replaceStrWith);
                        }

                        outFile.WriteLine(line);
                    }
                }
            }
        }
    }
}