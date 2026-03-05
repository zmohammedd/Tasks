using System;

class t17
{
    static void FindMinMax(int[] arr, ref int min, ref int max)
    {
        min = arr[0];
        max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];

            if (arr[i] > max)
                max = arr[i];
        }
    }
    static void Main()
    {
        Console.Write("Enter an array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int min = 0, max = 0;
        FindMinMax(numbers, ref min, ref max);
        Console.WriteLine("Minimum = " + min);
        Console.WriteLine("Maximum = " + max);
    }
}