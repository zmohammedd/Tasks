using System;

class t15
{
    static int GetDigitsSum(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int result = GetDigitsSum(number);
        Console.WriteLine("Sum of digits = " + result);
    }
}