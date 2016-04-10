using System;
using System.Collections.Generic;
using System.IO;
using System.Security;


public class OccurrenceOfWords
{
    private const string FirstInputFilePath = @"../../words.txt";
    private const string SecondInputFilePath = @"../../test.txt";
    private const string OutputFilePath = @"../../result.txt";

    public static void Main()
    {
        try
        {
            CalculateOccurance(SecondInputFilePath, OutputFilePath, LoadWords(FirstInputFilePath));
            Console.WriteLine("OK");
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

    private static WordsWithOccurrence[] LoadWords(string wordsPath)
    {
        using (StreamReader fileWords = new StreamReader(wordsPath))
        {
            char[] delimiter = { ' ' };
            string lineWords;
            List<WordsWithOccurrence> wordsList = new List<WordsWithOccurrence>();

            while ((lineWords = fileWords.ReadLine()) != null)
            {
                string[] wordsLineItems = lineWords.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < wordsLineItems.Length; i++)
                {
                    WordsWithOccurrence word = new WordsWithOccurrence();
                    word.Word = wordsLineItems[i];
                    word.Occurrence = 0;

                    wordsList.Add(word);
                }
            }

            return wordsList.ToArray();
        }
    }

    private static void CalculateOccurance(string inputPath, string outputPath, WordsWithOccurrence[] wordList)
    {
        using (StreamReader fileRemove = new StreamReader(inputPath))
        {
            string line;
            char[] delimiter = { ' ' };

            while ((line = fileRemove.ReadLine()) != null)
            {
                string[] curLineWords = line.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < wordList.Length; i++)
                {
                    for (int j = 0; j < curLineWords.Length; j++)
                    {
                        if (wordList[i].Word == curLineWords[j])
                        {
                            wordList[i].Occurrence++;
                        }
                    }
                }
            }

            Array.Sort(wordList, new CompareByOccurrence());
            Array.Reverse(wordList);
            SaveToFile(outputPath, wordList);
        }
    }

    private static void SaveToFile(string path, WordsWithOccurrence[] wordList)
    {
        using (StreamWriter writer = new StreamWriter(path))
        {
            for (int i = 0; i < wordList.Length; i++)
            {
                writer.WriteLine("{0} {1}", wordList[i].Word, wordList[i].Occurrence);
            }
        }
    }

    public struct WordsWithOccurrence
    {
        public string Word;
        public int Occurrence;
    }

    public class CompareByOccurrence : IComparer<WordsWithOccurrence>
    {
        public int Compare(WordsWithOccurrence x, WordsWithOccurrence y)
        {
            return x.Occurrence.CompareTo(y.Occurrence);
        }
    }
}
