using System;

class Program
{
    static void Main()
    {
        Console.Write("First element: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Second element: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Third element: ");
        int n3 = int.Parse(Console.ReadLine());

        int biggest = n1;
        if (n2 > biggest) biggest = n2;
        if (n3 > biggest) biggest = n3;
        int smallest = n1;
        if (n2 < smallest) smallest = n2;
        if (n3 < smallest) smallest = n3;

        Console.WriteLine("max element = " + biggest);
        Console.WriteLine("min element = " + smallest);
    }
}