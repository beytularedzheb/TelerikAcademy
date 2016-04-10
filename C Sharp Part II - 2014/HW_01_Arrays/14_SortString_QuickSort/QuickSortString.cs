using System;

class QuickSortString
{
    static void Main()
    {
        Console.WriteLine("Please enter the size of the array:");
        int arrSize = int.Parse(Console.ReadLine());

        string[] strArr = new string[arrSize];

        SetElementsValue(strArr);

        QSort(strArr, 0, strArr.Length - 1);

        PrintArray(strArr);
    }

    static void PrintArray(string[] arr)
    {
        Console.WriteLine();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }

    static void SetElementsValue(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("[{0}] = ", i);
            arr[i] = Console.ReadLine();
        }
    }

    static void QSort(string[] arr, int startIndex, int len)
    {
        int i = startIndex;
        int j = len;
        string bufOne = arr[(i + j) / 2], bufTwo;

        do
        {
            int compare = String.Compare(arr[i], bufOne);
            while (compare < 0 && i < len)
            {
                i++;
                compare = String.Compare(arr[i], bufOne);
            }

            compare = String.Compare(arr[j], bufOne);
            while (compare > 0 && j > startIndex)
            {
                j--;
                compare = String.Compare(arr[j], bufOne);
            }

            if (i <= j)
            {
                bufTwo = arr[i];
                arr[i] = arr[j];
                arr[j] = bufTwo;
                i++;
                j--;
            }
        }
        while (i <= j);

        if (startIndex < j) 
        {
            QSort(arr, startIndex, j);
        }

        if (i < len) 
        {
            QSort(arr, i, len);
        }
    }
}

