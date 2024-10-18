
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 20;
        Console.WriteLine(" 10Count-5Coun-2Count");
        HashSet<string> uniqueCombinations = new HashSet<string>();
        PrintCoinCombinations(n, 0, 0, 0, uniqueCombinations);

        foreach (var combination in uniqueCombinations)
        {
            Console.WriteLine(combination);
        }
    }

    static void PrintCoinCombinations(int remaining, int twoCount, int fiveCount, int tenCount, HashSet<string> uniqueCombinations)
    {
        if (remaining == 0)
        {
            string combination = $"{tenCount} {fiveCount} {twoCount}";
            uniqueCombinations.Add(combination);
            return;
        }

        if (remaining < 0)
            return;

        PrintCoinCombinations(remaining - 10, twoCount, fiveCount, tenCount + 1, uniqueCombinations);

        PrintCoinCombinations(remaining - 5, twoCount, fiveCount + 1, tenCount, uniqueCombinations);

        PrintCoinCombinations(remaining - 2, twoCount + 1, fiveCount, tenCount, uniqueCombinations);
    }
}