using System;


class ExchangeValues
{
    static void Main(string[] args)
    {
        int someVarA, someVarB, swapVar;

        Console.WriteLine("Please enter an integer number A:");
        while (!int.TryParse(Console.ReadLine(), out someVarA))
        {
            Console.WriteLine("Invalid number! Please try again..");
        }

        Console.WriteLine("Please enter an integer number B:");
        while (!int.TryParse(Console.ReadLine(), out someVarB))
        {
            Console.WriteLine("Invalid number! Please try again..");
        }

        if (someVarA > someVarB)
        {
            swapVar = someVarA;
            someVarA = someVarB;
            someVarB = swapVar;

            Console.WriteLine("Exchanged -> A = {0} B = {1}", someVarA, someVarB);
        }
        else
        {
            Console.WriteLine("\"A\" is not grater than \"B\" -> A = {0} B = {1}", someVarA, someVarB);
        }
    }
}

