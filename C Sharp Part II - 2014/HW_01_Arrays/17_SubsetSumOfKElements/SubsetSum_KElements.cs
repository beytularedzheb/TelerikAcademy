using System;
using System.Collections.Generic;

class SubsetSum_KElements
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        double[] floatArr = new double[arrSize];

        SetElementsValue(floatArr);


        Console.WriteLine("Please enter the sum (S):");
        double sum = double.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the K:");
        int subsetLen = int.Parse(Console.ReadLine());

        IsExistSubset(floatArr, sum, subsetLen);
    }

    static void SetElementsValue(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = double.Parse(Console.ReadLine());
        }
    }

    static void IsExistSubset(double[] arr, double sum, int subsetLen)
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

            if (currentSum == sum && itemList.Count == subsetLen)
            {
                if (!hasSum)
                {
                    Console.WriteLine("Yes");
                }

                hasSum = true;

                for (int k = 0; k < itemList.Count; k++)
                {
                    Console.Write("[{0}] {1} ", itemList[k], arr[itemList[k]]);
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

