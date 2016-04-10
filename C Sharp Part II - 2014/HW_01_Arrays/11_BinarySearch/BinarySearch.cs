using System;

class BinarySearch
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        int[] intArr = new int[arrSize];

        SetElementsValue(intArr);
        Array.Sort(intArr);

        Console.WriteLine("Sorted array:");
        PrintArray(intArr);

        Console.WriteLine("Please enter the element for searching:");
        Object keyword = int.Parse(Console.ReadLine());

        ///////////////////////////////////////////////////////////////////////////
        int result = Array.BinarySearch(intArr, keyword);
        Console.WriteLine("Using the built-in method.");

        if (result < 0)
        {
            Console.WriteLine("Not found!");
        }
        else
        {
            Console.WriteLine("Index [{0}] | Value [{1}]", result, intArr[result]);
        }
        ///////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////
        result = BinSearch(intArr, 0, intArr.Length, (int)keyword);
        Console.WriteLine("Using my method.");

        if (result < 0)
        {
            Console.WriteLine("Not found!");
        }
        else
        {
            Console.WriteLine("Index [{0}] | Value [{1}]", result, intArr[result]);
        }
        ///////////////////////////////////////////////////////////////////////////
    }

    static void PrintArray(int[] arr)
    {
        Console.WriteLine();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void SetElementsValue(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    static int BinSearch(int[] arr, int min, int max, int keyword)
    {
        int mid;
        while (min <= max)
        {
            mid = (min + max) / 2;
            if (arr[mid] < keyword)
            {
                min = mid + 1;
                continue;
            }
            else if (arr[mid] > keyword)
            {
                max = mid - 1;
                continue;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
}

