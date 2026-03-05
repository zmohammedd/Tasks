using System;

class t20
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        int largest = int.MinValue;
        int second = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > largest)
            {
                second = largest;
                largest = arr[i];
            }
            else if (arr[i] > second && arr[i] != largest)
            {
                second = arr[i];
            }
        }
        Console.WriteLine("Second largest = " + second);
    }
}