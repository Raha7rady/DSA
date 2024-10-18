using System;

class Program
{
    public static void Main()
    {

        int[] numbers = { 1, 3, 4, 9 , 7 , 2 , 5 };

        Console.Write("Original array: ");
        PrintArray(numbers);

        ReverseArray(numbers, 0, numbers.Length - 1);

        Console.Write("Reversed array: ");
        PrintArray(numbers);

    }

    public static void ReverseArray(int[] arr, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;

        ReverseArray(arr, start + 1, end - 1);
    }

    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1) 
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}