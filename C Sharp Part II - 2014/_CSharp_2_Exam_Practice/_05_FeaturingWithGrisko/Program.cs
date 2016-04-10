using System;
using System.Text;

class Program
{
    static int combCount = 0;

    static int[] usedCount = new int[26];

    static void GetComb(char[] letters, char[] comb, int start)
    {
        if (start >= comb.Length)
        {
            // ако текущият стринг има дължина (start) равна на входния (comb.Length)
            // т.е имаме една пермутация:
            combCount++;
            return;
        }

        // обхождам неповтарящите се букви от входния стринг
        for (int i = 0; i < letters.Length; i++)
        {
            // (ако е първата буква ИЛИ текущата е различна последната, записана буква)
            // И ако буквата все още може да се ползва
            if ((start == 0 || comb[start - 1] != letters[i]) && usedCount[letters[i] - 'a'] > 0)
            {
                // добавяме буквата
                comb[start] = letters[i];

                // намаляваме брояча, с което "казваме", че буквата е използвана още един път
                usedCount[letters[i] - 'a']--;
                GetComb(letters, comb, start + 1);

                // увеличаваме брояча, за да може да се използва буквата в други пермутации
                usedCount[letters[i] - 'a']++;
            }
        }
    }

    static void Main()
    {
        string input = Console.ReadLine();

        // преброявам колко пъти дадена буква може да се използва в една пермутация
        for (int i = 0; i < input.Length; i++)
        {
            usedCount[input[i] - 'a']++;
        }

        StringBuilder letters = new StringBuilder();

        // в letters записвам буквите, от входния стринг - БЕЗ повторения
        // (това е за оптимизация)
        for (int i = 0; i < usedCount.Length; i++)
        {
            if (usedCount[i] > 0)
            {
                letters.Append((char)(i + 'a'));
            }
        }

        char[] posLetters = letters.ToString().ToCharArray();
        char[] comb = new char[input.Length];

        GetComb(posLetters, comb, 0);

        Console.WriteLine(combCount);
    }
}