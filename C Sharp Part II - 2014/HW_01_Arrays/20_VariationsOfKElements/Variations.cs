using System;

class Variations
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Please enter K: ");
        int[] intArr = new int[int.Parse(Console.ReadLine())];
        FindVariations(k, intArr, 0);
    }

    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + 1 + " ");
        Console.WriteLine();
    }

    static void FindVariations(int n, int[] arr, int i)
    {
        if (i == arr.Length)
        {
            Print(arr);
            return;
        }

        for (int j = 0; j < n; j++)
        {
            arr[i] = j;
            FindVariations(n, arr, i + 1);
        }
    }
}

