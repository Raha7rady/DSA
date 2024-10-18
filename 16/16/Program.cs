using System;
using System.Collections.Generic;

class Program
{
    static void PrintSubsets(List<int> set, List<int> currentSubset, int index)
    {
        if (index == set.Count)
        {
            Console.Write("{ ");
            foreach (int num in currentSubset)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("}");
            return;
        }

        currentSubset.Add(set[index]);
        PrintSubsets(set, currentSubset, index + 1);

        currentSubset.RemoveAt(currentSubset.Count - 1);
        PrintSubsets(set, currentSubset, index + 1);
    }

    static void Main()
    {
        List<int> set = new List<int> { 1, 2, 3, 8 ,5 }; 
        List<int> currentSubset = new List<int>();

        PrintSubsets(set, currentSubset, 0);
    }
}