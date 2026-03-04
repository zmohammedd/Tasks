using System;

class t8
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int v = int.Parse(Console.ReadLine());
        string state = (v < 0) ? "negative" : "positive";
        Console.WriteLine(state);
    }
}