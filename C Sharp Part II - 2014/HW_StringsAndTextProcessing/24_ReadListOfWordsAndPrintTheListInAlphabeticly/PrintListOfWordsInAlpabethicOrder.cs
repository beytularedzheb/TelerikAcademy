using System;

class PrintListOfWordsInAlpabethicOrder
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(' ');
        Array.Sort(words);
        Console.WriteLine(string.Join("\r\n", words));
    }
}