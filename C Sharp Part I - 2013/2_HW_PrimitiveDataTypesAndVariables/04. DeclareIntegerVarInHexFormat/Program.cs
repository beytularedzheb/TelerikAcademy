using System;

namespace _04.DeclareIntegerVarInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int varInHex = 0xFE;
            Console.WriteLine("Hex = {0:X} => Dec = {1}", varInHex, varInHex);
        }
    }
}
