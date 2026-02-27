using System;

class t3
{
    static void AttemptSwap(int x, int y)
    {
        int hold = x;
        x = y;
        y = hold;
    }

    static void TrueSwap(ref int x, ref int y)
    {
        int hold = x;
        x = y;
        y = hold;
    }

    static void Main()
    {
        int n1 = 3, n2 = 8;

        AttemptSwap(n1, n2);
        Console.WriteLine("After first try: " + n1 + ", " + n2);

        TrueSwap(ref n1, ref n2);
        Console.WriteLine("After real swap: " + n1 + ", " + n2);
    }
}