using System;

class LargestNumber
{
    static void Main()
    {
        Console.Write("N: ");
        int elemCount = int.Parse(Console.ReadLine());

        Console.Write("K: ");
        int K = int.Parse(Console.ReadLine());

        int[] intArr = new int[elemCount];
        SetMatrix(intArr);

        Array.Sort(intArr);
        int index, searchCounter = 0;

        do
        {
            index = Array.BinarySearch(intArr, K);
            K--;
            searchCounter++;
        }
        while (index < 0 && searchCounter <= intArr.Length);

        if (index >= 0)
        {
            Console.WriteLine("The largest number: {0}", intArr[index]);
        }
        else
        {
            Console.WriteLine("Not found!");
        }
    }

    static void SetMatrix(int[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("[{0}] = ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }
    }
}

