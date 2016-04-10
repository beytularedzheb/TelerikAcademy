using System;
using System.Text;

class ReplaceConsecutiveIdenticalLettersWithSingleOne
{
    static void Main()
    {
        string text = Console.ReadLine();
        StringBuilder result = new StringBuilder();

        if (!string.IsNullOrEmpty(text))
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    result.Append(text[i]);
                }
            }

            if (text[text.Length - 1] != result[result.Length - 1])
            {
                result.Append(text[text.Length - 1]);
            }
        }

        Console.WriteLine(result);
    }
}