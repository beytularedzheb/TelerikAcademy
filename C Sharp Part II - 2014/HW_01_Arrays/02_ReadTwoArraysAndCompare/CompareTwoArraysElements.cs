using System;

class CompareTwoArraysElements
{
    static void Main()
    {
        uint firstArrSize;
        uint secondArrSize;

        // Не правя проверка на входните данни, за да спестя време :)

        Console.WriteLine("Please enter the size of the first array: ");
        firstArrSize = uint.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the size of the second array: ");
        secondArrSize = uint.Parse(Console.ReadLine());

        // т.к не е уточнено от какъв тип да са масивите, избирам String

        string[] firstArr = new string[firstArrSize];
        string[] secondArr = new string[secondArrSize];

        Console.WriteLine("First array: ");
        SetArraysElementsValue(firstArr);

        Console.WriteLine("Second array: ");
        SetArraysElementsValue(secondArr);

        // сравняването на елементите става лексикографско
        Console.WriteLine("Compare:");
        CompareTwoArrays(firstArr, secondArr);
    }

    static void SetArraysElementsValue(string[] arr)
    {
        for (uint i = 0; i < arr.Length; i++)
        {
            Console.Write("[{0}] = ", i);
            arr[i] = Console.ReadLine();
        }
    }

    static void CompareTwoArrays(string[] firstArr, string[] secondArr)
    {
        for (uint i = 0; i < firstArr.Length; i++)
        {
            for (int j = 0; j < secondArr.Length; j++)
            {
                int result = String.Compare(firstArr[i], secondArr[j]);

                if (result == 0)
                {
                    Console.WriteLine("{0} : {1} | {2} = {3}", i, j, 
                        firstArr[i], secondArr[j]);
                }
                else if (result < 0)
                {
                    Console.WriteLine("{0} : {1} | {2} < {3}", i, j,
                        firstArr[i], secondArr[j]);
                }
                else if (result > 0)
                {
                    Console.WriteLine("{0} : {1} | {2} > {3}", i, j,
                        firstArr[i], secondArr[j]);
                }
            }
        }
    }
}

