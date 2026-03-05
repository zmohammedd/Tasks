using System;

class t23
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Reverse order:");
        for (int i = n - 1; i >= 0; i--)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}