using System;

class t16
{
    static bool IsPrimeNumber(int n)
    {
        if (n <= 1)
            return false;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int value = int.Parse(Console.ReadLine());

        if (IsPrimeNumber(value))
            Console.WriteLine("Prime");
        else
            Console.WriteLine("Not Prime");
    }
}