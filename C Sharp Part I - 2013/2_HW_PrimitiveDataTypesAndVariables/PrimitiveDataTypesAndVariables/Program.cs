using System;

namespace PrimitiveDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort numOne  = 52130;
            sbyte  numTwo  = -115;
            ulong  numThree = 4825932;
            byte   numFour = 97;
            short  numFive = -10000;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n", numOne, numTwo, numThree, numFour, numFive);
        }
    }
}
