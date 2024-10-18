using System;
using System.Collections.Generic;

class Program
{
    const int N = 8;

    static void Main()
    {
        List<int> positions = new List<int>(new int[N]);
        int solutionCount = 0;
        PlaceQueens(positions, 0, ref solutionCount);
        Console.WriteLine("Total solutions: " + solutionCount);
    }

    static bool IsSafe(List<int> positions, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            if (positions[i] == col ||
            positions[i] - i == col - row ||
            positions[i] + i == col + row)
            {
                return false;
            }
        }
        return true;
    }

    static void PlaceQueens(List<int> positions, int row, ref int solutionCount)
    {
        if (row == N)
        {
            solutionCount++;
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    if (positions[r] == c)
                        Console.Write("Q ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return;
        }

        for (int col = 0; col < N; col++)
        {
            if (IsSafe(positions, row, col))
            {
                positions[row] = col;
                PlaceQueens(positions, row + 1, ref solutionCount);
            }
        }
    }
}