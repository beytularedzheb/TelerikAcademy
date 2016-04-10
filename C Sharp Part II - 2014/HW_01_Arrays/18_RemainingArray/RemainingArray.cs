using System;
using System.Collections.Generic;

class RemainingArray
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        double[] floatArr = new double[arrSize];

        SetElementsValue(floatArr);

        FindRemArray(floatArr);
    }

    static void SetElementsValue(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = double.Parse(Console.ReadLine());
        }
    }

    static bool IsSortedInIncOrd(List<double> arr)
    {
        bool result = true;

        for (int i = 0; i < arr.Count - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                result = false;
                break;
            }
        }

        return result;
    }

    static void FindRemArray(double[] arr)
    {
        List<double> resultList = new List<double>();
        int max = 0;
        bool isSorted = false;

        for (int i = 0; i < Math.Pow(2, arr.Length); i++)
        {
            List<double> itemList = new List<double>();

            for (int j = 0; j < arr.Length; j++)
            {
                if (((i >> (j)) & 1) == 1)
                {
                    itemList.Add(arr[j]);
                }
            }

            isSorted = IsSortedInIncOrd(itemList);

            if (itemList.Count > max && isSorted)
            {
                max = itemList.Count;
                resultList = itemList;
            }
        }

        resultList.TrimExcess();
        for (int i = 0; i < resultList.Count; i++)
        {
            Console.Write("{0} ", resultList[i]);
        }
        Console.WriteLine();
    }
}

