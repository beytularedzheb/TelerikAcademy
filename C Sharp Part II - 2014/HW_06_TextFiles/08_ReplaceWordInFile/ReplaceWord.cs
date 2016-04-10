using System;
using System.IO;
using System.Text;

public class ReplaceWord
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
                    while ((line = inFile.ReadLine()) != null)
                    {
                        char[] delimiter = { ' ' };
                        string[] lineItems = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                        StringBuilder buffer = new StringBuilder();

                        for (int i = 0; i < lineItems.Length; i++)
                        {
                            if (lineItems[i].Equals(replaceStr))
                            {
                                lineItems[i] = replaceStrWith;
                            }

                            buffer.AppendFormat("{0} ", lineItems[i]);
                        }

                        outFile.WriteLine(buffer.ToString().TrimEnd());
                    }
                }
            }
        }
    }
}