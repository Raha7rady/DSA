using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 5, 7, 2, 8, 1 ,11 , 4 };
        int max = FindMax(array, array.Length);
        Console.WriteLine($"Maximum element in the array is: {max}");
    }

    static int FindMax(int[] arr, int n)
    {
        if (n == 0)
            return 0;

        if (n == 1)
            return arr[0];

        int maxOfRest = FindMax(arr, n - 1);

        if (arr[n - 1] > maxOfRest)
            return arr[n - 1];
        else
            return maxOfRest;
    }
}