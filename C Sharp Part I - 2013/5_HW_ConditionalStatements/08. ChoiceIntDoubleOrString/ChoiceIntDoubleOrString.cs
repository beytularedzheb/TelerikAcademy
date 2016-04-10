using System;

class ChoiceIntDoubleOrString
{
    static void Main(string[] args)
    {
        byte choice;

        Console.WriteLine("Please enter 0 for int, 1 for double and 2 for string:");

        while (!byte.TryParse(Console.ReadLine(), out choice) || choice > 2)
        {
            Console.WriteLine("Invalid number. Please try again..");
        }

        switch (choice)
        {
            case 0:
                Console.Write("Please enter an integer number: ");

                int intVar;

                while (!int.TryParse(Console.ReadLine(), out intVar))
                {
                    Console.WriteLine("This is not an integer number!.. Please try again..");
                }
                Console.WriteLine(++intVar);
                break;
            case 1:
                Console.Write("Please enter a double number: ");

                double doubleVar;

                while (!double.TryParse(Console.ReadLine(), out doubleVar))
                {
                    Console.WriteLine("This is not a double number!.. Please try again..");
                }
                Console.WriteLine(++doubleVar);
                break;
            case 2:
                Console.Write("Please enter a string: ");
                string strVar = Console.ReadLine();
                Console.WriteLine(strVar += "*");
                break;
        }
    }
}


