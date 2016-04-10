using System;

class SearchLetter
{
    static void Main()
    {
        char[] abcArray = new char[26];

        for (char i = 'A'; i <= 'Z'; i++)
        {
            abcArray[i - 'A'] = i;
        }

        Console.WriteLine("Please enter the word for searching:");
        string keyword = Console.ReadLine();

        for (int i = 0; i < keyword.Length; i++)
        {
            char letter = Char.ToUpper(keyword[i]);
            int ind = letter - 'A';

            if (ind >= 0 && ind <= 25)
            {
                Console.WriteLine("Index [{0}]  -  {1}", ind, abcArray[ind]);
            }
            else
            {
                Console.WriteLine("Not found!  -  {0}", letter);
            }
        }
    }
}

