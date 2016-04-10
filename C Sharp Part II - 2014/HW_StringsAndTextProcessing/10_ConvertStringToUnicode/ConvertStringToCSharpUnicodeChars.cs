using System;
using System.Text;

class ConvertStringToCSharpUnicodeChars
{
    static void Main()
    {
        string text = "Hi!";
        StringBuilder result = new StringBuilder(text.Length * 6);
        for (int i = 0; i < text.Length; i++)
        {
            result.AppendFormat("\\u{0:x4}", (int)text[i]);
        }

        Console.WriteLine(result);
    }
}