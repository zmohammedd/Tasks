using System;

class t6
{
    static void Main()
    {
        Console.Write("Enter a temperature: ");
        int tempValue = int.Parse(Console.ReadLine());

        string message =
            (tempValue < 10) ? "Just Cold" :
            (tempValue > 30) ? "Just Hot" :
            "Just Good";

        Console.WriteLine("Result: " + message);
    }
}
