using System;

class Program
{
    static void Main()
    {
        string[] input = ReadInput();
        LetsDance(input);
    }

    static void LetsDance(string[] input)
    {
        const byte up = 1, down = 2, left = 3, right = 4;
        int row = 1, col = 1;
        byte rotatedir = up;

        string[,] colors = new string[3, 3];
        colors[0, 0] = colors[0, 2] = colors[2, 0] = colors[2, 2] = "RED";
        colors[0, 1] = colors[2, 1] = colors[1, 0] = colors[1, 2] = "BLUE";
        colors[1, 1] = "GREEN";

        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < input[i].Length; j++)
            {
                if (input[i][j] == 'W')
                {
                    if (rotatedir == up)
                    {
                        row = row == 0 ? 2 : row - 1;
                    }
                    else if (rotatedir == left)
                    {
                        col = col == 0 ? 2 : col - 1;
                    }
                    else if (rotatedir == down)
                    {
                        row = row == 2 ? 0 : row + 1;
                    }
                    else if (rotatedir == right)
                    {
                        col = col == 2 ? 0 : col + 1;
                    }
                }
                else if (input[i][j] == 'L')
                {
                    if (rotatedir == up) rotatedir = left;
                    else if (rotatedir == left) rotatedir = down;
                    else if (rotatedir == down) rotatedir = right;
                    else rotatedir = up;
                }
                else
                {
                    if (rotatedir == up) rotatedir = right;
                    else if (rotatedir == right) rotatedir = down;
                    else if (rotatedir == down) rotatedir = left;
                    else rotatedir = up;
                }
            }

            Console.WriteLine(colors[row, col]);
            row = col = 1;
        }
    }

    static string[] ReadInput()
    {
        byte n = byte.Parse(Console.ReadLine());

        string[] input = new string[n];

        for (int i = 0; i < n; i++)
        {
            input[i] = Console.ReadLine();
        }

        return input;
    }
}