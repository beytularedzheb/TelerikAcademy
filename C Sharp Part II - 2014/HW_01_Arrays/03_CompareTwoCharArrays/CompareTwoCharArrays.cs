using System;

class CompareTwoCharArrays
{
    static void Main()
    {
        Console.WriteLine("1 - Please enter a string (to be converted): ");
        char[] firstCharArr = Console.ReadLine().ToCharArray();

        Console.WriteLine("2 - Please enter a string (to be converted): ");
        char[] secondCharArr = Console.ReadLine().ToCharArray();

        Console.WriteLine("Compare:");
        CompareCharArrays(firstCharArr, secondCharArr);
    }

    static void CompareCharArrays(char[] firstArr, char[] secondArr)
    {
        for (int i = 0; i < firstArr.Length; i++)
        {
            for (int j = 0; j < secondArr.Length; j++)
            {
                if (firstArr[i] == secondArr[j])
                {
                    Console.WriteLine("{0} : {1} | {2} = {3}", i, j,
                        firstArr[i], secondArr[j]);
                }
                else if (firstArr[i] < secondArr[j])
                {
                    Console.WriteLine("{0} : {1} | {2} < {3}", i, j,
                        firstArr[i], secondArr[j]);
                }
                else if (firstArr[i] > secondArr[j])
                {
                    Console.WriteLine("{0} : {1} | {2} > {3}", i, j,
                        firstArr[i], secondArr[j]);
                }
            }
        }
    }
}

