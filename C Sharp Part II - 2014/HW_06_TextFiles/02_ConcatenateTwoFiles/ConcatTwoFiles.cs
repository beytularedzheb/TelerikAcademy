using System;
using System.IO;

public class ConcatTwoFiles
{
    private static string firstInFilePath = @"../../firstInput.txt";
    private static string secondInFilePath = @"../../secondInput.txt";
    private static string resultInFilePath = @"../../concatResult.txt";

    public static void Main()
    {
        try
        {
            Concat(firstInFilePath, secondInFilePath, resultInFilePath);
            Console.WriteLine("Concatenated!");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void Concat(string first, string second, string result)
    {
        if (File.Exists(first) && File.Exists(second))
        {
            File.WriteAllText(result, File.ReadAllText(first));

            /* Проверявам файла дали съществува - може да е изтрит..*/
            if (File.Exists(result))
            {
                File.AppendAllText(result, File.ReadAllText(second));
            }
            else
            {
                throw new FileNotFoundException("Unable to find " + result);
            }
        }
        else
        {
            throw new FileNotFoundException("Unable to find " + first + " and/or " + second);
        }
    }
}