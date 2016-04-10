using System;

class MostFrequentNumberInArray
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        double[] floatArr = new double[arrSize];

        SetElementsValue(floatArr);
        int max = FindMostFrequentNumber(floatArr);

        Console.WriteLine("The most frequent |{0}| numbers: ", max);
        FindAllNumbers(floatArr, max);
    }

    static void SetElementsValue(double[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = double.Parse(Console.ReadLine());
        }
    }

    static int FindMostFrequentNumber(double[] arr)
    {
        int counter = 0;
        int max = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                }
            }

            if (max < counter)
            {
                max = counter;
            }
                
            counter = 0;
        }

        return max;
    }

    static void FindAllNumbers(double[] arr, int max)
    {
        int counter = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                }
            }

            if (max == counter)
            {
                Console.WriteLine(arr[i]);
            }

            counter = 0;
        }
    }
}

