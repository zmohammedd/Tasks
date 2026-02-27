using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int checkNum = int.Parse(Console.ReadLine());

        string output = (checkNum % 3 == 0 && checkNum % 4 == 0) ? "Yes" : "No";
        Console.WriteLine(output);
    }
}