using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

public class RemoveAllWord
{
    private const string FirstInputFilePath = @"../../words.txt";
    private const string SecondInputFilePath = @"../../delete.txt";

    public static void Main()
    {
        try
        {
            RemoveWords(SecondInputFilePath, LoadWords(FirstInputFilePath));
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (PathTooLongException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (SecurityException)
        {
            Console.WriteLine("You do not have the required permission to this file!");
        }
    }

    private static List<string> LoadWords(string wordsPath)
    {
        using (StreamReader fileWords = new StreamReader(wordsPath))
        {
            char[] delimiter = { ' ' };
            string lineWords;
            List<string> wordsList = new List<string>();

            while ((lineWords = fileWords.ReadLine()) != null)
            {
                string[] wordsLineItems = lineWords.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < wordsLineItems.Length; i++)
                {
                    wordsList.Add(wordsLineItems[i]);
                }
            }

            return wordsList;
        }
    }

    private static void RemoveWords(string delPath, List<string> words)
    {
        List<string> resultList = new List<string>();

        using (StreamReader fileRemove = new StreamReader(delPath))
        {
            string lineDel;
            char[] delimiter = { ' ' };

            while ((lineDel = fileRemove.ReadLine()) != null)
            {
                string[] delLineItems = lineDel.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder newLine = new StringBuilder();

                for (int i = 0; i < delLineItems.Length; i++)
                {
                    bool isFound = false;
                    for (int j = 0; j < words.Count; j++)
                    {
                        if (delLineItems[i].Equals(words[j]))
                        {
                            isFound = true;
                            break;
                        }
                    }

                    if (!isFound)
                    {
                        newLine.AppendFormat("{0} ", delLineItems[i]);
                    }
                }

                resultList.Add(newLine.ToString().TrimEnd());
            }
        }

        SaveToFile(delPath, resultList);
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