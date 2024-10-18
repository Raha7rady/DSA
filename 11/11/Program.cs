using System;

class Program
{
    static void Main()
    {
        int n = 20;
        PrintCoinCombinations(n, 0, 0, 0);
    }

    static void PrintCoinCombinations(int remaining, int twoCount, int fiveCount, int tenCount)
    {
        if (remaining == 0)
        {
            Console.WriteLine($"{twoCount} : {twoCount} {fiveCount} {tenCount}");
            return;
        }

        if (remaining < 0)
            return;

        PrintCoinCombinations(remaining - 2, twoCount + 1, fiveCount, tenCount);

        PrintCoinCombinations(remaining - 5, twoCount, fiveCount + 1, tenCount);

        PrintCoinCombinations(remaining - 10, twoCount, fiveCount, tenCount + 1);
    }
}