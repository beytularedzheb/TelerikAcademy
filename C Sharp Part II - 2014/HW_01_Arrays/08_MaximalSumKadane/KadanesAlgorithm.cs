using System;

class KadanesAlgorithm
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        double[] floatArr = new double[arrSize];

        SetElementsValue(floatArr);

        FindMaxSum_Kadane(floatArr);
    }

    static void SetElementsValue(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = double.Parse(Console.ReadLine());
        }
    }

    static void FindMaxSum_Kadane(double[] arr)
    {
        double maxSoFar = arr[0];
        double maxEndingHere = arr[0];
        int begin = 0;
        int begin_temp = 0;
        int end = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (maxEndingHere < 0)
            {
                maxEndingHere = arr[i];
                begin_temp = i;
            }
            else
            {
                maxEndingHere += arr[i];
            }

            if (maxEndingHere >= maxSoFar)
            {
                maxSoFar = maxEndingHere;
                begin = begin_temp;
                end = i;
            }
        }

        Console.WriteLine("Maximal sum = {0}", maxSoFar);
        for (int i = begin; i <= end; i++)
        {
            Console.Write("{0} ", arr[i]);
        }

        Console.WriteLine();
    }
}

