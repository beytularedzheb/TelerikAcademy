using System;
using System.Collections.Generic;

class SelectionSort
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        float[] floatArr = new float[arrSize];

        SetElementsValue(floatArr);
        Selection_Sort(floatArr);
        PrintArray(floatArr);
    }

    static void PrintArray(float[] arr)
    {
        Console.WriteLine();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void SetElementsValue(float[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = float.Parse(Console.ReadLine());
        }
    }

    static void Selection_Sort(float[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    float tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
    }
}

