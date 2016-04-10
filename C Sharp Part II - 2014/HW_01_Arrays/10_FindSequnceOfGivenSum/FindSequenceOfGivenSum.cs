using System;
using System.Collections.Generic;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        double[] floatArr = new double[arrSize];

        SetElementsValue(floatArr);

        Console.WriteLine("Please enter the sum (S):");
        double sum = double.Parse(Console.ReadLine());

        FindSequence(floatArr, sum);
    }

    static void SetElementsValue(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = double.Parse(Console.ReadLine());
        }
    }

    // Функция за намиране на редица/ци (с поредни елементи),
    // чиято сума е равна на S 
    static void FindSequence(double[] arr, double sum)
    {
        double currentSum = 0;
        bool hasSum = false;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                currentSum += arr[j];

                if (currentSum == sum)
                {
                    hasSum = true;

                    for (int k = i; k < j + 1; k++)
                    {
                        Console.Write("{0} ", arr[k]);
                    }

                    Console.WriteLine();

                    break;
                }
            }
            currentSum = 0;
        }

        if (!hasSum)
        {
            Console.WriteLine("No");
        }
    }
}

