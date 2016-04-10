using System;

class LettersNumber
{
    static void Main()
    {
        string text = Console.ReadLine();
        
        for (int i = 0; i < text.Length; i++)
        {
            int counter = 0;
            bool flag = false;
            // ако символът е буква
            if (char.IsLetter(text[i]))
            {
                for (int j = 0; j < text.Length; j++)
                {
                    // проверявам дали е срещната преди
                    if (i > j && text[i] == text[j])
                    {
                        flag = true;
                        break;
                    }
                    else if (i <= j && text[i] == text[j])
                    {
                        // ако не е..
                        counter++;
                    }
                }

                if (!flag)
                {
                    Console.WriteLine("{0} {1}", text[i], counter);
                }
            }
        }
    }
}