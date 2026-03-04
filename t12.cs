using System;

class t12
{
    static void IncreaseCopy(int num)
    {
        num += 2;
    }

    static void IncreaseOriginal(ref int num)
    {
        num += 2;
    }

    static void Main()
    {
        int points = 3;

        IncreaseCopy(points);
        Console.WriteLine("Num: " + points);

        IncreaseOriginal(ref points);
        Console.WriteLine("After Increase Original: " + points);
    }
}