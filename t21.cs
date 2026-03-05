using System;
using System.Collections.Generic;

class t21
{
    static int GetLongestDistance(int[] arr)
    {
        Dictionary<int, int> firstIndex = new Dictionary<int, int>();
        int maxDistance = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int value = arr[i];
            if (!firstIndex.ContainsKey(value))
                firstIndex[value] = i;
            else
            {
                int distance = i - firstIndex[value] - 1;
                if (distance > maxDistance)
                    maxDistance = distance;
            }
        }

        return maxDistance;
    }
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Value: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Longest distance = " + GetLongestDistance(arr));
    }
}