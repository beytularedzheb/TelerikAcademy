using System;

class Greater
{
    static void Main(string[] args)
    {
        double firstNum;
        double secondNum;

        Console.Write("Enter fisrt number: ");
        if (double.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.Write("Enter second number: ");
            if (double.TryParse(Console.ReadLine(), out secondNum))
            {
                // Един от начините за намиране на по-голямото от 2 числа е
                // secondNum = firstNum - secondNum;
                // firstNum = firstNum - secondNum * ((secondNum >> 63) & 1);
                // Console.WriteLine("Max = {0}", firstNum);
                // ако числото е цяло (int или long) разбира се. 
                // Но тъй като числото може да е реално, реших да използвам вградена функция.
                Console.WriteLine("Max = {0}", Math.Max(firstNum, secondNum));
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }
}
