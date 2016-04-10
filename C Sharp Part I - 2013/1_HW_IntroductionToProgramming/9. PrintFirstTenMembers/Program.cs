using System;

namespace _9.PrintFirstTenMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    if (i != 2)
                        Console.Write(", " + i);
                    else
                        Console.Write(i);
                }
                else
                    Console.Write(", " + i * (-1));
            }
            Console.WriteLine();
        }
    }
}
