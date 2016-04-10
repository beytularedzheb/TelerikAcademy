using System;
using System.Text;

class ReverseWordsInSentence
{
    static void Main()
    {
        string sentence = ".! C# is not C++, not \"PHP\" and not Delphi!!";
        Console.WriteLine(ReverseWords(sentence));
    }

    static string ReverseWords(string sentence)
    {
        StringBuilder result = new StringBuilder();
        char[] delimiters = { ' ', '.', ',', '!', '?', ':', ';', '\"', '\'', '(', ')', '\t' };

        /* Ако изречението започва с препинателен знак и/или интервал - 
         * добавят се всички такива символи, докато не се срещне различен, 
         * т.е използвайки sentence от Main - копира се |\t.! |
         */

        int j;
        for (j = 0; j < sentence.Length; j++)
        {
            bool flag = false;
            for (int i = 0; i < delimiters.Length; i++)
            {
                if (sentence[j] == delimiters[i])
                {
                    flag = true;
                }
            }

            if (flag)
            {
                result.Append(sentence[j]);
            }
            else
            {
                break;
            }
        }

        sentence = sentence.Substring(j, sentence.Length - j);

        string[] words = sentence.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        string[] punctuation = sentence.Split(words, StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(words);

        for (int i = 0; i < words.Length; i++)
        {
            result.Append(words[i]);
            result.Append(punctuation[i]);
        }

        return result.ToString();
    }
}