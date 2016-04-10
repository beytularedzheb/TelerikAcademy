using System;


class MaximalSum
{
    static void Main()
    {
        // не правя проверка на входните данни, за да спестя време :)

        Console.WriteLine("Please enter a positiv integer number N:");
        int arrSizeN = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a positiv integer number K (0 < K <= N)");
        int elementsK = int.Parse(Console.ReadLine());

        int[] intArray = new int[arrSizeN];

        SetElementsValue(intArray);

        int maxSum = FindMaximalSum(intArray, elementsK);

        Console.WriteLine("Maximal Sum = {0}", maxSum);

        FindAllSolutions(intArray, elementsK, maxSum);
    }

    static void SetElementsValue(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    // функция за намиране на максималната сума от К елемента
    static int FindMaximalSum(int[] arr, int k)
    {
        int currentSum = 0;
        int maxSum = 0;

        for (int i = 0; i <= arr.Length - k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                currentSum += arr[i + j];
            }

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
            }

            currentSum = 0;
        }

        return maxSum;
    }


    // функция за намиране на всички редици с К на брой елемента,
    // които имат сума равна на максималната намерена сума
    static void FindAllSolutions(int[] arr, int k, int maxSum)
    {
        int currentSum = 0;

        for (int i = 0; i <= arr.Length - k; i++)
        {
            for (int j = 0; j < k; j++)
            {
                currentSum += arr[i + j];
            }

            if (maxSum == currentSum)
            {

                for (int j = i; j < i + k; j++)
                {
                    Console.Write("{0} ", arr[j]);
                }

                Console.WriteLine();
            }

            currentSum = 0;
        }
    }
}


