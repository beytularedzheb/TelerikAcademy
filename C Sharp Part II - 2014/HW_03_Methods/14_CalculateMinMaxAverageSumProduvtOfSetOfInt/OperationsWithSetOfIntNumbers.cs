using System;

class OperationsWithSetOfIntNumbers
{
    static void Main()
    {
        // когато се извикват без параметри се връща 0
        Console.WriteLine("Minimal");
        Console.WriteLine(MinimalElement<uint>());
        Console.WriteLine(MinimalElement<uint>(340, 450, 19));
        Console.WriteLine(MinimalElement<float>(10.2f, 2f, 6.2f, 1.1f));

        Console.WriteLine("Maximal");
        Console.WriteLine(MaximalElement<byte>());
        Console.WriteLine(MaximalElement<byte>(10, 2, 6, 0));
        Console.WriteLine(MaximalElement<float>(10.2f, 2f, 6.2f, 1.1f));

        Console.WriteLine("Average");
        Console.WriteLine(Average<long>());
        Console.WriteLine(Average<long>(-10L, 2L, 68L, 0L));
        Console.WriteLine(Average<double>(10.2d, 2d, 6.2d, 1.1d));

        Console.WriteLine("Sum");
        Console.WriteLine(Sum<byte>()); 
        Console.WriteLine(Sum<byte>(255, 100)); 
        Console.WriteLine(Sum<decimal>(10.2M, 2M, 6.2M, 1.1M));


        Console.WriteLine("Product");
        Console.WriteLine(Product<short>());
        Console.WriteLine(Product<short>(1, 2, -1, 10000));
        Console.WriteLine(Product<byte>(255, 255));
    }

    static dynamic MinimalElement<T>(params T[] arr)
    {
        dynamic min = arr.Length > 0 ? (dynamic)arr[0] : 0;
        for (int i = 1; i < arr.Length; i++)
        {
            if (min > (dynamic)arr[i])
            {
                min = arr[i];
            }
        }
        return min;
    }

    static dynamic MaximalElement<T>(params T[] arr)
    {
        dynamic max = arr.Length > 0 ? (dynamic)arr[0] : 0;
 
        for (int i = 1; i < arr.Length; i++)
        {
            if (max < (dynamic)arr[i])
            {
                max = arr[i];
            }
        }
        return max;
    }

    static dynamic Average<T>(params T[] arr)
    {
        dynamic sum = Sum<T>(arr);
        if (arr.Length > 0)
        { 
            return sum / arr.Length;
        }
        return 0;
    }

    static dynamic Sum<T>(params T[] arr)
    {
        dynamic sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }

    static dynamic Product<T>(params T[] arr)
    {
        dynamic product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            product *= arr[i];
        }
        if (arr.Length > 0)
        {
            return product;
        }
        return 0;
    }
}

