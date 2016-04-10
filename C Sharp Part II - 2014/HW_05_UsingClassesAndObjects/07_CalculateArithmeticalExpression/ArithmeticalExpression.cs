using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

public class ArithmeticalExpression
{
    private static readonly List<string> Functions = new List<string>()
    { 
        "pow", "sqrt", "ln"
    };

    private static readonly List<string> Operators = new List<string>()
    {
        "+", "-", "*", "/"
    };

    public static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        StartCalculating();
    }

    public static string ClearWhiteSpaces(string input)
    {
        char[] delimiter = { ' ', '\t' };
        StringBuilder clearedInput = new StringBuilder();
        string[] arr = input.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
        
        for (int i = 0; i < arr.Length; i++)
        {
            clearedInput.Append(arr[i]);
        }

        return clearedInput.ToString();
    }

    public static Queue<string> ConvertToRPN(string input)
    {
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        StringBuilder number = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '-' && (i == 0 || input[i - 1] == ',' || input[i - 1] == '('))
            {
                number.Append(input[i]);
            }
            else if (char.IsDigit(input[i]))
            {
                bool isReadedPoint = false;
                do
                {
                    number.Append(input[i]);
                    i++;
                    if (i < input.Length && input[i] == '.')
                    {
                        if (isReadedPoint)
                        {
                            throw new ArgumentException("Invalid decimal point!");
                        }
                        else
                        {
                            isReadedPoint = true;
                        }
                    }
                }
                while (i < input.Length && (char.IsDigit(input[i]) || input[i] == '.'));
                i--;
                queue.Enqueue(number.ToString());
                number.Clear();
            }
            else if (input[i] == ',')
            {
                if (stack.Count > 0 && !stack.Contains("("))
                {
                    throw new ArgumentException("The separator was misplaced or parentheses were mismatched.");
                }

                while (stack.Count > 0 && stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            else if (i + 1 < input.Length && Functions.Contains(input.Substring(i, 2).ToLower()))
            {
                stack.Push(input.Substring(i, 2).ToLower());
                i++;
            }
            else if (i + 2 < input.Length && Functions.Contains(input.Substring(i, 3).ToLower()))
            {
                stack.Push(input.Substring(i, 3).ToLower());
                i += 2;
            }
            else if (i + 3 < input.Length && Functions.Contains(input.Substring(i, 4).ToLower()))
            {
                stack.Push(input.Substring(i, 4).ToLower());
                i += 3;
            }
            else if (Operators.Contains(input[i].ToString()))
            {
                while (stack.Count > 0 && 
                    Operators.Contains(stack.Peek()) &&
                    PrecedenceOfOperators(input[i]) <= 
                    PrecedenceOfOperators(Convert.ToChar(stack.Peek())))
                {
                    queue.Enqueue(stack.Pop());
                }

                stack.Push(input[i].ToString());
            }
            else if (input[i] == '(')
            {
                stack.Push(input[i].ToString());
            }
            else if (input[i] == ')')
            {
                if (stack.Count > 0 && !stack.Contains("("))
                {
                    throw new ArgumentException("There are mismatched parentheses.");
                }

                while (stack.Count > 0 && stack.Peek() != "(")
                {
                    queue.Enqueue(stack.Pop());
                }

                if (stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    throw new ArgumentException("There are mismatched parentheses.");
                }

                while (stack.Count > 0 && Functions.Contains(stack.Peek()))
                {
                    queue.Enqueue(stack.Pop());
                }
            }
            else
            {
                throw new ArgumentException("Invalid expression!");
            }
        }

        if (stack.Count > 0 && (stack.Contains("(") || stack.Contains(")")))
        {
            throw new ArgumentException("There are mismatched parentheses.");
        }

        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }
    
    public static double CalculateRPN(Queue<string> rpnExpression)
    {
        Stack<double> stack = new Stack<double>();
        double number = 0d;

        while (rpnExpression.Count > 0)
        {
            string currentToken = rpnExpression.Dequeue();

            if (double.TryParse(currentToken, out number))
            {
                stack.Push(number);
            }
            else if (Operators.Contains(currentToken) || Functions.Contains(currentToken))
            {
                double result = 0d;

                if (currentToken == "sqrt" || currentToken == "ln")
                {
                    if (stack.Count < 1)
                    {
                        throw new ArgumentException("Error! No has input sufficient values in the expression.");
                    }

                    if (currentToken == "sqrt")
                    {
                        result = Math.Sqrt(stack.Pop());
                    }
                    else
                    {
                        result = Math.Log(stack.Pop());
                    }
                }
                else
                {
                    if (stack.Count < 2)
                    {
                        throw new ArgumentException("Error! No has input sufficient values in the expression.");
                    }

                    double firstOperand = stack.Pop();
                    double secondOperand = stack.Pop();

                    if (currentToken == "+")
                    {
                        result = firstOperand + secondOperand;
                    }
                    else if (currentToken == "-")
                    {
                        result = secondOperand - firstOperand;
                    }
                    else if (currentToken == "*")
                    {
                        result = firstOperand * secondOperand;
                    }
                    else if (currentToken == "/")
                    {
                        result = secondOperand / firstOperand;
                    }
                    else if (currentToken == "pow")
                    {
                        result = Math.Pow(secondOperand, firstOperand);
                    }
                }

                stack.Push(result);
            }
        }

        if (stack.Count == 1)
        {
            return stack.Pop();
        }
        else
        {
            throw new ArgumentException("Error! Too many values or values are not recognized.");
        }
    }

    private static void StartCalculating()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        input = ClearWhiteSpaces(input);

        while (input.ToLower() != "end")
        {
            try
            {
                Queue<string> rpnExpression = ConvertToRPN(input);
                double result = CalculateRPN(rpnExpression);
                Console.WriteLine(result);
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.Write("> ");
            input = Console.ReadLine();
            input = ClearWhiteSpaces(input);
        }
    }

    private static int PrecedenceOfOperators(char charOperator)
    {
        if (charOperator == '-' || charOperator == '+')
        {
            return 1;
        }

        return 2; // умножение или деление
    }
}