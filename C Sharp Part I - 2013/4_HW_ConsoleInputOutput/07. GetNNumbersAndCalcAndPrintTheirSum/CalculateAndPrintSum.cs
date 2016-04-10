using System;

 class CalculateAndPrintSum
 {
     static void Main(string[] args)
     {
         uint n;
         double someNum = 0, sum = 0;

         Console.Write("Please enter N: ");

         while(!uint.TryParse(Console.ReadLine(), out n) || n == 0)
         {
             Console.WriteLine("Invalid number.. Try again...");
         }

         Console.WriteLine("Please enter {0} numbers: ", n);

         for (int i = 0; i < n; i++)
         {
             sum += Validate(someNum);   
         }

         Console.WriteLine("Sum = {0}", sum);
     }

     static double Validate(double someNum)
     {
         while (!double.TryParse(Console.ReadLine(), out someNum))
         {
             Console.WriteLine("Invalid number.. Please try again...");
         }

         return someNum;
     }
 }

