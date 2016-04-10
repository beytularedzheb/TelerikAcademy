using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.WriteAndPrintAgeToConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            try
            {
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Your age after 10 years: " + (age + 10));
            }
            catch
            {
                Console.WriteLine("\tPlease enter number only.");
            }
        }
    }
}
