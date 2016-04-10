using System;

public class ExpressionBrackets
{
    public static void Main()
    {
        try
        {
            Console.WriteLine(CheckExpressionBrackets("((a+b)/5-d)"));
            Console.WriteLine(CheckExpressionBrackets(")((5+6)"));
        }
        catch (NullReferenceException)
        {
            Console.Error.WriteLine("Invalid input! Please enter a non null string!");
        }
    }

    public static bool CheckExpressionBrackets(string expression)
    {
        int counter = 0;
        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                counter++;
            }
            else if (expression[i] == ')')
            {
                counter--;
            }

            if (counter < 0)
            { 
                break;
            }
        }

        return counter == 0 ? true : false;
    }
}