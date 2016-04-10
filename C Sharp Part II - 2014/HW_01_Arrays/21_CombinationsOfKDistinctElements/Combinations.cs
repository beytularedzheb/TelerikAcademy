using System;


class Combinations
{
    static void Print(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) 
            Console.Write(arr[i] + 1 + " ");
        Console.WriteLine();
    }

    static void Combination(int n, int[] arr, int i, int next)
    {
        if (i == arr.Length)
        {
            Print(arr);
            return;
        }

        for (int j = next; j < n; j++)
        {
            arr[i] = j;

            Combination(n, arr, i + 1, j + 1);
        }
    }

    static void Main()
    {
        Console.Write("Please enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please enter K: ");
        int[] intArr = new int[int.Parse(Console.ReadLine())];

        Combination(n, intArr, 0, 0);
    }
}

