using System;

class ConvertNumberToText
{
    static void Main(string[] args)
    {
        uint someNumber;

        Console.WriteLine("Please enter a number in the range [0..999]");
        while (!uint.TryParse(Console.ReadLine(), out someNumber) || someNumber > 999)
        {
            Console.WriteLine("Invalid number. Please try again..");
        }

        string strNumber = someNumber.ToString();

        Console.WriteLine();

        if (strNumber.Length == 1)
        {
            CheckDigits(strNumber[0]);    
        }
        else if (strNumber.Length == 2)
        {
            TwoDigitNumber(strNumber[0], strNumber[1]);
        }
        else
        {
            CheckDigits(strNumber[0]);
            Console.Write(" HUNDRED ");
            int buf = int.Parse(strNumber[1].ToString() + strNumber[2].ToString());
            if (buf > 0 && buf < 20)
                Console.Write("AND ");
            TwoDigitNumber(strNumber[1], strNumber[2]);
        }

        Console.WriteLine();
    }

    static void TwoDigitNumber(char firstDigit, char secondDigit)
    {
        string number = firstDigit.ToString() + secondDigit.ToString();

        switch (number)
        {
            case "10":
                Console.Write("TEN");
                break;
            case "11":
                Console.Write("ELEVEN");
                break;
            case "12":
                Console.Write("TWELVE");
                break;
            case "13":
                Console.Write("THIRTEEN");
                break;
            case "15":
                Console.Write("FIFTEEN");
                break;
            case "20":
                Console.Write("TWENTY");
                break;
            case "30":
                Console.Write("THIRTY");
                break;
            case "40":
                Console.Write("FORTY");
                break;
            case "50":
                Console.Write("FIFTY");
                break;
            case "60":
                Console.Write("SIXTY");
                break;
            case "70":
                Console.Write("SEVENTY");
                break;
            case "80":
                Console.Write("EIGHTY");
                break;
            case "90":
                Console.Write("NINETY");
                break;
            default:
                if (firstDigit != '0' || secondDigit != '0')
                {
                    CombineNumName(firstDigit, secondDigit);
                }
                break;
        }
    }

    static void CombineNumName(char firstDigit, char secondDigit)
    {
        int number = int.Parse(firstDigit.ToString() + secondDigit.ToString());

        if (number >= 13 && number != 15  && number < 20)
        {
            CheckDigits(secondDigit);
            Console.Write("TEEN ");
        }
        else
        {
            if (number > 1 && number < 20)
            {
                TwoDigitNumber(firstDigit, secondDigit);
            }
            else
            {
                if (number != 1)
                {
                    TwoDigitNumber(firstDigit, '0');
                    if (secondDigit != '0')
                    {
                        Console.Write(" ");
                        CheckDigits(secondDigit);
                    }
                }
                else
                {
                    CheckDigits(secondDigit);
                }
            }
        }
    }

    static void CheckDigits(char digit)
    {
        switch (digit)
        {
            case '0':
                Console.Write("ZERO");
                break;
            case '1':
                Console.Write("ONE");
                break;
            case '2':
                Console.Write("TWO");
                break;
            case '3':
                Console.Write("THREE");
                break;
            case '4':
                Console.Write("FOUR");
                break;
            case '5':
                Console.Write("FIVE");
                break;
            case '6':
                Console.Write("SIX");
                break;
            case '7':
                Console.Write("SEVEN");
                break;
            case '8':
                Console.Write("EIGHT");
                break;
            case '9':
                Console.Write("NINE");
                break;
        }
    }
}

