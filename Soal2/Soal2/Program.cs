using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        double average = CalculateAverage(numbers, numbers.Length);

        Console.WriteLine($"The average is: {average}");
    }

    static double CalculateAverage(int[] arr, int n)
    {
        if (n == 0)
        {
            return 0;
        }

        double sum = arr[n - 1] + CalculateAverage(arr, n - 1);

        return sum / n;
    }
}