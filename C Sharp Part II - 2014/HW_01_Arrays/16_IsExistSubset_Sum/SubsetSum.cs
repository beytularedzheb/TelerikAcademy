using System;
using System.Collections.Generic;

class SubsetSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        double[] floatArr = new double[arrSize];

        SetElementsValue(floatArr);


        Console.WriteLine("Please enter the sum (S):");
        double sum = double.Parse(Console.ReadLine());

        IsExistSubset(floatArr, sum);
    }

    static void SetElementsValue(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = double.Parse(Console.ReadLine());
        }
    }

    static void IsExistSubset(double[] arr, double sum)
    {
        bool hasSum = false;
        List<int> itemList = new List<int>();

        for (int i = 0; i < Math.Pow(2, arr.Length); i++)
        {
            double currentSum = 0;
            itemList.Clear();

            for (int j = 0; j < arr.Length; j++)
            {
                if (((i >> (j)) & 1) == 1)
                {
                    currentSum += arr[j];
                    itemList.Add(j);
                }     
            }

            if (currentSum == sum)
            {
                if (!hasSum)
                {
                    Console.WriteLine("Yes");
                }

                hasSum = true;

                // Първото число - |{0}| е индексът на числото, второто - {1} самото число
                for (int k = 0; k < itemList.Count; k++)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("|{0}| ", itemList[k]);

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("{0} ", arr[itemList[k]]);
                }
                Console.WriteLine();
            }
        }

        if (!hasSum)
        {
            Console.WriteLine("No");
        }
    }
}

