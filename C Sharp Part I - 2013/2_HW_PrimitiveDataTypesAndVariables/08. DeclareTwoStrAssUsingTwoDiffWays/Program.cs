using System;

namespace _08.DeclareTwoStrAssUsingTwoDiffWays
{
    class Program
    {
        static void Main(string[] args)
        {
            string strWithoutPrefix = "The \"use\" of quotations causes difficulties.";
            string strWithPrefix = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("Without prefix @:\n" + strWithoutPrefix);
            Console.WriteLine("\nWith prefix @:\n" + strWithPrefix + "\n");
        }
    }
}
