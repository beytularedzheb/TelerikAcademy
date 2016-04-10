using System;

namespace _11.DeclareTwoIntAndExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVar1 = 5;
            int intVar2 = 10;

            Console.WriteLine("Before: A = {0} B = {1}", intVar1, intVar2);

            intVar1 = intVar1 + intVar2;
            intVar2 = intVar1 - intVar2;
            intVar1 = intVar1 - intVar2;

            Console.WriteLine("After: A = {0} B = {1}", intVar1, intVar2);
        }
    }
}
