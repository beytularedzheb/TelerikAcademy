using System;

class CheckSumOfSubsetIsZero
{
    static void Main()
    {
        int sum = 0;
        int counter = 0;
        int[] numberArray = new int[5];

        Console.WriteLine("Please enter your 5 integer numbers:");

        for (int i = 0; i < numberArray.Length; i++)
        {
            Console.WriteLine("[{0}]", i + 1);

            while (!int.TryParse(Console.ReadLine(), out numberArray[i]))
            {
                Console.WriteLine("Invalid number.. Please try again...");
            }
        }

        Console.WriteLine();
        for (int i = 0; i < numberArray.Length; i++)
        {
            for (int j = (i + 1); j < numberArray.Length; j++)
            {
                sum = numberArray[i] + numberArray[j];
                if (sum == 0)
                {
                    counter++;
                    Console.WriteLine("{0} + {1} = {2}", numberArray[i], numberArray[j], sum);
                }

                for (int k = (j + 1); k < numberArray.Length; k++)
                {
                    sum += numberArray[k];
                    if (sum == 0)
                    {
                        counter++;
                        Console.WriteLine("{0} + {1} + {2} = {3}", numberArray[i], numberArray[j],
                            numberArray[k], sum);
                    }

                    for (int l = (k + 1); l < numberArray.Length; l++)
                    {
                        sum += numberArray[l];
                        if (sum == 0)
                        {
                            counter++;
                            Console.WriteLine("{0} + {1} + {2} + {3} = {4}", numberArray[i], numberArray[j],
                                numberArray[k], numberArray[l], sum);
                        }

                        for (int m = (l + 1); m < numberArray.Length; m++)
                        {
                            sum += numberArray[m];
                            if (sum == 0)
                            {
                                counter++;
                                Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", numberArray[i], numberArray[j],
                                    numberArray[k], numberArray[l], numberArray[m], sum);
                            }   
                        }
                    }
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("There is no subset which sum is 0!");
        }
    }
}

