using System;

namespace OperatorsExpressionsAndStatements
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            // Тъй като се използва ReadLine(), трябва да се внимава, когато се въвежда
            // число, защото при следния вход: "45 5", т.е ако има интервал, числото
            // се интерпретира като 455.

            Console.Write("Please enter an integer number: ");
            try
            {
                int intVar = int.Parse(Console.ReadLine());
                string strResMsg = (intVar % 2) == 0 ? "Even." : "Odd.";
                Console.WriteLine("-The number is " + strResMsg);
            }
            catch 
            {
                Console.WriteLine("This is not integer.");
            }
        }
    }
}
