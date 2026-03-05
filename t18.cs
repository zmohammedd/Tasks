using System;

class t18
{
    static long CalculateFactorial(int n)
    {
        long fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int value = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorial = " + CalculateFactorial(value));
    }
}