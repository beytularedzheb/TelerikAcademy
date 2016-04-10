using System;

namespace _03.SafelyComparesFloat
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = 0.0D; 
            double numTwo = 0.0D;

            Console.WriteLine("Please enter two floating-point numbers:");

            try
            {
                numOne = double.Parse(Console.ReadLine());
                numOne = Math.Round(numOne, 6);
                numTwo = double.Parse(Console.ReadLine());
                numTwo = Math.Round(numTwo, 6);

                Console.WriteLine("\nIsEqual ({0} and {1}) = {2}\n", numOne, numTwo, numOne == numTwo);
            }
            catch
            {
                Console.WriteLine("Please enter only numbers or maybe the problem is in the type of the decimal point - (,) or (.)");        
            }       
        }
    }
}
