using System;

class SortArrayByLength
{
    static void Main()
    {
        Console.Write("N: ");
        int elemCount = int.Parse(Console.ReadLine());

        string[] strArr = new string[elemCount];

        SetArray(strArr);
        Console.WriteLine("\n\rUnsorted!");
        PrintArray(strArr);

        Array.Sort(strArr, (x, y) => (y.Length).CompareTo(x.Length));
        Console.WriteLine("\n\rSorted!");
        PrintArray(strArr);
    }

    static void SetArray(string[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            Console.Write("[{0}] = ", index);
            arr[index] = Console.ReadLine();
        }
    }

    static void PrintArray(string[] arr)
    {
        for (int index = 0; index < arr.Length; index++)
        {
            Console.WriteLine("{0} ", arr[index]);
        }
    }
}

