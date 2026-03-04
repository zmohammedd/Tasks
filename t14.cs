using System;

class t14
{
    static int Calculate(int a, int b, int c, int d)
    {
        int sum_part = a + b;
        int subtract_part = c + d;
        return sum_part - subtract_part;
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int n2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int n3 = int.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        int n4 = int.Parse(Console.ReadLine());
        int result = Calculate(n1, n2, n3, n4);

        Console.WriteLine("Result = " + result);
    }
}