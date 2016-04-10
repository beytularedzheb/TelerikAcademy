using System;

class ReverseDigits
{
    static void Main()
    {
        Console.WriteLine("Please enter your decimal number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(ReverseNumber(number));
    }

    // функията reverse-ва и отрицателни числа по следния начин:
    // -123 => -321
    static string ReverseNumber(int number)
    {
        string result = "";
        string strNumber = Math.Abs(number).ToString();

        for (int i = 0; i < strNumber.Length; i++)
        {
            result = strNumber[i] + result;
        }

        // резултатът е от тип стринг т.к искам да получа следният "ефект":
        // 500 -> 005
        // И поради тази причина конвертирам числото до стринг и работя със стрингове,
        // а не примерно да получавам reverse'натото число чрез използване на аритметични
        // операции (/, %). Просто така реших :)
        return number > 0 ? result : "-" + result;
    }
}

